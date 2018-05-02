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
    

    public partial class ImageDispGridview : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["conn"].ToString());

        protected void Page_Load(object sender, EventArgs e)
        {
            disp();
            DispImage();
        }

        void disp()
        {
            string str = "select * from ImageDisp";
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();


        }

        void DispImage()
        {
            string str = "select Images from ImageDisp where Sno = 1";
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                Cache["Img"] = dr["Images"].ToString();
            }
            con.Close();



            ((Image)GridView1.Rows[0].FindControl("Image1")).ImageUrl = @"~\Images\" + Cache["Img"].ToString();
        }
    }
}