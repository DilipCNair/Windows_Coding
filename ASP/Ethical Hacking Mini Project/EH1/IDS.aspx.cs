using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace EH1
{
    public partial class Intrusion_Detection_System : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public int IDS(string username, string password)
        {
            var xss = new Regex("<script>.*</script>");
            var sqli = new Regex(".*';.*--");
            var xss2 = new Regex("<IMG SRC=JaVaScRiPt:alert('XSS')>");

            int i = 1;
            string SQL = "SQL Injection";
            string message = "An SQL Injection Attack has been successfully stoped ";
            if (xss.IsMatch(username) | xss.IsMatch(password))
            {
                
                return 1;
            }
            else if (sqli.IsMatch(username) | sqli.IsMatch(password))
            {
                SqlConnection Con = new SqlConnection("Data Source=DILIPC;Database=Dilip;Initial Catalog=Dilip;User ID=sa;Password=SQLserver!1");
                SqlCommand cmd = new SqlCommand("Insert into [IDS] (Serial_No,Attack_Type,Message) values('" + i + "','" + SQL + "', '" + message + "');", Con);
                SqlDataReader Row_reader;
                Con.Open();
                Row_reader = cmd.ExecuteReader();
                Con.Close();
                return 1;
            }
            else
                return 0;

        }
    }
}