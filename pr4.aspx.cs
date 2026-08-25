using System;
namespace event_registration_form
{
public partial class WebForm1 : System.Web.UI.Page
{
protected void submit_Click(object sender, EventArgs e)
{
if (Page.IsValid)
Response.Write("<script>alert('Registration Successful!');</script>");
}
}
}
