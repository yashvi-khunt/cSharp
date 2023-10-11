<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sec4_Part3ListBox.aspx.cs" Inherits="WebApplication3.Part3ListBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .container{
            display: flex;
        }

        .button-ctn{
            display: flex;
            flex-direction: column;
            justify-content: center
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <asp:ListBox ID="lstLeft" runat="server">
               <%-- <asp:ListItem value="1">One</asp:ListItem>
                <asp:ListItem value="2">Two</asp:ListItem>
                <asp:ListItem value="3">Three</asp:ListItem>
                <asp:ListItem value="4">Four</asp:ListItem>--%>
            </asp:ListBox>
            <div class="button-ctn">
                <asp:Button ID="btnMoveToRight" runat="server" Text=" &gt;&gt; " OnClick="btnMoveToRight_Click" />
                <asp:Button ID="btnMovToLeft" runat="server" Text=" &lt;&lt; " OnClick="btnMovToLeft_Click" />
            </div>
            <asp:ListBox ID="lstRight" runat="server"></asp:ListBox>
        </div>
    </form>
</body>
</html>
