<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="validation.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            z-index: 1;
            left: 0px;
            top: 0px;
            position: absolute;
            height: 38px;
            width: 995px;
        }
    </style>
</head>
<body style="z-index: 1; left: 0px; top: 0px; position: absolute; height: 19px; width: 995px">
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 134px; top: 19px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 134px; top: 102px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 12px; top: 19px; position: absolute" Text="user name"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 13px; top: 108px; position: absolute" Text="password"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 201px; top: 176px; position: absolute" Text="Login" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName" ErrorMessage="please enter user name" style="z-index: 1; left: 367px; top: 19px; position: absolute"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="please enter the password" style="z-index: 1; left: 365px; top: 100px; position: absolute"></asp:RequiredFieldValidator>
        <asp:TextBox ID="txtConfirmPass" runat="server" style="z-index: 1; left: 132px; top: 145px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 13px; top: 145px; position: absolute; right: 904px" Text="confirm pass"></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtConfirmPass" ErrorMessage="please enter confirm pass" style="z-index: 1; left: 368px; top: 143px; position: absolute; right: 475px"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPass" ErrorMessage="password mismatch" style="z-index: 1; left: 554px; top: 142px; position: absolute"></asp:CompareValidator>
    </form>
</body>
</html>
