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
                    txtsurname.Text = row["surname"].ToString();
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
        try
        {
            GetAllControls(this.Controls);
            //Empty Validations
            if (txtstudname.Text == "" || txtstudfname.Text == "" || txtsurname.Text == "" || txtage.Text == "" || txtcity.Text == "" || txtaddress.Text == "" || txtstandard.Text =="" || txtsub.Text =="" || txtcontact.Text==""|| txtusername.Text==""|| txtpass.Text=="")
            {
                //ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'All * Fields are mandatory');", true);
                Response.Write("<script>alert('All * Fields are mandatory');</script>");
                return;
            }

           
            //Insert Update data
            int maxId = lblId.Text == "[New]" ? c.NextId("StudentPlacement", "StudPlcId") : Convert.ToInt32(lblId.Text);

            if (lblId.Text == "[New]")
            {
                c.ExecuteQuery("Insert into stud_register (id, name, fname, surname, gender, age, country, city, address, standard, goingto,subject,contactno,tutiontype,tutorperfer,username,password) Values (" + maxId + ",  '" + txtstudname + "', '" + txtstudfname.Text + "', '" + txtsurname.Text + "'," + ddlgender.SelectedItem.Text + ",'" + txtage.Text + "'," + ddlcountry.SelectedItem.Text + ",'" + txtcity.Text + "','" + txtaddress.Text + "','" + txtstandard.Text + "'," + ddlgoingto.SelectedItem.Text + ",'" + txtsub.Text + "','" + txtcontact.Text + "'," + ddltutiontype.SelectedItem.Text + "," + ddltutionprefer.SelectedItem.Text + ",'" + txtusername.Text + "','" + txtpass.Text + "')");

                Response.Write("<script>alert('Record Added ');</script>");
            }
            else
            {
                c.ExecuteQuery("Update  stud_register  set id=" + maxId + ", name = '" + txtstudname + "', fname='" + txtstudfname.Text + "', surname='" + txtsurname.Text + "', gender=" + ddlgender.SelectedItem.Text + ", age= '" + txtage.Text + "', country= " + ddlcountry.SelectedItem.Text + ", city= '" + txtcity.Text + "', address='" + txtaddress.Text + "',standard='"+ txtstandard .Text+ "',goingto=" + ddlgoingto.SelectedItem.Text + ",subject='" + txtsub.Text + "',contactno='" + txtcontact.Text + "',tutiontype=" + ddltutiontype.SelectedItem.Text + ",tutorperfer=" + ddltutionprefer.SelectedItem.Text + ",username='" + txtusername.Text + "',password='" + txtpass.Text + "' where id=" + maxId);

                Response.Write("<script>alert('Record Updated ');</script>");
            }

            //ScriptManager.RegisterClientScriptBlock(this, GetType(), "CallMyFunction", "waitAndMove('jobopenings-master.aspx', 2000);", true);
            Response.Redirect("viewstudents.aspx");
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
            c.ExecuteQuery("Delete stud_register where id=" + Request.QueryString["id"]);
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Record Deleted');", true);
            //ScriptManager.RegisterClientScriptBlock(this, GetType(), "CallMyFunction", "waitAndMove('viewstudents.aspx', 2000);", true);
            Response.Redirect("viewstudents.aspx");
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