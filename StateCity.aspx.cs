using System;
using System.Data;
using System.Data.SqlClient;

public partial class StateCity : System.Web.UI.Page
{
    SqlConnection conn;
    SqlCommand cmd;
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        conn = new SqlConnection("server=APEX-PC; integrated security=true; initial catalog=food;");
        conn.Open();
        if (Page.IsPostBack == false)
        {
            cmd = new SqlCommand("select *from StateMaster", conn);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {

                DropDownList1.DataSource = dr;

                DropDownList1.DataTextField = "StateName";
                DropDownList1.DataValueField = "StateID";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, "Select");


            }
            
        
       }
        conn.Close();
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        conn.Open();
        cmd = new SqlCommand("select *from CityMaster where StateID="+DropDownList1.SelectedItem.Value+"", conn);
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {

            DropDownList2.DataSource = dr;

            DropDownList2.DataTextField = "CityName";
            DropDownList2.DataBind();
            DropDownList2.Items.Insert(0, "Select");
   
        }
        conn.Close();
    }
}