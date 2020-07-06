using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cookie1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Cookies["Detail"]["N"] = TextBox1.Text;
        Response.Cookies["Detail"]["M"] = TextBox2.Text;
        Response.Cookies["Detail"].Expires = System.DateTime.Now.AddMinutes(1);
        Response.Redirect("Cookie2.aspx");
    }
}