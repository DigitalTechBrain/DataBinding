using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Web.Configuration;

namespace GridFormDemo
{
    public partial class MsAccessConnection : System.Web.UI.Page
    {
        
        OleDbConnection con = new OleDbConnection(WebConfigurationManager.ConnectionStrings["access"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            Disp();
        }

        void Disp()
        {
            string str = "select * from tbl";
            OleDbDataAdapter da = new OleDbDataAdapter (str,con);
            DataSet ds = new DataSet ();
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();

        }

    }
}