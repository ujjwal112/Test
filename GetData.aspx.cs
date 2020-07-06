using System;
using System.Data;
using System.Data.SqlClient;

public partial class GetData : System.Web.UI.Page
{
    SqlConnection conn;
    SqlCommand cmd;
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        t2.Visible = false;
        conn = new SqlConnection("server=DESKTOP-DP78EJ4; integrated security=true; initial catalog=food;");
        conn.Open();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       

        cmd = new SqlCommand("SELECT *FROM REGI WHERE RID=" + TextBox1.Text + "", conn);
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            while (dr.Read())
            {
                TextBox2.Text = dr["NAME"].ToString();
                RadioButtonList1.SelectedValue = dr["GENDER"].ToString();
                DropDownList1.SelectedValue = dr["COURSE"].ToString();
                Label1.Text = "";
                t2.Visible = true;
               
            }
        }
        else
        {
            Label1.Text = "INVALID INPUT???";
            TextBox2.Text = "";
            DropDownList1.SelectedIndex = 0;
            RadioButtonList1.SelectedIndex = -1;
            TextBox1.Focus();
            t2.Visible = false;

        }
        conn.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        cmd = new SqlCommand("UPDATE REGI SET NAME='" + TextBox2.Text + "',GENDER='" + RadioButtonList1.SelectedValue + "',COURSE='" + DropDownList1.SelectedValue + "' WHERE RID=" + TextBox1.Text + "", conn);
        int x = cmd.ExecuteNonQuery();
        if (x > 0)
        {
            Label1.Text = "UPDATE SUCCESFULLY";
        }
        else
        {
            Label1.Text = "UPDATE UNSUCCESFULL";
        }
        conn.Close();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        cmd = new SqlCommand("DELETE FROM REGI WHERE RID=" + TextBox1.Text + "", conn);
        int x = cmd.ExecuteNonQuery();
        if (x > 0)
        {
            Label1.Text = "DELETE SUCCESFULLY";
        }
        else
        {
            Label1.Text = "DELETE UNSUCCESFULL";
        }
        conn.Close();
    }
}