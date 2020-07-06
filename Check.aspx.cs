using System;
using System.Data;
using System.Data.SqlClient;

public partial class Check : System.Web.UI.Page
{
    SqlConnection conn;
    SqlCommand cmd;
    SqlDataReader dr;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        conn = new SqlConnection("server=DESKTOP-DP78EJ4; integrated security=true; initial catalog=food;");
        conn.Open();
    
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        cmd = new SqlCommand("SELECT USERNAME FROM LOGIN WHERE USERNAME='"+TextBox1.Text+"' and PASSWORD='"+TextBox2.Text+"'", conn);
        String x =Convert.ToString( cmd.ExecuteScalar());
        if (x!="")
        {
            Label1.Text = "USERNAME AND PASSWORD ALREADY AVAILABLE!!!";            
        }
            
        else 
        {
            Label1.Text = " ";
            cmd = new SqlCommand("insert into LOGIN(USERNAME,PASSWORD,USERTYPE)values('" + TextBox1.Text + "','" + TextBox2.Text + "','ADMIN')", conn);
            cmd.ExecuteNonQuery();      
        }
        conn.Close();
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox1.Focus();
    }
}