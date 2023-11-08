using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_changrpassword : System.Web.UI.Page
{
    iClass c = new iClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        btnSubmit.Attributes.Add("onclick", " this.disabled = true; this.value='Processing...'; " + ClientScript.GetPostBackEventReference(btnSubmit, null) + ";");
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        txtConfirm.Text = txtConfirm.Text.Trim().Replace("'", "");
        txtNew.Text = txtNew.Text.Trim().Replace("'", "");
        txtOld.Text = txtOld.Text.Trim().Replace("'", "");

        if (txtOld.Text == "" || txtNew.Text == "" || txtConfirm.Text == "")
        {
            //ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Enter Old and New password');", true);
            Response.Write("<script>alert('Enter Old and New password');</script>");
            return;
        }
        if (txtOld.Text == txtNew.Text)
        {
            //ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', ' Old password and New passwords cannot be same');", true);
            Response.Write("<script>alert('Old password and New passwords cannot be same');</script>");
            return;
        }

        try
        {
            if (txtOld.Text == c.GetReqData("admin_login", "password", "id=1").ToString())
            {
                if (txtNew.Text.Length < 6)
                {
                    //ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', ' Password shoould be at least 6 characters long');", true);
                    Response.Write("<script>alert('Password shoould be at least 6 characters long');</script>");
                    return;
                }
                else
                {
                    if (txtNew.Text == txtConfirm.Text)
                    {
                        c.ExecuteQuery("Update admin_login set password='" + txtNew.Text + "' Where id=1");

                        //ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Password successfully changed');", true);
                        Response.Write("<script>alert('Password successfully changed');</script>");
                    }
                    else
                    {
                        //ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', ' New password confirmation failed');", true);
                        Response.Write("<script>alert('New password confirmation failed');</script>");
                        return;
                    }
                    txtNew.Text = txtOld.Text = txtConfirm.Text = "";
                }
            }
            else
            {
                //ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', ' Old password did not match');", true);
                Response.Write("<script>alert('Old password did not match');</script>");
                return;
            }
        }
        catch (Exception ex)
        {
            //ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            Response.Write("<script>alert('Error Occoured While Processing');</script>");
            c.ErrorLogHandler(this.ToString(), "btnSubmit_Click", ex.Message.ToString());
            return;
        }
    }
}

