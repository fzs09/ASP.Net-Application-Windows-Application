<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dropDownList.aspx.cs" Inherits="myAspProject.dropDownList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:DropDownList ID="ddlDay" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlMonth" runat="server">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlYear" runat="server">
        </asp:DropDownList>
        <asp:RadioButton ID="rdbMale" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" style="z-index: 1; left: 116px; top: 114px; position: absolute" Text="Male" GroupName="gender" />
        <asp:RadioButton ID="rdbFemale" runat="server" OnCheckedChanged="RadioButton2_CheckedChanged" style="z-index: 1; left: 116px; top: 166px; position: absolute" Text="Female" GroupName="gender" />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 121px; top: 229px; position: absolute" Text="Button" />
        <asp:RadioButtonList ID="rdbGender" runat="server" OnSelectedIndexChanged="rdbGender_SelectedIndexChanged" style="z-index: 1; left: 270px; top: 128px; position: absolute; height: 27px; width: 82px">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:RadioButtonList>
    </form>
</body>
</html>
