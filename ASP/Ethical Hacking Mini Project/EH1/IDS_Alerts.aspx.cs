using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace EH1
{
    public partial class IDS_Alerts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label3.Visible = true;
            Label3.Text = "No Alerts";
            Label2.Visible = true;
            SqlConnection con = new SqlConnection("Data Source=DILIPC;Database=Dilip;Initial Catalog=Dilip;User ID=sa;Password=SQLserver!1");
            SqlCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Select * from [IDS]";
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr != null)
            {
                Label3.Visible = false;
                Label2.Text = "Alerts";
                Label2.Visible = true;
                GridView1.DataSource = rdr;
                GridView1.DataBind();
                Label2.Visible = false;
                rdr.Close();
                goto last;
            }
            
            last:;

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("My_Profile.aspx");
        }
    }
}