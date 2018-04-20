using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;

namespace GridFormDemo
{
    public partial class GridViewButtonTemplateEvent : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["conn"].ToString());

        protected void Page_Load(object sender, EventArgs e)
        {
            disp();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "roll")
            {
                int crow;
                crow = Convert.ToInt32(e.CommandArgument.ToString());
                string v = GridView1.Rows[crow].Cells[0].Text;
                Label1.Text = v;

            }

        }

        void disp()
        {
            string str = "select * from tbl";
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }
    }
}