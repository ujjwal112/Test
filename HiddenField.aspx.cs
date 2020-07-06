using System;

public partial class HiddenField : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            Label1.Text = "PRINCIPLE AMOUNT";
            ViewState["P"] = "";
            ViewState["R"] = "";
            ViewState["T"] = "";
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (ViewState["P"].ToString() == "")
        {
            ViewState["P"] = TextBox1.Text;
            TextBox1.Text = "";
            Label1.Text = "ENTER RATE OF INTREST";
        }
        else if (ViewState["P"].ToString() != "" && ViewState["R"].ToString() == "")
        {
            ViewState["R"] = TextBox1.Text;
            TextBox1.Text = "";
            Label1.Text = "ENTER TIME PERIOD";
        }
        else if (ViewState["P"].ToString() != "" && ViewState["R"].ToString() != "" && ViewState["T"].ToString() == "") 
        {
            ViewState["T"] = TextBox1.Text;
            TextBox1.Text = "";
            Label1.Text = "simple interest = ";
            TextBox1.Text = Convert.ToString(Convert.ToInt32(ViewState["T"].ToString()) * Convert.ToInt32(ViewState["R"].ToString()) * Convert.ToInt32(ViewState["P"].ToString()) / 100);
        }
        }
}