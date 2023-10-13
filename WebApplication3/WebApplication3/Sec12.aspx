<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sec12.aspx.cs" Inherits="WebApplication3.Sec12" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            k1: <%=System.Configuration.ConfigurationManager.AppSettings["k1"] %>
            <br />
            k2: <%=System.Configuration.ConfigurationManager.AppSettings["k2"] %>
        </div>
        <asp:Button ID="btnexception" runat="server" OnClick="btnexception_Click" Text="Exception" />
        <br />
        <br />
        <a href="Monitor.aspx">Monitor</a>
        <br />
        <a href="Mouse.aspx">Mouse</a>
        <br />
        <a href="Keyboard.aspx">Keyboard</a>
    </form>
</body>
</html>
