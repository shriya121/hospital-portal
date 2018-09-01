using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;

public partial class Patientlogin : System.Web.UI.Page
{
    string con_s = "Data Source=Manipal;Initial Catalog =hospital;Integrated Security =true";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {

            
            
        }
        

    }

 
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(con_s);
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from signup where firstname='" + TextBox1.Text + "' AND uid='" + TextBox2.Text + "'", con);

        SqlDataAdapter adap = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        adap.Fill(dt);


        SqlConnection don = new SqlConnection(con_s);
        {
            SqlCommand amd = new SqlCommand("select doctorassigned from signup where uid ='" + TextBox2.Text + "'", don);
            don.Open();
            SqlDataAdapter sda = new SqlDataAdapter(amd);
            DataTable at = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                TextBox3.Text = dt.Rows[0]["doctorassigned"].ToString();
            }
            don.Close();
        }

        string url;
        url = "patientlogin2.aspx?Patient name=" + TextBox1.Text + "&UID=" + TextBox2.Text + "&Doctor name=" + TextBox3.Text ;

        Response.Redirect(url);



        con.Close();
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        
    }
}