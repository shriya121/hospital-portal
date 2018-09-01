using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows;

public partial class _Default : System.Web.UI.Page
{
    string con_s = "Data Source=Manipal;Initial Catalog =hospital;Integrated Security =true";

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        SqlConnection don = new SqlConnection(con_s);
        {
            SqlCommand amd = new SqlCommand("select * from doctorlogin where firstname='" + TextBox1.Text + "'", don);
            
            SqlDataAdapter adap = new SqlDataAdapter(amd);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Label1.Text = dt.Rows[0]["password"].ToString();
            }
            
        }
       
        Label3.Visible = true;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Doctorlogin.aspx");
    }
}