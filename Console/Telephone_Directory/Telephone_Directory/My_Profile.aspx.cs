using System;
using System.Data.SqlClient;

namespace Telephone_Directory
{
    public partial class My_Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {         
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection("Data Source=DILIPC;Database=Dilip;Initial Catalog=Dilip;User ID=sa;Password=SQLserver!1");
            SqlCommand cmd = Con.CreateCommand();
            Con.Open();

            //SQL Injection Attack
            //cmd.CommandText = "Select * from Telephone where Username = '" + TextBox1.Text + "'";   

            //SQL Injection Prevention
            cmd.CommandText = "Select * from Telephone where Username = @NAME";
            cmd.Parameters.Add(new SqlParameter("@NAME", TextBox1.Text));
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read() != true)
            {
                rdr.Close();
                Label1.Text = "Invalid User";
                goto end;

            }

            rdr.Close();
            cmd.CommandText = "Select * from Telephone where Username = @NAME1";
            cmd.Parameters.Add(new SqlParameter("@NAME1", TextBox1.Text));
            rdr = cmd.ExecuteReader();            
            GridView1.DataSource = rdr;
            GridView1.DataBind();
            end:
            ;
        }
    }
}