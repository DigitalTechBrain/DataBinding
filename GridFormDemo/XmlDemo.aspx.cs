using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace GridFormDemo
{
    public partial class XmlDemo : System.Web.UI.Page
    {
        DataSet ds;
        DataColumn[] dc = new DataColumn[10];
        protected void Page_Load(object sender, EventArgs e)
        {
            ReadFromXml();
        }

        void ReadFromXml()
        {
            ds = new DataSet();
            ds.ReadXml(MapPath("~/XMLFile/XMLFile1.xml"));
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();

        }

        void InsertXml()
        {
            DataTable dt = new DataTable();
            DataRow dr = ds.Tables[0].NewRow();

                dr[0] = TextBox1.Text;
                dr[1] = TextBox2.Text;
                dr[2] = TextBox3.Text;
                ds.Tables[0].Rows.Add(dr);
                ds.WriteXml(Server.MapPath("~/XMLFile/XMLFile1.xml"));
                ReadFromXml();
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();

            }

        protected void Button1_Click(object sender, EventArgs e)
        {
            InsertXml();
            ReadFromXml();
        }
    }
}