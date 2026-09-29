<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="p5.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <h1>Select Date For Leave Application</h1>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Calendar ID="calleave" 
                            runat="server"
                            OnSelectionChanged="calleave_SelectionChanged"></asp:Calendar>
                    </td>
                </tr>
                <tr>
                    <td>
                        <br />
                        <asp:Label ID="dispDate" runat="server" Text=""></asp:Label>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnSubmit" runat="server" Text="Save & Next" OnClick="btnSubmit_Click" />
                    </td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>
