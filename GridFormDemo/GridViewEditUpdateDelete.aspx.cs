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
            if (!IsPostBack)
            {
                PopulateGridview();
            }


        }

        void PopulateGridview()
        {
            DataTable dtbl = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(WebConfigurationManager.ConnectionStrings["conn"].ToString()))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM tbl", sqlCon);
                sqlDa.Fill(dtbl);
            }
            if (dtbl.Rows.Count > 0)
            {
                GridView1.DataSource = dtbl;
                GridView1.DataBind();
            }
            else
            {
                dtbl.Rows.Add(dtbl.NewRow());
                GridView1.DataSource = dtbl;
                GridView1.DataBind();
                GridView1.Rows[0].Cells.Clear();
                GridView1.Rows[0].Cells.Add(new TableCell());
                GridView1.Rows[0].Cells[0].ColumnSpan = dtbl.Columns.Count;
                GridView1.Rows[0].Cells[0].Text = "No Data Found ..!";
                GridView1.Rows[0].Cells[0].HorizontalAlign = HorizontalAlign.Center;
            }

        }

       
        protected void Button2_Click(object sender, EventArgs e)
        {
            
            string name = ((TextBox)GridView1.FooterRow.FindControl("TextBox4")).Text;
            string address = ((TextBox)GridView1.FooterRow.FindControl("TextBox5")).Text;
            string str = "insert into tbl values('"+name+"','"+address+"')";
            //string str = insert into tbl values('@name','@address'))";
            //cmd.Parameters.Add("@name",name);
            //cmd.Parameters.Add("@address",address);
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            PopulateGridview();

            Label4.Text = "Record Added Successfully...!!!";
        }

       
    

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            PopulateGridview();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            PopulateGridview();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string name = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox2")).Text;
            string address = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox3")).Text;
            string id = ((Label)GridView1.Rows[e.RowIndex].FindControl("Label1")).Text;

            string str = "UPDATE tbl SET Ename='"+name+"',Eaddress='"+address+"' WHERE Sno = '" + int.Parse(id) + "'";
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GridView1.EditIndex = -1;

            PopulateGridview();

            Label4.Text = "Record Updated Successfully...!!!";

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string name = ((Label)GridView1.Rows[e.RowIndex].FindControl("Label2")).Text;
            string address = ((Label)GridView1.Rows[e.RowIndex].FindControl("Label3")).Text;
            string str = "DELETE FROM tbl WHERE Ename = '"+name+"' and Eaddress = '"+address+"' ";
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            PopulateGridview();

            Label4.Text = "Record Deleted Successfully...!!!";
        }
    }
}