<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sec4_Part1.aspx.cs" Inherits="WebApplication3.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Literal ID="ltrMsg" runat="server"></asp:Literal>
            <asp:TextBox runat="server" ID="txtName"></asp:TextBox>
            <asp:Button ID="btnSayHello" runat="server" Text="Button" OnClick="btnSayHello_Click" />
        </div>
    </form>
</body>
</html>
