using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    string con_s = "Data Source=Manipal;Initial Catalog= hospital;Integrated Security=true";
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
      
        SqlConnection con = new SqlConnection(con_s);
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from doctorlogin where firstname='" + TextBox1.Text + "' AND password='" + TextBox2.Text + "'", con);

        SqlDataAdapter adap = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        adap.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            Session["firstname"] = dt.Rows[0]["firstname"].ToString();
            Response.Write("Login sucess");
            Response.Redirect("Doctor.aspx");
        }
        else
        {
            Response.Write("Invalid username or password");
        }

        con.Close();

    }
     

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Forgotpassword.aspx");
    }
}