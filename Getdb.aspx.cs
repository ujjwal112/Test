using System;
using System.Data;
using System.Data.SqlClient;

public partial class Getdb : System.Web.UI.Page
{
    SqlConnection conn;
    SqlCommand cmd;
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        t2.Visible = false;
        conn = new SqlConnection("server=APEX-PC; integrated security=true; initial catalog=food;");
        conn.Open();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        cmd = new SqlCommand("SELECT *FROM FIND WHERE FID=" + TextBox1.Text + "", conn);
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            while (dr.Read())
            {
                String name = dr["NAME"].ToString();
                String[] name1 = name.Split(' ');
                TextBox3.Text = name1[0].ToString();
                TextBox2.Text = name1[1].ToString();
                RadioButtonList1.SelectedValue = dr["GENDER"].ToString();
                RadioButtonList2.SelectedValue = dr["QUALIFICATION"].ToString();
                DropDownList1.SelectedValue = dr["DEPARTMENT"].ToString();
                //for (int i = 0; i < CheckBoxList1.Items.Count; i++)
                //{
                //    if (CheckBoxList1.Items[i].Selected == true)
                //    {
                //        CheckBoxList1.SelectedValue = dr["DOCSNAME"].ToString();
                //    }
                //}
                //FileUpload1.FileName = dr["DOCS"].ToString();
                String check = dr["DOCSNAME"].ToString();
                String[] check1 = check.Split(',');
                for (int i = 0; i < CheckBoxList1.Items.Count; i++)
                {
                    for (int j = 0; j < check1.Length; j++)
                    {
                        if (CheckBoxList1.Items[i].ToString() == check1[j].ToString())
                        {
                            CheckBoxList1.Items[i].Selected = true;
                        }
                    }
                }
               // CheckBoxList1.SelectedValue = dr["DOCSNAME"].ToString();
                Image1.ImageUrl = dr["DOCS"].ToString();
                t2.Visible = true;
            }
        }
        else
        {
            Label1.Text = "INVALID INPUT???";
            TextBox2.Text = "";
            TextBox3.Text = "";
            DropDownList1.SelectedIndex = 0;
            RadioButtonList1.SelectedIndex = -1;
            RadioButtonList2.SelectedIndex = -1;
            CheckBoxList1.SelectedIndex = -1;
            TextBox1.Focus();
            t2.Visible = false;

        }
        conn.Close();
    }
}