using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class tutor_login : System.Web.UI.Page
{
    string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnlogin_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(cs);
        string query = "select * from tutor_register where username=@username and password=@password";
        SqlCommand cmd = new SqlCommand(query, con);
        cmd.Parameters.AddWithValue("@username", txtusername.Text);
        cmd.Parameters.AddWithValue("@password", txtpassword.Text);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.HasRows == true)
        {
            //Response.Write("<script>alert('Login successful!!');</script>");
            Session["tutor_username"] = txtusername.Text;
            Response.Redirect("tutor/tutor_index.aspx"); //dashboard
        }
        else
        {
            Response.Write("<script>alert('username or password is incorrect');</script>");
        }
        con.Close();



    }
}