using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

public partial class Doctor : System.Web.UI.Page
{
    string con_s = "Data Source=Manipal;Initial Catalog= hospital;Integrated Security=true";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            bindgrid();
        }
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        // string sql = "select * from dummydoc1 where insertionDate='" + txtdate.Text + "'";

    }



    protected void bindgrid()
    {
        string sql = @"select uid,firstname,lastname,age,gender,bloodgroup,doctorassigned,convert(nvarchar(20),dob,106)dob 
                        from signup where doctorassigned=@docName";

        if (txtdate.Text != "")
        {
            sql = sql + " and [apdate]='" + txtdate.Text + "'";
        }

        SqlConnection con = new SqlConnection(con_s);
        SqlCommand cmd = new SqlCommand(sql, con);

        cmd.Parameters.AddWithValue("@docName", Session["firstname"].ToString());

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
    }



    protected void Button2_Click(object sender, EventArgs e)
    {
        bindgrid();
        //string sql = "select * from dummydoc1 where insertionDate='" + txtdate.Text + "'";
        //string sql = "select * from dummydoc where insertionDate='" + txtdate.Text + "'";
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
        GridViewRow row = GridView1.SelectedRow;
        TextBox1.Text = row.Cells[2].Text;
        TextBox2.Text = row.Cells[3].Text;
        TextBox3.Text = row.Cells[4].Text;
        TextBox4.Text = row.Cells[5].Text;
        TextBox5.Text = row.Cells[6].Text;
        TextBox7.Text = row.Cells[1].Text;
        TextBox6.Text = row.Cells[7].Text;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Session["uid"] != null)
        {
            Session["uid"] = TextBox7.Text;
            Response.Redirect("Report.aspx");
        }


         
        //    string sql = "insert into finalpatient(id,firstname,lastname,age,sex,emailID)values(@id,@firstname,@lastname,@age,@sex,@emailID)";
        //    SqlConnection con = new SqlConnection(con_s);
        //    SqlCommand cmd = new SqlCommand(sql, con);

        //    cmd.Parameters.AddWithValue("@firstname", TextBox1.Text);
        //    cmd.Parameters.AddWithValue("@lastname", TextBox2.Text);
        //    cmd.Parameters.AddWithValue("@age", TextBox3.Text);
        //    cmd.Parameters.AddWithValue("@sex", TextBox4.Text);
        //    cmd.Parameters.AddWithValue("@emailid", TextBox5.Text);
        //    cmd.Parameters.AddWithValue("@id", TextBox6.Text);

        //    con.Open();
        //    int g = cmd.ExecuteNonQuery();
        //    con.Close();
        //    if (g != 0)
        //    {
        //        Response.Write("<script>alert('success')</script>");
        //        bindgrid();
        //    }
        //    else
        //    {
        //        Response.Write("<script>alert('error')</script>");
        //    }
        //}
    }
}