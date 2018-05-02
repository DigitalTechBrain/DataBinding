using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GridFormDemo
{
    public partial class Controls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("GridViewDemo.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("GridViewEditUpdateDelete.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("GridViewButtonTemplateEvent.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("XmlDemo.aspx");
        }

       

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormViewDemo.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListViewDemo.aspx");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("MsAccessConnection.aspx");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("ImageDispGridview.aspx");
        }
    }
}