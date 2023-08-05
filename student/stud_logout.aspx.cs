﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class student_stud_logout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["student_username"] != null)
        {
            Session.Abandon(); //current session will destory
            Response.Redirect("~/stud_login.aspx");
        }
    }
}