using System;
using System.Text;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Net.Mail;

namespace EH1
{
    public partial class Password_Recover : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string email_ID = TextBox1.Text;
            SqlConnection Con = new SqlConnection("Data Source=DILIPC;Database=Dilip;Initial Catalog=Dilip;User ID=sa;Password=SQLserver!1");
            SqlCommand cmd = Con.CreateCommand();
            Con.Open();
            SqlDataReader Row_reader;

            cmd.CommandText = "Select Username from Members where email_ID ='" + email_ID + "'";
            Row_reader = cmd.ExecuteReader();
            if (Row_reader.Read() == true)
            {
                Row_reader.Close();
                string forgot = "Forgot";
                //Session["email_ID2"] = email_ID;
                Random random = new Random();
                string combination = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
                StringBuilder scrand = new StringBuilder();
                for (int i = 0; i < 6; i++)
                    scrand.Append(combination[random.Next(combination.Length)]);
                string temp_pass = scrand.ToString();



                string temp_pass2 = string.Copy(temp_pass);
                temp_pass = PasswordHash.HashPassword(temp_pass);
                cmd.CommandText = "Update [Members] SET Password = '" + temp_pass + "',Password_Status = '" + forgot + "' Where email_ID='" + email_ID + "';";
                Row_reader = cmd.ExecuteReader();
                Row_reader.Close();
                cmd.CommandText = "Select Username from [Members] where email_ID='" + email_ID + "'";
                string un = cmd.ExecuteScalar().ToString();
                Con.Close();


                MailMessage mail = new MailMessage();
                mail.To.Add(email_ID);
                mail.From = new MailAddress("dilipof6@gmail.com", "Secure Web Application", System.Text.Encoding.UTF8);
                mail.Subject = "Password Recovery";
                mail.SubjectEncoding = System.Text.Encoding.UTF8;
                mail.Body = "The Username is '" + un + "' and new password is '" + temp_pass2 + "' . Kindly Use this Username and temperory password to login and change your password from there.  ";
                mail.BodyEncoding = System.Text.Encoding.UTF8;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.High;
                SmtpClient client = new SmtpClient();
                client.Credentials = new System.Net.NetworkCredential("dilipof6@gmail.com", "anisatge1692");
                client.Port = 587;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
                try
                {
                    client.Send(mail);
                    Page.RegisterStartupScript("UserMsg", "<script>alert('If the mail ID is valid then a Mail will be Successfully Send To Recover Your Password...')</script>");
                }
                catch (Exception ex)
                {
                    Exception ex2 = ex;
                    string errorMessage = string.Empty;
                    while (ex2 != null)
                    {
                        errorMessage += ex2.ToString();
                        ex2 = ex2.InnerException;
                    }
                    Page.RegisterStartupScript("UserMsg", "<script>alert('Sending Failed...')</script>");
                    
                }
                //SMTP Ends

            }
            else
            {
                Page.RegisterStartupScript("UserMsg", "<script>alert('If the mail ID is valid then a Mail will be Successfully Send To Recover Your Password...')</script>");
            }

            }

        public class PasswordHash
        {
            public const int SaltByteSize = 24;
            public const int HashByteSize = 20; // to match the size of the PBKDF2-HMAC-SHA-1 hash 
            public const int Pbkdf2Iterations = 1000;
            public const int IterationIndex = 0;
            public const int SaltIndex = 1;
            public const int Pbkdf2Index = 2;

            public static string HashPassword(string password)
            {
                var cryptoProvider = new RNGCryptoServiceProvider();
                byte[] salt = new byte[SaltByteSize];
                cryptoProvider.GetBytes(salt);
                var hash = GetPbkdf2Bytes(password, salt, Pbkdf2Iterations, HashByteSize);
                return Pbkdf2Iterations + ":" + Convert.ToBase64String(salt) + ":" + Convert.ToBase64String(hash);
            }
            public static bool ValidatePassword(string password, string correctHash)
            {
                char[] delimiter = { ':' };
                var split = correctHash.Split(delimiter);
                var iterations = Int32.Parse(split[IterationIndex]);
                var salt = Convert.FromBase64String(split[SaltIndex]);
                var hash = Convert.FromBase64String(split[Pbkdf2Index]);
                var testHash = GetPbkdf2Bytes(password, salt, iterations, hash.Length);
                return SlowEquals(hash, testHash);
            }
            private static bool SlowEquals(byte[] a, byte[] b)
            {
                var diff = (uint)a.Length ^ (uint)b.Length;
                for (int i = 0; i < a.Length && i < b.Length; i++)
                {
                    diff |= (uint)(a[i] ^ b[i]);
                }
                return diff == 0;
            }
            private static byte[] GetPbkdf2Bytes(string password, byte[] salt, int iterations, int outputBytes)
            {
                var pbkdf2 = new Rfc2898DeriveBytes(password, salt);
                pbkdf2.IterationCount = iterations;
                return pbkdf2.GetBytes(outputBytes);
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }
    }
}