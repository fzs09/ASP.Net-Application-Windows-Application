<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="validation.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 30px; top: 304px; position: absolute" Text="Email"></asp:Label>
    
    </div>
        <asp:DropDownList ID="DropDownList1" runat="server" style="height: 22px; z-index: 1; left: 10px; top: 34px; position: absolute">
            <asp:ListItem Value="-1">select one</asp:ListItem>
            <asp:ListItem>bangladesh</asp:ListItem>
            <asp:ListItem>india</asp:ListItem>
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="DropDownList1" ErrorMessage="select the country " InitialValue="-1" style="z-index: 1; left: 143px; top: 34px; position: absolute"></asp:RequiredFieldValidator>
        <asp:TextBox ID="txtAge" runat="server" style="z-index: 1; left: 138px; top: 94px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 34px; top: 96px; position: absolute" Text="Age"></asp:Label>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtAge" ErrorMessage="age can not be less than 18" Operator="GreaterThan" style="z-index: 1; left: 313px; top: 91px; position: absolute" ValueToCompare="18"></asp:CompareValidator>
        <asp:TextBox ID="txtCurrency" runat="server" style="z-index: 1; left: 138px; top: 150px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 30px; top: 151px; position: absolute" Text="Currency"></asp:Label>
        <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="txtCurrency" ErrorMessage="invalid" Operator="DataTypeCheck" style="z-index: 1; left: 348px; top: 137px; position: absolute" Type="Currency"></asp:CompareValidator>
        <asp:TextBox ID="txtDate" runat="server" style="z-index: 1; left: 137px; top: 205px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 37px; top: 208px; position: absolute" Text="Date"></asp:Label>
        <asp:CompareValidator ID="CompareValidator3" runat="server" ControlToValidate="txtDate" ErrorMessage="invalid date format" Operator="DataTypeCheck" style="z-index: 1; left: 306px; top: 203px; position: absolute"></asp:CompareValidator>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 30px; top: 249px; position: absolute" Text="Date of grad"></asp:Label>
        <asp:TextBox ID="txtDateOfGrad" runat="server" style="z-index: 1; left: 136px; top: 239px; position: absolute; height: 22px; right: 1023px;"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator4" runat="server" ControlToValidate="txtDateOfGrad" ErrorMessage="invalid information" Operator="LessThanEqual" style="z-index: 1; left: 308px; top: 241px; position: absolute; height: 19px" Type="Date"></asp:CompareValidator>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 136px; top: 304px; position: absolute"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="supports strings only" style="z-index: 1; left: 330px; top: 302px; position: absolute" ValidationExpression="[a-z,A-Z]*"></asp:RegularExpressionValidator>
        <asp:TextBox ID="txtSalary" runat="server" style="z-index: 1; left: 141px; top: 354px; position: absolute"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtSalary" ErrorMessage="salary shpuld be between 1000 to 5000" MaximumValue="5000" MinimumValue="1000" style="z-index: 1; left: 340px; top: 352px; position: absolute" Type="Integer"></asp:RangeValidator>
        <asp:TextBox ID="txtPass" runat="server"  style="z-index: 1; left: 140px; top: 404px; position: absolute"></asp:TextBox>
        <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtPass" ErrorMessage="password length is more or less than required" OnServerValidate="CustomValidator1_ServerValidate" style="z-index: 1; left: 340px; top: 404px; position: absolute"></asp:CustomValidator>
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 10px; top: 454px; position: absolute" Text="Button" />
       
        <p>
            &nbsp;</p>
        <asp:TextBox ID="txtcpass" runat="server" style="position: relative; top: 340px; left: 143px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            <asp:CustomValidator ID="CustomValidator2" runat="server" ErrorMessage="CustomValidator" OnServerValidate="CustomValidator2_ServerValidate" style="position: relative"></asp:CustomValidator>
        </p>
       
    </form>
</body>
</html>
