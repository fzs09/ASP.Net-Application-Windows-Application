<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="loginRegister.login" %>

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
            <td> User Name</td>
            <td> <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Password</td>
            <td> <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr>
            <td> <asp:Button ID="btnLogin" runat="server" Text="Login" style="z-index: 1; left: 167px; top: 70px; position: absolute" OnClick="btnLogin_Click"></asp:Button></td>
        </tr>
    </table>
    </div>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName" ErrorMessage="please provide user name" style="z-index: 1; left: 240px; top: 15px; position: absolute"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="please provide password" style="z-index: 1; left: 242px; top: 43px; position: absolute"></asp:RequiredFieldValidator>
        <asp:Button ID="btnSignup" runat="server" CausesValidation="False" OnClick="btnSignup_Click1" style="z-index: 1; left: 153px; top: 112px; position: absolute; width: 62px" Text="Sign Up" />
    </form>
</body>
</html>
