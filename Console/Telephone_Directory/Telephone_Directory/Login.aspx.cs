using System;
using System.Data.SqlClient;

namespace Telephone_Directory
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Signup.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            SqlConnection Con = new SqlConnection("Data Source=DILIPC;Database=Dilip;Initial Catalog=Dilip;User ID=sa;Password=SQLserver!1");
            SqlCommand cmd = Con.CreateCommand();
            Con.Open();
            cmd.CommandText = "Select * from [Telephone] where Username = '" + TextBox1.Text + "' and Mobile_Num='"+TextBox2.Text+"'";
            SqlDataReader Row_reader;
            Row_reader = cmd.ExecuteReader();
            if (Row_reader.Read() == true)
            {
                Row_reader.Close();
                //cmd.CommandText = "Select Mobile_Num from [Telephone] where Mobile_Num = '" + TextBox2.Text + "'";
                //cmd.CommandText = "Select Mobile_Num from [Telephone] where Mobile_Num =@NUM";
                //cmd.Parameters.Add(new SqlParameter("@NUM", TextBox2.Text));
                //Row_reader = cmd.ExecuteReader();
                Session["Name"] = TextBox1.Text;
                Session["Number"] = TextBox2.Text;
                Response.Redirect("My_Profile.aspx");
            }
            else
                Label4.Text = "Invalid User";
            }

    }
}