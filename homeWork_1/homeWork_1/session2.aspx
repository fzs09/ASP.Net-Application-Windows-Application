<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="session2.aspx.cs" Inherits="homeWork_1.session2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 11px; top: 34px; position: absolute" Text="Address"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 135px; top: 34px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtContact" runat="server" style="z-index: 1; left: 136px; top: 119px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 206px; top: 180px; position: absolute" Text="Add" OnClick="btnAdd_Click" />
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 10px; top: 123px; position: absolute" Text="Contact"></asp:Label>
    </form>
</body>
</html>
