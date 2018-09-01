using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Linq;
using System.Data;
using System.Configuration;
using System.Windows;

public partial class Patientlogin2 : System.Web.UI.Page
{
    string con_s = "Data Source=Manipal;Initial Catalog =hospital;Integrated Security =true";

    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Text = Request.QueryString["Patient Name"];
        TextBox5.Text = Request.QueryString["UID"];
        TextBox2.Text = Request.QueryString["Doctor name"];
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string sql = "update signup set apdate='" + TextBox3.Text + "' where uid='"+TextBox5.Text+"'";
        SqlConnection con = new SqlConnection(con_s);
        SqlCommand cmd = new SqlCommand(sql, con);
        con.Open();
       
        cmd.Parameters.AddWithValue("@apdate", TextBox3.Text);

        int g = cmd.ExecuteNonQuery();
        con.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("1.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Editdetails.aspx");

    }
}