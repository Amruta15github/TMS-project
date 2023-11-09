using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;


public partial class admin_viewtutor : System.Web.UI.Page
{
    iClass c = new iClass();
    public string pgTitle, rootPath;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            pgTitle = Request.QueryString["action"] == "new" ? "Add Tutors" : "Edit Tutors";
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

    protected void gvviewtutor_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Literal litAnch = (Literal)e.Row.FindControl("litAnch");
                litAnch.Text = "<a href=\"viewtutor.aspx?action=edit&id=" + e.Row.Cells[0].Text + "\"class=\"gAnch\" title=\"View/Edit\"></a>";

            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), " gvviewtutor_RowDataBound", ex.Message.ToString());
            return;
        }
    }

    private void FillGrid()
    {
        try
        {
            using (DataTable dtdoc = c.GetDataTable("Select *  From tutor_register Order By id DESC"))
            {
                gvviewtutor.DataSource = dtdoc;
                gvviewtutor.DataBind();

                if (dtdoc.Rows.Count > 0)
                {
                    gvviewtutor.UseAccessibleHeader = true;
                    gvviewtutor.HeaderRow.TableSection = TableRowSection.TableHeader;


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
            using (DataTable dtplac = c.GetDataTable("select * from tutor_register where id=" + placIdx))
            {
                if (dtplac.Rows.Count > 0)
                {
                    DataRow row = dtplac.Rows[0];
                    lblId.Text = placIdx.ToString();
                    txttutorname.Text = row["name"].ToString();
                    txttutorsurname.Text = row["fname"].ToString();
                    ddlgender.SelectedValue = row["gender"].ToString();
                    txtage.Text = row["age"].ToString();
                    ddlmarital.SelectedValue = row["marital_status"].ToString();
                    ddlcountry.SelectedValue = row["country"].ToString();
                    txtcity.Text = row["city"].ToString();
                    txtaddress.Text = row["address"].ToString();
                    ddlqualification.SelectedValue = row["qualification"].ToString();
                    ddlexp.SelectedValue = row["experience"].ToString();
                    txtcontact.Text = row["contactno"].ToString();
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


    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            GetAllControls(this.Controls);
            //Empty Validations
            if (txttutorname.Text == "" || txttutorsurname.Text == "" || txtage.Text == "" || txtage.Text == "" || txtcity.Text == "" || txtaddress.Text == "" || txtcontact.Text == "" || txtusername.Text == "" || txtpass.Text == "")
            {
                //ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'All * Fields are mandatory');", true);
                Response.Write("<script>alert('All * Fields are mandatory');</script>");
                return;
            }


            //Insert Update data
            int maxId = lblId.Text == "[New]" ? c.NextId("StudentPlacement", "StudPlcId") : Convert.ToInt32(lblId.Text);

            if (lblId.Text == "[New]")
            {
                c.ExecuteQuery("Insert into tutor_register (id, name, surname, gender,age,email, marital_status,country, city, address, qualification, experience, contactno, username,password) Values (" + maxId + ",  '" + txttutorname + "', '" + txttutorsurname.Text + "'," + ddlgender.SelectedItem.Text + ",'" + txtage.Text + "'," + ddlmarital.SelectedItem.Text + "," + ddlcountry.SelectedItem.Text + ",'" + txtcity.Text + "','" + txtaddress.Text + "'," + ddlqualification.SelectedItem.Text + "," + ddlexp.SelectedItem.Text + ",'" + txtcontact.Text + "','" + txtusername.Text + "','" + txtpass.Text + "')");

                Response.Write("<script>alert('Record Added ');</script>");
            }
            else
            {
                c.ExecuteQuery("Update  stud_register  set id=" + maxId + ", name = '" + txttutorname + "', fname='" + txttutorsurname.Text + "', gender=" + ddlgender.SelectedItem.Text + ", age= '" + txtage.Text + "',marital_status=" + ddlmarital.SelectedItem.Text + ", country= " + ddlcountry.SelectedItem.Text + ", city= '" + txtcity.Text + "', address='" + txtaddress.Text + "', qualification=" + ddlqualification.SelectedItem.Text + ", experience=" + ddlexp.SelectedItem.Text + ",contactno='" + txtcontact.Text + "',username='" + txtusername.Text + "',password='" + txtpass.Text + "' where id=" + maxId);

                Response.Write("<script>alert('Record Updated ');</script>");
            }

            //ScriptManager.RegisterClientScriptBlock(this, GetType(), "CallMyFunction", "waitAndMove('jobopenings-master.aspx', 2000);", true);
            Response.Redirect("viewtutor.aspx");
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "btnSave_Click", ex.Message.ToString());
            return;
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            c.ExecuteQuery("Delete tutor_register where id=" + Request.QueryString["id"]);
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Record Deleted');", true);
            // ScriptManager.RegisterClientScriptBlock(this, GetType(), "CallMyFunction", "waitAndMove('viewtutor.aspx', 2000);", true);
            Response.Redirect("viewtutor.aspx");
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
        Response.Redirect("viewtutor.aspx");
    }
}