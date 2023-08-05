using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class stud_register : System.Web.UI.Page
{
    iClass c = new iClass();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    void Resetcontrols()
    {
        txtname.Text = "";
        txtfathername.Text = "";
        txtsurname.Text = "";
        ddlgender.ClearSelection();
        txtage.Text = "";
        ddlcountry.ClearSelection();
        txtcity.Text = "";
        txtaddress.Text = "";
        txtstandard.Text = "";
        ddlgoingto.ClearSelection();
        txtsubject.Text = "";
        txtcontact.Text = "";
        ddltutiontype.ClearSelection();
        ddltutorperfer.ClearSelection();
        txtusername.Text = "";
        txtpassword.Text = "";
        txtconfirmpassword.Text = "";
    }

    protected void btnregister_Click(object sender, EventArgs e)
    {
        
            c.ExecuteQuery("Insert into stud_register(name, fname, surname, gender, age, country, city , address, standard, goingto, subject,contactno, tutiontype,tutorperfer,username,password)Values( '" + txtname.Text + "','" + txtfathername.Text + "', '" + txtsurname.Text + "', '" + ddlgender.SelectedItem.Text + "', '" + txtage.Text + "','" + ddlcountry.SelectedItem.Text + "', '" + txtcity.Text + "','" + txtaddress.Text + "','" + txtstandard.Text + "','" + ddlgoingto.SelectedItem.Text + "','" + txtsubject.Text + "','" + txtcontact.Text + "','" + ddltutiontype.SelectedItem.Text + "','" + ddltutorperfer.SelectedItem.Text + "','" + txtusername.Text + "','" + txtpassword.Text + "')");
            Response.Write("<script>alert('Record Inserted successful!!');</script>");
            Resetcontrols();
        
    }
}