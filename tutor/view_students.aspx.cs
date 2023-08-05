using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class tutor_view_students : System.Web.UI.Page
{
    iClass c = new iClass();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["tutor_username"] == null)
        {
            Response.Redirect("~/tutor_login.aspx");
        } 

        if (!IsPostBack)
        {
            FillGrid();
        }
    }

        private void FillGrid()
        {

            using (DataTable dt = c.GetDataTable("Select * From stud_register"))
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

    protected void btnsearch_ServerClick(object sender, EventArgs e)
    {
        using (DataTable dt = c.GetDataTable("Select * From stud_register where ([name] like ('%" + txtsearch.Text + "%') or [gender] like ('%" + txtsearch.Text + "%') or [country] like ('%" + txtsearch.Text + "%') or [city] like ('%" + txtsearch.Text + "%') or [standard] like ('%" + txtsearch.Text + "%') or [subject] like ('%" + txtsearch.Text + "%') or [tutiontype] like ('%" + txtsearch.Text + "%'))"))
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
}
