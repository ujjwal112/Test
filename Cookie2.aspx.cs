using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cookie2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["Detail"] != null)
        {
            TextBox2.Text = Request.Cookies["Detail"]["N"];
            TextBox3.Text = Request.Cookies["Detail"]["M"];
        }
        else 
        {
            Response.Redirect("Cookie1.aspx");
        }
        }
}