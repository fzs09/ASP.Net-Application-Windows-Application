<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>DisplayValue</title>
</head>
<body>
    <div>
        This is our first mvc applications...<br />
        The current time is <%=ViewData["CurrentTime"] %>
    </div>
</body>
</html>
