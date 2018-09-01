using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

public partial class Reception : System.Web.UI.Page
{

    string con_s = "Data Source=Manipal;Initial Catalog =hospital;Integrated Security =true";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            bindgrid();
        }
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        //string sql = "select * from dummydoc1 where insertionDate='" + TextBox1.Text + "'";
    }

    protected void bindgrid()
    {
        string sql = "select * from signup";

        if (TextBox1.Text != "")
        {
            sql = sql + " where [apdate]='" + TextBox1.Text + "'";
        }

        SqlConnection con = new SqlConnection(con_s);
        SqlCommand cmd = new SqlCommand(sql, con);

        SqlDataAdapter adap = new SqlDataAdapter(cmd);

        DataTable dt = new DataTable();
        adap.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        else
        {
            GridView1.EmptyDataText = "No appointments";
            GridView1.DataBind();

        }


        //string sql = "select * from dummydoc";
        //SqlConnection con = new SqlConnection(con_s);
        //SqlCommand cmd = new SqlCommand(sql, con);

        //SqlDataAdapter adap = new SqlDataAdapter(cmd);

        //DataTable dt = new DataTable();
        //adap.Fill(dt);
        //if (dt.Rows.Count > 0)
        //{
        //    GridView1.DataSource = dt;
        //    GridView1.DataBind();
        //}
    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        bindgrid();
        //string sql = "select * from dummydoc where insertionDate='" + TextBox1.Text + "'";
        //SqlConnection con = new SqlConnection(con_s);
        //SqlCommand cmd = new SqlCommand(sql, con);

        //SqlDataAdapter adap = new SqlDataAdapter(cmd);

        //DataTable dt = new DataTable();
        //adap.Fill(dt);
        //if (dt.Rows.Count > 0)
        //{
        //    GridView1.DataSource = dt;
        //    GridView1.DataBind();
        //}
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
         
       
   
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Patientsignup.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("ReceptionLogin.aspx");
    }
}
