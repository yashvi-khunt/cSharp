<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="AdoNet.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Welcome to Home Page
            <br />
            <a href="DataSet.aspx">DataSet</a>
            <br />
            <a href="DataTable.aspx">DataTable</a>
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">LogOut</asp:LinkButton>

        </div>
    </form>
</body>
</html>
