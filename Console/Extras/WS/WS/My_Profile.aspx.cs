using System;
using System.Data.SqlClient;

namespace EH1
{
    public partial class My_Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string un = Session["un"].ToString();
            if (Session["un"] != null)
                Label2.Text = Session["un"].ToString();
            SqlConnection con = new SqlConnection("Data Source=DILIPC;Database=Dilip;Initial Catalog=Dilip;User ID=sa;Password=SQLserver!1");
            SqlCommand cmd = con.CreateCommand();
            SqlDataReader Row_reader;
            cmd.CommandText = "Select Acc_Type from [Members] where Username = '" + un + "'";
            con.Open();
            string Acc_Type = cmd.ExecuteScalar().ToString();
            string User_Status = "Old";
            cmd.CommandText = "Update [Members] SET User_Status='"+User_Status+"' Where Username='" + un + "';";
            Row_reader = cmd.ExecuteReader();
            con.Close();
            if (string.Compare(Acc_Type, "Admin") == 0)
            {
                LinkButton1.Text = "Click Here To View The Entire Database";
            }
            else
                LinkButton1.Text = "Click here to view your profile";
            

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string un = Session["un"].ToString();
            SqlConnection con = new SqlConnection("Data Source=DILIPC;Database=Dilip;Initial Catalog=Dilip;User ID=sa;Password=SQLserver!1");
            SqlCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Select Acc_Type from [Members] where Username = '" + un + "'";
            string Acc_Type = cmd.ExecuteScalar().ToString();
            if (string.Compare(Acc_Type, "Admin") == 0)
            {
                cmd.CommandText = "Select * from [Members]";
                SqlDataReader rdr = cmd.ExecuteReader();
                GridView1.DataSource = rdr;
                GridView1.DataBind();
            }
            else
            {
                cmd.CommandText = "Select Username, [First Name], [Last Name], [Middle Name], email_ID, Address, Occupation from [Members] where Username='"+un+"' ";
                SqlDataReader rdr = cmd.ExecuteReader();
                GridView1.DataSource = rdr;
                GridView1.DataBind();

            }
            con.Close();

        }     

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm4.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }
    }
}