using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


public partial class Editdetails : System.Web.UI.Page
{
    string con_s = "Data Source=Manipal;Initial Catalog =hospital;Integrated Security =true";

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {


        string sql = "select* from signup where uid =@uid";
        SqlConnection con = new SqlConnection(con_s);
        SqlCommand cmd = new SqlCommand(sql, con);
        con.Open();
        cmd.Parameters.AddWithValue("@uid", TextBox1.Text);



        SqlDataReader rd = cmd.ExecuteReader();

        if (rd.HasRows)
        {
            if (rd.Read())
            {
                TextBox2.Text = rd["firstname"].ToString();
                TextBox3.Text = rd["lastname"].ToString();
                TextBox4.Text = rd["dob"].ToString();
                TextBox5.Text = rd["age"].ToString();
                
                TextBox7.Text = rd["phoneno"].ToString();
                TextBox8.Text = rd["address"].ToString();
                TextBox9.Text = rd["email"].ToString();

               
                con.Close();

                Label2.Visible = true;
                TextBox2.Visible = true;
                Label3.Visible = true;
                TextBox3.Visible = true;
                Label4.Visible = true;
                TextBox4.Visible = true;
                Label5.Visible = true;
                TextBox5.Visible = true;
                Label6.Visible = true;
                DropDownList1.Visible = true;
                Label7.Visible = true;
                TextBox7.Visible = true;
                Label8.Visible = true;
                TextBox8.Visible = true;
                Label9.Visible = true;
                TextBox9.Visible = true;
                Label10.Visible = true;
                DropDownList2.Visible = true;
                Button3.Visible = true;
                DropDownList1.Enabled = false;
                DropDownList2.Enabled = false;
                
            }
        }
    }
    
    protected void Button2_Click(object sender, EventArgs e)
    {
        string sql = "update signup set firstname =@firstname , lastname=@lastname , dob=@dob , age=@age, phoneno=@phoneno, address=@address,email=@email where uid=@uid";

        SqlConnection con = new SqlConnection(con_s);
        SqlCommand cmd = new SqlCommand(sql, con);
        con.Open();
        cmd.Parameters.AddWithValue("@uid", TextBox1.Text);
        cmd.Parameters.AddWithValue("@firstname", TextBox2.Text);
        cmd.Parameters.AddWithValue("@lastname", TextBox3.Text);
        cmd.Parameters.AddWithValue("@dob", TextBox4.Text);
        cmd.Parameters.AddWithValue("@age", TextBox5.Text);
        cmd.Parameters.AddWithValue("@phoneno", TextBox7.Text);
        cmd.Parameters.AddWithValue("@address", TextBox8.Text);
        cmd.Parameters.AddWithValue("@email", TextBox9.Text);



        int g = cmd.ExecuteNonQuery();

        con.Close();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("Patientlogin.aspx");
    }
}
