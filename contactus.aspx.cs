using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class contactus : System.Web.UI.Page
{
    string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    void resetcontact()
    {
        txtname.Text = "";
        txtemail.Text = "";
        ddlsubject.ClearSelection();
        txtmessage.Text = "";
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        //string cs = System.Configuration.ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        SqlConnection con = new SqlConnection(cs);

        SqlCommand cmd = new SqlCommand("INSERT INTO contact_tbl (name, email, subject, message) VALUES('" + txtname.Text + "','" + txtemail.Text + "', '" + ddlsubject.SelectedItem.Text +"', '"+ txtmessage.Text + "')", con);
        //Response.Write("<script>alert('Record Inserted successful!!');</script>");
        ScriptManager.RegisterStartupScript(this, GetType(), "myScript", "successcontact();", true);
        resetcontact();

        con.Open();

        cmd.ExecuteNonQuery();

        con.Close();

    }
}