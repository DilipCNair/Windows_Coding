using System;
using System.Data.SqlClient;

namespace Telephone_Directory
{
    public partial class Signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection("Data Source=DILIPC;Database=Dilip;Initial Catalog=Dilip;User ID=sa;Password=SQLserver!1");
            SqlCommand cmd = new SqlCommand("Insert into [Telephone] (Username,Mobile_Num,Address) values('" + TextBox1.Text + "','" + TextBox2.Text + "', '" + TextBox3.Text + "');", Con);
            SqlDataReader Row_reader;
            Con.Open();
            Row_reader = cmd.ExecuteReader();
            Con.Close();
            Response.Redirect("Success.aspx");

        }
    }
}