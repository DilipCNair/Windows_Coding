using System;
using System.Text;
using System.Data.SqlClient;
using System.Security.Cryptography;


namespace EH1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                FillCapctha();
            }

            if (Session["un2"] != null & Session["pass2"] != null)
            {
                TextBox1.Text = Session["un2"].ToString();
            }

            if (Session["ct"]!=null)
            {
                Label9.Text = "Invalid Captcha Code";
                Session["ct"] = null;
                goto end;
            }
            else if (Session["check"] != null)
            {
                Label7.Text = "Passwords Don't Match - Please Re-enter Your Password ";
                Session["check"] = null;
                goto end;
            }
            else if (Session["checkbox_status"] != null)
            {
                string check = Session["checkbox_status"].ToString();
                if (string.Compare(check, "checked") != 0)
                {
                    Label2.Text = "Please accept the Terms and Conditions";
                    goto end;
                }
            }
            else if (Session["Validate"] != null)
            {
                Label2.Text = "Passwords Must Contain Atleast - 1 Upper and Lower Case Character : 1 Special Character : 1 Digit - and Minimum of 8 Characters - So please Re-enter the password";
                Session["Validate"] = null;
                goto end;
            }
            end:;
        }

        void FillCapctha()
        {
            try
            {
                Random random = new Random();
                string combination = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
                StringBuilder captcha = new StringBuilder();
                for (int i = 0; i < 6; i++)
                    captcha.Append(combination[random.Next(combination.Length)]);
                Session["captcha"] = captcha.ToString();
                imgCaptcha.ImageUrl = "GenerateCaptcha.aspx?" + DateTime.Now.Ticks.ToString();
            }
            catch
            {
                throw;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Acc_Type = "User";
            string Password_Status = "Remembers";
            int check = 0;
            string un, pass, repass, captcha;
            int flag = 0;
            un = TextBox1.Text;
            pass = TextBox2.Text;
            repass = TextBox3.Text;

            captcha = TextBox4.Text;
            check=  string.Compare(pass, repass);
            Session["un2"] = un;
            Session["pass2"] = pass;
            


            if (check != 0)                                            // Password Comparison
                Session["check"] = check;
               


            foreach (char c in pass)
            {
                if (char.IsDigit(c))
                        {
                          flag++;
                          break;
                        }
            }
            foreach(char c in pass)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    flag++;
                    break;
                }

            }
            foreach (char c in pass)
            {                                                   //Password validation
                if (char.IsUpper(c))
                {
                    flag++;
                    break;
                }

            }
            foreach (char c in pass)
            {
                if (char.IsLower(c))
                {
                    flag++;
                    break;
                }

            }
            if (pass.Length >= 8)
                flag++;


            if (Session["captcha"].ToString() == TextBox4.Text)                                        //Captcha Validation
                flag++;
            else
                Session["ct"] = 1;

            FillCapctha();
            Session["checkbox_status"] = 0;

            if (CheckBox1.Checked)
            {
                flag++;
                Session["checkbox_status"] = "checked";
            }
            pass=PasswordHash.HashPassword(pass);
            if (flag == 7)
            {
                SqlConnection Con = new SqlConnection("Data Source=DILIPC;Database=Dilip;Initial Catalog=Dilip;User ID=sa;Password=SQLserver!1");
                SqlCommand cmd = new SqlCommand("Insert into [Members] (Username,Password,ACC_Type,Password_Status) values('" + un + "','" + pass + "', '" + Acc_Type + "', '" + Password_Status + "');", Con);
                SqlDataReader Row_reader;
                Con.Open();
                Row_reader = cmd.ExecuteReader();
                Con.Close();
                Response.Redirect("WebForm3.aspx");
            }
            else
            {
                Session["Validate"] = 1;
                Response.Redirect("WebForm2.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["ct"] = null;
            FillCapctha();
            
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
    }
}