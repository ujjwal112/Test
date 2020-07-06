using System;
using System.Data;
using System.Data.SqlClient;

public partial class Find : System.Web.UI.Page
{
    SqlConnection conn;
    SqlCommand cmd;
    SqlDataReader dr;
   
    protected void Page_Load(object sender, EventArgs e)
    {
        conn = new SqlConnection("server=APEX-PC; integrated security=true; initial catalog=food;");
        conn.Open();
    
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string name = TextBox1.Text + " " + TextBox2.Text;
        
        cmd = new SqlCommand("SELECT MAX(FID)+1 FROM FIND", conn);
        string Fid =Convert.ToString( cmd.ExecuteScalar());
        
        if (FileUpload1.HasFile)
        {
            if (FileUpload1.PostedFile.ContentLength < 51200000)
            {
                string extension = System.IO.Path.GetExtension(FileUpload1.FileName);
                if (extension == ".jpg" || extension == ".png" || extension == ".gif" || extension == ".pdf")
                {
                    FileUpload1.SaveAs(Server.MapPath(Fid +extension));
                    
                    String docs = "";
                    for (int i = 0; i < CheckBoxList1.Items.Count; i++)
                    {
                        if (CheckBoxList1.Items[i].Selected == true)
                        {
                            if (docs == "")
                            {
                                docs = CheckBoxList1.Items[i].ToString();
                            }
                            else
                            {
                                docs = docs + "," + CheckBoxList1.Items[i].ToString();
                            }
                        }
                    }
                    cmd = new SqlCommand("INSERT INTO FIND(NAME,GENDER,QUALIFICATION,DEPARTMENT,DOCSNAME,DOCS)VALUES('" + name + "','" + RadioButtonList1.SelectedValue + "','" + RadioButtonList2.SelectedValue + "','" + DropDownList1.SelectedValue + "','" + docs + "','" + Fid + extension + "');SELECT MAX(FID) FROM FIND", conn);
                    Label1.Text = "REGISTRATION SUCCESFULL,YOUR ID IS " + cmd.ExecuteScalar().ToString();
                    
                    conn.Close();
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    RadioButtonList1.SelectedIndex = -1;
                    RadioButtonList2.SelectedIndex = -1;
                    DropDownList1.SelectedIndex = 0;
                    CheckBoxList1.SelectedIndex = -1;
                   
                }
            }
        }
    }
}