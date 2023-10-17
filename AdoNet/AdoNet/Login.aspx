<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AdoNet.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
       
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
        <table >
            <tr>
                <td>UserName :</td>
                <td>
                    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Password :</td>
                <td>
                    <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
