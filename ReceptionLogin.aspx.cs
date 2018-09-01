using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

public partial class ReceptionLogin : System.Web.UI.Page
{

    string con_s = "Data Source=Manipal;Initial Catalog =hospital;Integrated Security =true";

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button3_Click(object sender, EventArgs e)
    {

        SqlConnection con = new SqlConnection(con_s);
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from Receptionlogin  where Username='" + TextBox1.Text + "' AND Password='" + TextBox2.Text + "'", con);

        SqlDataAdapter adap = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        adap.Fill(dt);
        if (dt.Rows.Count > 0)
        {

            Response.Write("Login sucess");
        }
        else
        {
            Response.Write("Invalid username or password");
        }

 Response.Redirect("Reception.aspx");

        con.Close();
    }
}