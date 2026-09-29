using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practical5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //apply leave button
            Response.Redirect("leavapplication.aspx");

        }

        protected void Calendar1_DataBinding(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            DateTime selectdt = Calendar1.SelectedDate;

            Label1.Text = "you have selected " + selectdt.ToString("dd-MM-yyyy");

            Session["leaveDate"] = selectdt;
        }
    }
}
