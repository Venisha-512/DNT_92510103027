using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace practical5
{
    public partial class leavapplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //to check wheather the employee name is in cookie
                if (Request.Cookies["empname"] != null)
                {
                    texttemp.Text = Request.Cookies["empname"].Value;
                }

                if (Session["leaveDate"] != null) 
                {
                    DateTime lvdate = (DateTime)Session["leaveDate"];
                    leavedate.Text = lvdate.ToString("dd-MM-yyyy");
                }
                else 
                {
                    leavedate.Text = "Date Not selected ....";
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string empnm = texttemp.Text;
            string leacetype = DropDownList1.SelectedValue;
            string reason = TextBox2.Text;

            Session["empname"] = empnm;
            Session["leaceType"] = leacetype;
            Session["Reason"] = reason;

            if (CheckBox1.Checked) {
                Response.Cookies["empname"].Expires = DateTime.Now.AddDays(8);
            }
            Label2.Text = "<b> Eeave applied </b> </br></br>" + empnm + " now you can take leave";  
        }
    }
}
