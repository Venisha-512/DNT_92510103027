<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="event_registration_form.WebForm1" %>
<!DOCTYPE html>
<html>
<head runat="server">
<title>Event Registration</title>
<style>
body{font-family:Arial;background:#eef2f7;margin:0;padding:35px}
.box{width:620px;margin:auto;background:white;padding:28px 35px;border-radius:12px;box-shadow:0 4px 18px #bbb}
h1{text-align:center;color:#263b5a;margin-top:0}
.r{margin:13px 0}
.r>label{display:inline-block;width:125px;font-weight:bold;color:#444}
input[type=text],select,textarea{width:330px;padding:8px;border:1px solid #bbb;border-radius:5px}
textarea{height:70px;vertical-align:top}
.btn{margin-left:125px;margin-top:15px;padding:9px
25px;background:#263b5a;color:white;border:0;border-radius:5px}
.error{color:red;font-size:13px;margin-left:130px}
</style>
</head>
<body>
<form id="form1" runat="server">
<div class="box">
<h1>Event Registration</h1>
<div class="r"><label>Full Name</label>
<asp:TextBox ID="name" runat="server"/>
<asp:RequiredFieldValidator ID="v1" runat="server" ControlToValidate="name" ErrorMessage="Required" CssClass="error"/>
</div>
<div class="r"><label>Email</label>
<asp:TextBox ID="email" runat="server"/>
<asp:RequiredFieldValidator ID="v2" runat="server" ControlToValidate="email" ErrorMessage="Required" CssClass="error"/>
</div>
<div class="r"><label>Contact No.</label>
<asp:TextBox ID="contact" runat="server"/>
<asp:RequiredFieldValidator ID="v3" runat="server" ControlToValidate="contact" ErrorMessage="Required" CssClass="error"/>
</div>
<div class="r"><label>College</label>
<asp:TextBox ID="college" runat="server"/>
<asp:RequiredFieldValidator ID="v4" runat="server" ControlToValidate="college" ErrorMessage="Required" CssClass="error"/>
</div>
<div class="r"><label>Department</label>
<asp:RadioButtonList ID="dept" runat="server">
<asp:ListItem>Computer</asp:ListItem>
<asp:ListItem>Mechanical</asp:ListItem>
<asp:ListItem>Chemical</asp:ListItem>
<asp:ListItem>Civil</asp:ListItem>
</asp:RadioButtonList>
<asp:RequiredFieldValidator ID="v5" runat="server" ControlToValidate="dept" ErrorMessage="Required" CssClass="error"/>
</div>
<div class="r"><label>Event</label>
<asp:DropDownList ID="event" runat="server">
<asp:ListItem Value="">Select Event</asp:ListItem>
<asp:ListItem>Hackathon</asp:ListItem>
<asp:ListItem>Quiz Competition</asp:ListItem>
<asp:ListItem>Sports Meet</asp:ListItem>
</asp:DropDownList>
<asp:RequiredFieldValidator ID="v6" runat="server" ControlToValidate="event" InitialValue="" ErrorMessage="Required" CssClass="error"/>
</div>
<div class="r"><label>Gender</label>
<asp:RadioButton ID="male" runat="server" GroupName="g" Text="Male"/>
<asp:RadioButton ID="female" runat="server" GroupName="g" Text="Female"/>
</div>
<div class="r"><label>Skills</label>
<asp:CheckBox ID="cs" runat="server" Text="C#"/>
<asp:CheckBox ID="py" runat="server" Text="Python"/>
<asp:CheckBox ID="ai" runat="server" Text="AI"/>
</div>
<div class="r"><label>Address</label>
<asp:TextBox ID="address" runat="server" TextMode="MultiLine"/>
<asp:RequiredFieldValidator ID="v7" runat="server" ControlToValidate="address" ErrorMessage="Required" CssClass="error"/>
</div>
<div class="r">
<asp:CheckBox ID="terms" runat="server" Text=" I accept Terms & Conditions"/>
</div>
<asp:Button ID="submit" runat="server" Text="Register Now" CssClass="btn" OnClick="submit_Click"/>
</div>
</form>
</body>
</html>


