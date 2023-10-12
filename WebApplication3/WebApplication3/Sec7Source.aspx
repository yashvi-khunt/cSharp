<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sec7Source.aspx.cs" Inherits="WebApplication3.Sec7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtDemo" runat="server">TextBox</asp:TextBox>
            <br />
            <br />
            HyperLink : <a href="Sec7Target.aspx">Sec7Target.aspx</a><br />
            <br />
            <br />
            <a href="Sec7Target.aspx">
                <asp:Button ID="btnRedirect" runat="server" OnClick="btnRedirect_Click" Text="Response.Redirect" />
            </a>
            <br />
            <br />
            <a href="Sec7Target.aspx">
                <asp:Button ID="btnTransfer" runat="server" Text="Server.Transfer" OnClick="btnTransfer_Click" />
            </a>
            <br />
            <br />
            <a href="Sec7Target.aspx">
                <asp:Button ID="btnCrossPagePostBack" runat="server" Text="CrossPagePostBack" PostBackUrl="~/Sec7Target.aspx" />
            </a>
        </div>
    </form>
</body>
</html>
