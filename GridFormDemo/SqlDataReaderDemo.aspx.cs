using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace GridFormDemo
{
    public partial class SqlDataReaderDemo : System.Web.UI.Page
    {
        // SqlConnection con = new SqlConnection("server=JACK-PC;User ID=sa;Password=1234;Database = encashxrp");
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["conn"].ToString());
       // SqlConnection con = new SqlConnection(WebConfigurationManager.AppSettings["MyAppSetting"].ToString());

        protected void Page_Load(object sender, EventArgs e)
        {
            ReadData();
        }

        void ReadData()
        {
            string str = "select Ename from tbl";
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

               Label1.Text = dr["Ename"].ToString();
            }
            con.Close();
        }
    }
}