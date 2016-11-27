<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="standardControl.aspx.cs" Inherits="myAspProject.standardControl" %>

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
                Username:
                <asp:TextBox ID ="txtUsername" Text="Username" runat ="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Password:
                <asp:TextBox ID ="txtPassword" Text="Password" runat ="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Login:
                <asp:Button ID ="btnLogin" Text="Login" runat ="server"></asp:Button>
            </td>
        </tr>
        
    </table>
    </div>
    </form>
</body>
</html>
&nbsp;