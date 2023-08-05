using System;
using System.Data;
using System.Web.UI.WebControls;

public partial class student_view_tutors : System.Web.UI.Page
{
    iClass c = new iClass();
    // string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["student_username"] == null)
        {
            Response.Redirect("~/stud_login.aspx");
        }

        if (!IsPostBack)
        {
            FillGrid();
        }
    }

    private void FillGrid()
    {

        using (DataTable dt = c.GetDataTable("Select * From tutor_register"))
        {

            GridView1.DataSource = dt;
            GridView1.DataBind();

            if (dt.Rows.Count > 0)
            {
                GridView1.UseAccessibleHeader = true;
                GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
        }

        //void bindrepeater()
        //{
        //    SqlConnection con = new SqlConnection(cs);
        //    string query = "select * from tutor_register";
        //    SqlDataAdapter da = new SqlDataAdapter(query, con);
        //    DataTable data = new DataTable();
        //    da.Fill(data);
        //    Repeater1.DataSource = data;
        //    Repeater1.DataBind();

        //}
    }

    protected void btnsearch_ServerClick(object sender, EventArgs e)
    {
        using (DataTable dt = c.GetDataTable("Select * From tutor_register where ([name] like ('%" + txtsearch.Text + "%') or [gender] like ('%" + txtsearch.Text + "%') or [country] like ('%" + txtsearch.Text + "%') or [city] like ('%" + txtsearch.Text + "%') or [qualification] like ('%" + txtsearch.Text + "%') or [experience] like ('%" + txtsearch.Text + "%'))"))

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