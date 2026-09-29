<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="leave.aspx.cs" Inherits="p5.leave" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Professor Leave Request</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <table>
            <tr>
                <td colspan="2">
                    <h1>Professor Leave Application</h1>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Professor Name: "></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="drpProfessors" runat="server">
                        <asp:ListItem Text="-- Select Professor --" Value=""></asp:ListItem>
                        <asp:ListItem Text="Prof.Viraj Daxini" Value="Prof.Viraj Daxini"></asp:ListItem>
                        <asp:ListItem Text="Prof.Priyanka Mangi" Value="Prof.Priyanka Mangi"></asp:ListItem>
                        <asp:ListItem Text="Prof.Pranav Tank" Value="Prof.Pranav Tank"></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Selected Leave Date:"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="dispDate" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Reason for Leave:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtReason" runat="server" TextMode="MultiLine" Columns="20" Rows="5"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="padding-top:10px;">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit Application" OnClick="btnSubmit_Click" />
                </td>
            </tr>
           </table>
            <hr />
             <asp:Label ID="Label4" runat="server" Text="" ForeColor="Green"></asp:Label>
        </div>
    </form>
</body>
</html>

           </table>
             <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Green"></asp:Label>
        </div>
    </form>
</body>
</html>
