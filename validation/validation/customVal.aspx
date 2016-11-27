<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="customVal.aspx.cs" Inherits="validation.customVal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script type="text/javascript"> 
        function validateLength(oSrc, args) {

            args.IsValid = (args.Value.length >= 8);
        }

    </script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="must enter at least 8 char" ClientValidationFunction="validateLength"></asp:CustomValidator>
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 241px; top: 98px; position: absolute" Text="Button" />
    </form>
</body>
</html>
