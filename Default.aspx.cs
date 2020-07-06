using System;
using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection conn;
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        conn = new SqlConnection("server=DESKTOP-DP78EJ4; integrated security=true; initial catalog=food;");
        conn.Open();
        cmd = new SqlCommand("INSERT INTO REGI(NAME,GENDER,COURSE)VALUES('" + TextBox1.Text + "','" + RadioButtonList1.SelectedValue + "','" + DropDownList1.SelectedValue + "');SELECT MAX(RID) FROM REGI", conn);
       // int x = cmd.ExecuteNonQuery();
        Label1.Text = "REGISTRATION SUCCESFULL,YOUR ID IS " + cmd.ExecuteScalar().ToString();
        conn.Close();
        //if (x > 0)
        //{
        //    Label1.Text = "REGISTRATION SUCCESFULL";
        //}
        //else
        //{
        //    Label1.Text = "REGISTRATION UNSUCCESFULL";
        //}
        //Label1.Text = "REGISTRATION SUCCESFULL";
        TextBox1.Text = "";
        RadioButtonList1.SelectedIndex = -1;
        DropDownList1.SelectedIndex = 0;
        TextBox1.Focus();
    }
}