<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sec12P2.aspx.cs" Inherits="WebApplication3.Admin.Sec12P2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Sub Directory File <br />
            k1: <%=System.Configuration.ConfigurationManager.AppSettings["k1"] %>
            <br />
            k2: <%=System.Configuration.ConfigurationManager.AppSettings["k2"] %>
            <br />
            k3: <%=System.Configuration.ConfigurationManager.AppSettings["k3"] %>
        </div>
    </form>
</body>
</html>
