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
    public partial class GridViewEditUpdateDelete : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["conn"].ToString());

        protected void Page_Load(object sender, EventArgs e)
        {
            disp();
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            string name = ((TextBox)GridView1.FooterRow.FindControl("TextBox4")).Text;
            string address = ((TextBox)GridView1.FooterRow.FindControl("TextBox5")).Text;
            string str = "insert into tbl values('"+name+"','"+address+"')";
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            disp();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            disp();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            disp();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
    }
}