using System;
using System.Data.SqlClient;

namespace EH1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["un"].ToString();
            if (Session["Fill"] != null)
            {
                Label9.Text = "Please fill all your details";
                Session["Fill"] = null;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string un = null, pass = null, Acc_Status = "Complete";
            if (Session["un"] != null & Session["pass"] != null)
            {
                un = Session["un"].ToString();
                pass = Session["pass"].ToString();
            }




            if (string.IsNullOrEmpty(TextBox1.Text) | string.IsNullOrEmpty(TextBox2.Text) | string.IsNullOrEmpty(TextBox3.Text) | string.IsNullOrEmpty(TextBox4.Text) | string.IsNullOrEmpty(TextBox5.Text) | string.IsNullOrEmpty(TextBox6.Text))
            {
                Session["Fill"] = 1;
            }
            else
            {
                SqlConnection Con = new SqlConnection("Data Source=DILIPC;Database=Dilip;Initial Catalog=Dilip;User ID=sa;Password=SQLserver!1");
                SqlCommand cmd = Con.CreateCommand();
                SqlDataReader Row_reader;
                string User_Status2 = "New";
                Con.Open();
                cmd.CommandText = "Update [Members] SET [First Name]='" + TextBox1.Text + "',[Middle Name]='" + TextBox2.Text + "',[Last Name]='" + TextBox3.Text + "',email_ID='" + TextBox4.Text + "',Address='" + TextBox6.Text + "',Occupation='" + TextBox5.Text + "' Where Username='" + un + "';";
                Row_reader = cmd.ExecuteReader();
                Row_reader.Close();
                cmd.CommandText = "Select email_ID from [Members] Where Username = '" + un + "' ";
                Session["email_ID"] = cmd.ExecuteScalar().ToString();
                cmd.CommandText = "Select User_Status from [Members] Where Username = '" + un + "' ";
                string User_Status = cmd.ExecuteScalar().ToString();
                if(string.Compare(User_Status,"New")!=0|string.Compare(User_Status,"Old")!=0)
                {
                    cmd.CommandText = "Update [Members] SET User_Status = '"+User_Status2+"' Where Username='" + un + "';";
                    Row_reader = cmd.ExecuteReader();

                }
                Con.Close();
                Response.Redirect("Account_Updation.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }
    }
}