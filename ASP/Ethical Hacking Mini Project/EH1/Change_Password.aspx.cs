using System;
using System.Data.SqlClient;
using System.Security.Cryptography;


namespace EH1
{
    public partial class Change_Password : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String un = Session["un"].ToString(); 
            if(string.Compare(TextBox1.Text,TextBox2.Text)==0)
            {
                string new_pass = TextBox1.Text;
                string confirm_pass = TextBox2.Text;
                string Remember = "Remembers";
                SqlConnection Con = new SqlConnection("Data Source=DILIPC;Database=Dilip;Initial Catalog=Dilip;User ID=sa;Password=SQLserver!1");
                SqlCommand cmd = Con.CreateCommand();
                Con.Open();
                new_pass = PasswordHash.HashPassword(new_pass);
                cmd.CommandText = "Update [Members] SET Password = '" + new_pass + "',Password_Status = '" + Remember + "' Where Username='" + un + "';";
                SqlDataReader Row_reader;
                Row_reader = cmd.ExecuteReader();
                Con.Close();
                Page.RegisterStartupScript("UserMsg", "<script>alert('Your Password Has Been Changed Successfully...')</script>");

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

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }
    }
}