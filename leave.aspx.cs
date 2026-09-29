using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace p5
{
    public partial class leave : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dispDate.Text = Session["selectedDate"].ToString();
        }

        protected void drpPermission_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string profName = drpProfessors.SelectedValue;
            string applicationDate = dispDate.Text;
            string leaveReason = txtReason.Text;

            lblMessage.Text = "Leave confirmed for " + profName + " on " + applicationDate + "<br>" + "Reason: " + leaveReason;
        }
    }
}