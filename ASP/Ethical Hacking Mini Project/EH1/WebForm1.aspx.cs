using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Drawing;
using EH1;


namespace EH1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Intrusion_Detection_System obj = new Intrusion_Detection_System();
            string un, pass;
            un = TextBox1.Text;
            pass = TextBox2.Text;
            int detect = obj.IDS(un, pass);
            //if (detect == 1)
            //    Response.Redirect("IDS.aspx");
            string storedhash = null;
            string Acc_Status = null;
            bool check=false;
            Session["un"] = un;
            Session["pass"] = pass;
            SqlConnection Con= new SqlConnection("Data Source=DILIPC;Database=Dilip;Initial Catalog=Dilip;User ID=sa;Password=SQLserver!1");
            SqlCommand cmd = Con.CreateCommand();
            Con.Open();
            cmd.CommandText = "Select Password from [Members] where Username = @USER";
            cmd.Parameters.Add(new SqlParameter("@USER", un));
            SqlDataReader Row_reader;
            Row_reader = cmd.ExecuteReader();
            if (Row_reader.Read() == true)
            {
                Row_reader.Close();
                storedhash = cmd.ExecuteScalar().ToString();                        //To check whether user exists in the database or not
                check = PasswordHash.ValidatePassword(pass, storedhash);
            }
            if(check==true)
            {
                
                SqlCommand cmd2 = Con.CreateCommand();
                cmd2.CommandText = "Select Acc_Status from [Members] where Username='"+un+"'";
                Acc_Status = cmd2.ExecuteScalar().ToString();
                SqlCommand cmd3 = Con.CreateCommand();
                cmd3.CommandText = "Select Password_Status from [Members] where Username='" + un + "'";
                string Password_Status = cmd3.ExecuteScalar().ToString();
                if (String.Compare(Password_Status, "Forgot") == 0)
                    Response.Redirect("Change_Password.aspx");
            
                if (String.Compare(Acc_Status, "Complete") == 0)
                    Response.Redirect("My_Profile.aspx");
                else
                    Response.Redirect("Webform4.aspx");
            }
            else
            {

                Label1.Text = "Invalid User";

            }
            Con.Close();


        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBox1.Text))
            {
                TextBox1.BackColor = ColorTranslator.FromHtml("#FFFF99");
            }         
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBox2.Text))
            {
                
                TextBox2.BackColor = ColorTranslator.FromHtml("#FFFF99");
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
            Response.Redirect("Password_Recover.aspx");
        }

        
    }
}