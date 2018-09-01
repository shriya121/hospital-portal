using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
 using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;


public partial class Default2 : System.Web.UI.Page
{
    string con_s = "Data Source=Manipal;Initial Catalog =hospital;Integrated Security =true";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            BindDropDown();
        }
        if (IsPostBack)
        {

            TextBox12.Text = CreateRandomPassword();
            TextBox13.Text = TextBox1.Text;
        }

    }
    public static string CreateRandomPassword()
    {
        string allowedchars = "0123456789";
        Random rand = new Random();
        char[] chars = new char[4];
        int allowedCharCount = allowedchars.Length;
        for (int i = 0; i < 4; i++)
        {
            chars[i] = allowedchars[(int)((allowedchars.Length) * rand.NextDouble())];
        }
        return new string(chars);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        string sql = "insert into signup(firstname,lastname,dob,age,bloodgroup,phoneno,address,email,gender,department,uid,doctorassigned)values(@firstname,@lastname,@dob,@age,@bloodgroup,@phoneno,@address,@email,@gender,@department,@uid,@doctorassigned)";
        SqlConnection con = new SqlConnection(con_s);
        SqlCommand cmd = new SqlCommand(sql, con);
        con.Open();
        cmd.Parameters.AddWithValue("@firstname", TextBox1.Text);
        cmd.Parameters.AddWithValue("@lastname", TextBox2.Text);
        cmd.Parameters.AddWithValue("@dob", TextBox11.Text);
        cmd.Parameters.AddWithValue("@age", TextBox4.Text);
        cmd.Parameters.AddWithValue("@bloodgroup", DropDownList2.SelectedItem.Text);
        cmd.Parameters.AddWithValue("@phoneno", TextBox6.Text);
        cmd.Parameters.AddWithValue("@address", TextBox7.Text);
        cmd.Parameters.AddWithValue("@email", TextBox8.Text);
        cmd.Parameters.AddWithValue("@gender", DropDownList4.SelectedItem.Text);
        cmd.Parameters.AddWithValue("@department", Ddl3.SelectedItem.Text);
        cmd.Parameters.AddWithValue("@uid", TextBox12.Text);
        cmd.Parameters.AddWithValue("@doctorassigned", DropDownList5.SelectedItem.Text);

        int g = cmd.ExecuteNonQuery();
        con.Close();


        Label9.Visible = true;
        TextBox12.Visible = true;
        Label10.Visible = true;
        TextBox13.Visible = true;
        Button2.Visible = true;
    }




    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Patientlogin.aspx");
    }


    protected  void Ddl3_SelectedIndexChanged(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(Ddl3.SelectedValue);
        SqlConnection con = new SqlConnection(con_s);
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from doctorlogin where id=" + id, con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        con.Close();
        DropDownList5.DataSource = ds;
        DropDownList5.DataTextField = "firstname";
        DropDownList5.DataValueField = "password";
        DropDownList5.DataBind();
        DropDownList5.Items.Insert(0, new ListItem("--Select--", "0"));
    }
    protected void BindDropDown()
    {

        string sql = "select * from docdepartment";
        SqlConnection con = new SqlConnection(con_s);
        SqlCommand cmd = new SqlCommand(sql, con);
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        con.Close();
        Ddl3.DataSource = ds;
        Ddl3.DataTextField = "department";
        Ddl3.DataValueField = "id";
        Ddl3.DataBind();
        Ddl3.Items.Insert(0, new ListItem("--Select--", "0"));
    }
}