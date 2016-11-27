<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="imageCtrl.aspx.cs" Inherits="myAspProject.imageCtrl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:ImageButton ID="btnImage" runat="server" Height="202px" ImageUrl="~/Images/fashon.jpg" OnClick="ImageButton1_Click" PostBackUrl="~/standardControl.aspx" ToolTip="Click me" />
    </form>
</body>
</html>
