<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="practical5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Calendar ID="Calendar1" runat="server" OnDataBinding="Calendar1_DataBinding" OnSelectionChanged="Calendar1_SelectionChanged"  ></asp:Calendar>
            <br /><br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br /><br />
            <asp:Button ID="Button1" runat="server" Text="Apply leave." OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
