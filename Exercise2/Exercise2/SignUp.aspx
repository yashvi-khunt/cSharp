<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="Exercise2.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="~/CSS/formstyle.css" />
</head>
<body>
    <div class="container">
        <div class="card">
            <h2>Sign Up Form</h2>
            <form id="form1" runat="server">

                <%-- UserName --%>
                <asp:Label CssClass="label" ID="lbluser" runat="server" Text="UserName"></asp:Label>
                <asp:TextBox CssClass="input" ID="txtUsername" placeholder="Enter your username" runat="server"></asp:TextBox>

                <%-- Password --%>
                <asp:Label CssClass="label" ID="password" runat="server" Text="Password"></asp:Label>
                <asp:TextBox CssClass="input" ID="txtPssword" placeholder="Enter your password" runat="server"></asp:TextBox>

                <%-- Confirm Password --%>
                <asp:Label CssClass="label" ID="confirmpwd" runat="server" Text="Confirm Password"></asp:Label>
                <asp:TextBox CssClass="input" ID="txtconfirmpwd" placeholder="Confirm your password" runat="server"></asp:TextBox>
           

                <%-- Submit --%>
                <asp:Button CssClass="btn" ID="btnSignUp" runat="server" Text="Sign Up" />
   
            </form>
            <div class="switch">Already have an account? <a href="~/Login.aspx" runat="server">Login here</a></div>
        </div>
    </div>
</body>
</html>
