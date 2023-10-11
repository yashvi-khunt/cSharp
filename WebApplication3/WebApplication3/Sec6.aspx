<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sec6.aspx.cs" Theme="Theme1" Inherits="WebApplication3.Part6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlTheme" runat="server" Height="16px" OnSelectedIndexChanged="ddlTheme_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem>Theme1</asp:ListItem>
                <asp:ListItem>Theme2</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="This is a label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="This is a label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="This is a label" SkinID="DiffBack" BorderStyle="Groove"></asp:Label>  <%--  by default - skin has greater precedence than inline css. To give inline css greater precedence, set StyleSheetTheme = "themename" in web.config.--%>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="This is a label" SkinID="DiffBack"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="This is a label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="This is a label" EnableTheming="False"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="This is a label" EnableTheming="False"></asp:Label>
        </div>
    </form>
</body>
</html>
