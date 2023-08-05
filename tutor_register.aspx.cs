using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class tutor_register : System.Web.UI.Page
{
    iClass c = new iClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    void Resetcontrols()
    {
        txtname.Text = "";
        
        txtsurname.Text = "";
        ddlgender.ClearSelection();
        txtage.Text = "";
        txtemail.Text = "";
        ddlmaritalstatus.ClearSelection();
        ddlcountry.ClearSelection();
        txtcity.Text = "";
        txtaddress.Text = "";       
        ddlqualification.ClearSelection();
        ddlexperience.ClearSelection();
        txtcontact.Text = "";       
        txtusername.Text = "";
        txtpassword.Text = "";
        txtconfirmpassword.Text = "";
    }

    protected void btnregister_Click(object sender, EventArgs e)
    {

           c.ExecuteQuery("Insert into tutor_register(name, surname, gender, age, email ,marital_status ,country , city , address , qualification ,experience , contactno, username , password)Values( '" + txtname.Text + "', '" + txtsurname.Text + "', '" + ddlgender.SelectedItem.Text + "', '" + txtage.Text + "','"+ txtemail.Text +"','"+ ddlmaritalstatus.SelectedItem.Text + "','" + ddlcountry.SelectedItem.Text + "', '" + txtcity.Text + "','" + txtaddress.Text + "','" + ddlqualification.SelectedItem.Text + "','" + ddlexperience.SelectedItem.Text + "','" + txtcontact.Text + "','" + txtusername.Text + "','" + txtpassword.Text + "')");
           Response.Write("<script>alert('Record Inserted successful!!');</script>");
           Resetcontrols();

        }
    }

