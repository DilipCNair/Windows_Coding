using System;
using System.Net.Mail;
using System.Data.SqlClient;


namespace EH1
{
    public partial class Account_Updation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HyperLink1.Visible = false;
            string un = Session["un"].ToString();
            string email_ID = Session["email_ID"].ToString();


            SqlConnection con = new SqlConnection("Data Source=DILIPC;Database=Dilip;Initial Catalog=Dilip;User ID=sa;Password=SQLserver!1");
            SqlCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Select Acc_Status from [Members] where Username = '" + un + "'";
            string Acc_Status = cmd.ExecuteScalar().ToString();
            




            //SMTP Begins
            if (string.Compare(Acc_Status, "Complete") != 0)
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(email_ID);
                mail.From = new MailAddress("dilipof6@gmail.com", "Secure Web Application", System.Text.Encoding.UTF8);
                mail.Subject = "Congragulations";
                mail.SubjectEncoding = System.Text.Encoding.UTF8;
                mail.Body = "Welcome " + un + ", this is an auto generated email for successfull completion of your Account Registraion Process.";
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
                    Page.RegisterStartupScript("UserMsg", "<script>alert('A Mail Has Successfully Send...')</script>");
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
            SqlDataReader Row_reader;
            string Acc_Status2 = "Complete";
            cmd.CommandText = "Update [Members] SET Acc_Status = '" + Acc_Status2 + "' Where Username='" + un + "';";
            Row_reader = cmd.ExecuteReader();
            con.Close();
            HyperLink1.Visible = true;

        }

    }
}