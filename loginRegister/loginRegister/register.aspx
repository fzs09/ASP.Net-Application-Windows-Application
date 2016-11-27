<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="loginRegister.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 107px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td class="auto-style1"> User Name</td>
            <td> <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="auto-style1">Password<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName" ErrorMessage="Please provide user name" style="z-index: 1; left: 263px; top: 15px; position: absolute; width: 192px"></asp:RequiredFieldValidator>
            </td>
            <td> <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="auto-style1">Confirm Password</td>
            <td> <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="auto-style1">Gender

            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>


                <asp:Button ID="btnSubmit" runat="server" style="z-index: 1; left: 206px; top: 303px; position: absolute" Text="Submit" OnClick="btnSubmit_Click" />


                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="please provide password" style="z-index: 1; left: 265px; top: 43px; position: absolute; width: 153px"></asp:RequiredFieldValidator>


            </td>
      
        </tr>
        <tr>
            <td class="auto-style1">Date of Birth</td>
            <td> <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="auto-style1">Email</td>
            <td> <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="auto-style1">Contact Number</td>
            <td> <asp:TextBox ID="txtContact" runat="server"></asp:TextBox></td>
        </tr>
        
    </table>
    </div>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtConfirmPassword" ErrorMessage="Please confirm the password" style="z-index: 1; left: 267px; top: 78px; position: absolute"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtDOB" ErrorMessage="Please provide Date of Birth" style="z-index: 1; left: 267px; top: 187px; position: absolute"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtEmail" ErrorMessage="please provide email" style="z-index: 1; left: 268px; top: 217px; position: absolute"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtContact" ErrorMessage="Please provide contact number" style="z-index: 1; left: 270px; top: 241px; position: absolute"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Invalid Email" style="z-index: 1; left: 424px; top: 217px; position: absolute" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="RadioButtonList1" ErrorMessage="select the gender" style="z-index: 1; left: 280px; top: 144px; position: absolute"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" ErrorMessage="password mismatch" style="z-index: 1; left: 490px; top: 78px; position: absolute"></asp:CompareValidator>
        <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtPassword" ErrorMessage="passwod should be at least 4 character" OnServerValidate="CustomValidator1_ServerValidate" style="z-index: 1; left: 490px; top: 44px; position: absolute"></asp:CustomValidator>
    </form>
</body>
</html>
