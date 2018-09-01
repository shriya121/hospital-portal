using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string con_s = "Data Source=Manipal;Initial Catalog= hospital;Integrated Security=true";
    string s, t, u;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bindDropDown();
            bindDropDown2();
            bindDropDown3();
            bindGrid1();
            bindGrid2();
            bindGrid3();
        }
    }


    protected void bindDropDown()
    {
        string sql = "select*from MED";

        SqlConnection con = new SqlConnection(con_s);
        SqlCommand cmd = new SqlCommand(sql, con);
        SqlDataAdapter adap = new SqlDataAdapter(cmd);


        DataTable dt = new DataTable();
        adap.Fill(dt);

        if (dt.Rows.Count > 0)
        {

            ddl.DataSource = dt;
            ddl.DataTextField = "name";
            ddl.DataValueField = "srno";
            ddl.DataBind();
        }

    }

    protected void bindDropDown2()
    {
        string sql = "select*from disease";

        SqlConnection con = new SqlConnection(con_s);
        SqlCommand cmd = new SqlCommand(sql, con);
        SqlDataAdapter adap = new SqlDataAdapter(cmd);


        DataTable dt = new DataTable();
        adap.Fill(dt);

        if (dt.Rows.Count > 0)
        {

            ddl2.DataSource = dt;
            ddl2.DataTextField = "name";
            ddl2.DataValueField = "srno";
            ddl2.DataBind();
        }

    }

    protected void bindDropDown3()
    {
        string sql = "select*from test";

        SqlConnection con = new SqlConnection(con_s);
        SqlCommand cmd = new SqlCommand(sql, con);
        SqlDataAdapter adap = new SqlDataAdapter(cmd);


        DataTable dt = new DataTable();
        adap.Fill(dt);

        if (dt.Rows.Count > 0)
        {

            ddl3.DataSource = dt;
            ddl3.DataTextField = "name";
            ddl3.DataValueField = "srno";
            ddl3.DataBind();
        }

    }

    protected void Button2_Click(object sender, EventArgs e)
    {


        string sql = "insert into patient_med(uid,medicine,symp,testp) values(@uid,@medicine,@symp,@testp)";
        SqlConnection con = new SqlConnection(con_s);
        SqlCommand cmd = new SqlCommand(sql, con);
        con.Open();

        cmd.Parameters.AddWithValue("@uid", TextBox1.Text);
        cmd.Parameters.AddWithValue("@medicine", ViewState["s"].ToString());
        cmd.Parameters.AddWithValue("@symp", ddl2.SelectedItem.Text);
        cmd.Parameters.AddWithValue("@testp", ViewState["t"].ToString());

        int g = cmd.ExecuteNonQuery();
        con.Close();
        if (g != 0)
        {
            Response.Write("<script>alert('success')</script>");

        }
        else
        {
            Response.Write("<script>alert('error')</script>");
        }
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        string sql = "insert into temp_med(uid,srno,name,status) values(@uid,@srno,@name,@status)";
        SqlConnection con = new SqlConnection(con_s);
        SqlCommand cmd = new SqlCommand(sql, con);
        con.Open();

        cmd.Parameters.AddWithValue("@uid", TextBox1.Text);
        cmd.Parameters.AddWithValue("@srno", ddl.SelectedValue);
        cmd.Parameters.AddWithValue("@name", ddl.SelectedItem.Text);
        cmd.Parameters.AddWithValue("@status", "1");

        int g = cmd.ExecuteNonQuery();
        con.Close();
        ViewState["s"] = Convert.ToString(ViewState["s"]) + ddl.SelectedItem.Text + ",";
        bindGrid2();
    }


    protected void Button4_Click(object sender, EventArgs e)
    {
        string sql = "insert into temp_test(uid,srno,name,status) values(@uid,@srno,@name,@status)";
        SqlConnection con = new SqlConnection(con_s);
        SqlCommand cmd = new SqlCommand(sql, con);
        con.Open();

        cmd.Parameters.AddWithValue("@uid", TextBox1.Text);
        cmd.Parameters.AddWithValue("@srno", ddl3.SelectedValue);
        cmd.Parameters.AddWithValue("@name", ddl3.SelectedItem.Text);
        cmd.Parameters.AddWithValue("@status", "1");

        int g = cmd.ExecuteNonQuery();

        con.Close();
        ViewState["t"] = Convert.ToString(ViewState["t"]) + ddl3.SelectedItem.Text + ",";
        bindGrid3();
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        string sql = "insert into temp_disease(uid,srno,name,status) values(@uid,@srno,@name,@status)";
        SqlConnection con = new SqlConnection(con_s);
        SqlCommand cmd = new SqlCommand(sql, con);
        con.Open();

        cmd.Parameters.AddWithValue("@uid", TextBox1.Text);
        cmd.Parameters.AddWithValue("@srno", ddl2.SelectedValue);
        cmd.Parameters.AddWithValue("@name", ddl2.SelectedItem.Text);
        cmd.Parameters.AddWithValue("@status", "1");

        int g = cmd.ExecuteNonQuery();

        con.Close();
        //ViewState["u"] = Convert.ToString(ViewState["u"]) + ddl2.SelectedItem.Text + ",";
        bindGrid1();
    }

    protected void bindGrid1()
    {
        string sql = "select*from temp_disease";
        SqlConnection con = new SqlConnection(con_s);
        SqlCommand cmd = new SqlCommand(sql, con);
        SqlDataAdapter adap = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        adap.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();

    }

    protected void bindGrid2()
    {
        string sql = "select*from temp_med";
        SqlConnection con = new SqlConnection(con_s);
        SqlCommand cmd = new SqlCommand(sql, con);
        SqlDataAdapter adap = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        adap.Fill(dt);
        GridView2.DataSource = dt;
        GridView2.DataBind();

    }

    protected void bindGrid3()
    {
        string sql = "select*from temp_test";
        SqlConnection con = new SqlConnection(con_s);
        SqlCommand cmd = new SqlCommand(sql, con);
        SqlDataAdapter adap = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        adap.Fill(dt);
        GridView3.DataSource = dt;
        GridView3.DataBind();

    }

    protected void GridView1_RowCommand1(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            int uid = int.Parse(e.CommandArgument.ToString());

            string sql = "delete from temp_disease where  uid=@uid";
            SqlConnection con = new SqlConnection(con_s);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.Parameters.AddWithValue("@uid", TextBox1.Text);
            int g = cmd.ExecuteNonQuery();
            con.Close();
            if (g == 0)
            {
                Response.Write("<script>alert('error')</script>");
            }
            else
            {
                Response.Write("<script>alert('success')</script>");
                bindGrid1();
            }
        }

    }

    protected void GridView2_RowCommand1(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            int uid = int.Parse(e.CommandArgument.ToString());

            string sql = "delete from temp_med where  uid=@uid";
            SqlConnection con = new SqlConnection(con_s);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.Parameters.AddWithValue("@uid", TextBox1.Text);
            int g = cmd.ExecuteNonQuery();
            con.Close();
            if (g == 0)
            {
                Response.Write("<script>alert('error')</script>");
            }
            else
            {
                Response.Write("<script>alert('success')</script>");
                bindGrid2();
            }
        }

    }

    protected void GridView3_RowCommand1(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            int uid = int.Parse(e.CommandArgument.ToString());

            string sql = "delete from temp_test where  uid=@uid";
            SqlConnection con = new SqlConnection(con_s);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.Parameters.AddWithValue("@uid", TextBox1.Text);
            int g = cmd.ExecuteNonQuery();
            con.Close();
            if (g == 0)
            {
                Response.Write("<script>alert('error')</script>");
            }
            else
            {
                Response.Write("<script>alert('success')</script>");
                bindGrid3();
            }
        }

    }


}