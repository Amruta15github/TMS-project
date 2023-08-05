using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class admin_view_contact : System.Web.UI.Page
{
    iClass c = new iClass();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin_username"] == null)
        {
            Response.Redirect("admin_login.aspx");
        }

        if (!IsPostBack)
        {
            FillGrid();
        }
    }

    private void FillGrid()
    {
        try
        {
            using (DataTable dt = c.GetDataTable("Select * From contact_tbl"))
            {

                GridView1.DataSource = dt;
                GridView1.DataBind();

                if (dt.Rows.Count > 0)
                {
                    GridView1.UseAccessibleHeader = true;
                    GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;
                }
            }

        }
        catch (Exception ex)
        {
            //ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            //c.ErrorLogHandler(this.ToString(), "FillGrid", ex.Message.ToString());
            //return;
        }
    }



    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int id = Convert.ToInt32(e.CommandArgument);

        GridViewRow gRow = (GridViewRow)((Button)e.CommandSource).NamingContainer;

        if (e.CommandName == "itemdelete")
        {
               
            c.ExecuteQuery("delete contact_tbl where id=" + gRow.Cells[0].Text);
            //ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'record Deleted');", true);
            Response.Write("<script>alert('record Deleted');</script>");
            FillGrid();

        }
    }
}
