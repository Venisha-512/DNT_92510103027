<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="leavapplication.aspx.cs" Inherits="practical5.leavapplication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Leave Application
            <br />
            <br />
            Employee Name :
            <asp:TextBox ID="texttemp" runat="server"></asp:TextBox>
            <br />
            <br />
            Leave Dare : <asp:Label ID="leavedate" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            Leave Type:
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Text="Medical leave" />
                <asp:ListItem Text="Default" Selected="True" />
                <asp:ListItem>Family emergency</asp:ListItem>
                <asp:ListItem>child&#39;s PTM</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Reason:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            Remember Name :
            <asp:CheckBox ID="CheckBox1" runat="server" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
