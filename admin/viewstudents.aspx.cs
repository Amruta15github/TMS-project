using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;


public partial class admin_viewstudents : System.Web.UI.Page
{
    iClass c = new iClass();
    public string pgTitle, rootPath;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            pgTitle = Request.QueryString["action"] == "new" ? "Add students" : "Edit students";
            btnSave.Attributes.Add("onclick", " this.disabled = true; this.value='Processing...'; " + ClientScript.GetPostBackEventReference(btnSave, null) + ";");
            btnDelete.Attributes.Add("onclick", " this.disabled = true; this.value='Processing...'; " + ClientScript.GetPostBackEventReference(btnDelete, null) + ";");
            btnCancel.Attributes.Add("onclick", " this.disabled = true; this.value='Processing...'; " + ClientScript.GetPostBackEventReference(btnCancel, null) + ";");

            if (!IsPostBack)
            {
                if (Request.QueryString["action"] != null)
                {
                    editinfo.Visible = true;
                    viewinfo.Visible = false;

                    if (Request.QueryString["action"] == "new")
                    {
                        btnSave.Text = "Save Info";
                        btnDelete.Visible = false;
                       
                    }
                    else
                    {
                        btnSave.Text = "Modify Info";
                        btnDelete.Visible = true;
                        GetData(Convert.ToInt32(Request.QueryString["id"]));
                    }
                }
                else
                {
                    editinfo.Visible = false;
                    viewinfo.Visible = true;
                    FillGrid();
                }
            }
            lblId.Visible = false;
        }

        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "Page_Load", ex.Message.ToString());
            return;
        }
    }

    private void FillGrid()
    {
        try
        {
            using (DataTable dtdoc = c.GetDataTable("Select *  From stud_register Order By id DESC"))
            {
                gvviewstud.DataSource = dtdoc;
                gvviewstud.DataBind();

                if (dtdoc.Rows.Count > 0)
                {
                    gvviewstud.UseAccessibleHeader = true;
                    gvviewstud.HeaderRow.TableSection = TableRowSection.TableHeader;


                }
            }

        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "FillGrid", ex.Message.ToString());
            return;
        }
    }

    public void GetAllControls(ControlCollection ctrs)
    {
        foreach (Control c in ctrs)
        {
            if (c is System.Web.UI.WebControls.TextBox)
            {
                TextBox tt = c as TextBox;
                tt.Text = tt.Text.Trim().Replace("'", "");
            }
            if (c.HasControls())
            {
                GetAllControls(c.Controls);
            }
        }
    }

    public void GetData(int placIdx)
    {
        try
        {
            using (DataTable dtplac = c.GetDataTable("select * from stud_register where id=" + placIdx))
            {
                if (dtplac.Rows.Count > 0)
                {
                    DataRow row = dtplac.Rows[0];
                    lblId.Text = placIdx.ToString();
                    txtstudname.Text = row["name"].ToString();
                    txtstudfname.Text = row["fname"].ToString();
                    txtstudaname.Text = row["surname"].ToString();
                    ddlgender.SelectedValue = row["gender"].ToString();
                    txtage.Text = row["age"].ToString();
                    ddlcountry.SelectedValue = row["country"].ToString();
                    txtcity.Text = row["city"].ToString();
                    txtaddress.Text = row["address"].ToString();
                    txtstandard.Text = row["standard"].ToString();
                    ddlgoingto.SelectedValue = row["goingto"].ToString();
                    txtsub.Text = row["subject"].ToString();
                    txtcontact.Text = row["contactno"].ToString();
                    ddltutiontype.SelectedValue = row["tutiontype"].ToString();
                    ddltutionprefer.SelectedValue = row["tutorperfer"].ToString();
                    txtusername.Text = row["username"].ToString();
                    txtpass.Text = row["password"].ToString();
                  
                }
            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "GetData", ex.Message.ToString());
            return;
        }
    }

    protected void gvviewstud_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Literal litAnch = (Literal)e.Row.FindControl("litAnch");
                litAnch.Text = "<a href=\"viewstudents.aspx?action=edit&id=" + e.Row.Cells[0].Text + "\"class=\"gAnch\" title=\"View/Edit\"></a>";

            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), " gvviewstud_RowDataBound", ex.Message.ToString());
            return;
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            c.ExecuteQuery("Delete stud_register where id=" + Request.QueryString["id"]);
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Record Deleted');", true);
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "CallMyFunction", "waitAndMove('viewstudents.aspx', 2000);", true);
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "btnDelete_Click", ex.Message.ToString());
            return;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("viewstudents.aspx");
    }
}