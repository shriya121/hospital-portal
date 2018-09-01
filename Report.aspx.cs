using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

public partial class Report : System.Web.UI.Page
{

    string con_s = "Data Source=Manipal;Initial Catalog =hospital;Integrated Security =true";

    protected void Page_Load(object sender, EventArgs e)
    {

        Label11.Text = Session["uid"].ToString();
        SqlConnection con = new SqlConnection(con_s);
        SqlCommand cmd = new SqlCommand("prescription", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@uid", SqlDbType.NVarChar).Value = Label11.Text;
        //cmd.Parameters.Add("@firstname", SqlDbType.NVarChar).Value = TextBox1.Text;
        //cmd.Parameters.Add("@lastname", SqlDbType.NVarChar).Value = TextBox1.Text;
        //cmd.Parameters.Add("@age", SqlDbType.NVarChar).Value = TextBox1.Text;
        //cmd.Parameters.Add("@gender", SqlDbType.NVarChar).Value = TextBox1.Text;
        //cmd.Parameters.Add("@bloodgroup", SqlDbType.NVarChar).Value = TextBox1.Text;
        //cmd.Parameters.Add("@doctor", SqlDbType.NVarChar).Value = TextBox1.Text;

        SqlDataAdapter adap = new SqlDataAdapter(cmd);

        DataSet ds = new DataSet();

        adap.Fill(ds);

        DataTable dt1 = new DataTable();
        //DataTable dt2 = new DataTable();
        //DataTable dt3 = new DataTable();
        //DataTable dt4 = new DataTable();
        //DataTable dt5 = new DataTable();
        //DataTable dt6 = new DataTable();

        dt1 = ds.Tables[0];

        //dt4 = ds.Tables[0];
        //dt5 = ds.Tables[0];
        //dt6 = ds.Tables[0];
        TextBox1.Text = dt1.Rows[0]["firstname"].ToString();
        TextBox2.Text = dt1.Rows[0]["lastname"].ToString();
        TextBox3.Text = dt1.Rows[0]["age"].ToString();
        TextBox4.Text = dt1.Rows[0]["gender"].ToString();
        TextBox1.Text = dt1.Rows[0]["bloodgroup"].ToString();
        TextBox1.Text = dt1.Rows[0]["doctorassigned"].ToString();





    }
}