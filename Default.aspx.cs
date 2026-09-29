using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace p5
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            String selectedDate = calleave.SelectedDate.ToString("yyyy-MM-dd");
            Session["selectedDate"] = selectedDate;
            Response.Redirect("leave.aspx");
            
        }

        protected void calleave_SelectionChanged(object sender, EventArgs e)
        {
            dispDate.Text = calleave.SelectedDate.ToString("yyyy-MM-dd");
        }
    }
}