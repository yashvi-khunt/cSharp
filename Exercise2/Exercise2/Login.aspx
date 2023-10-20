<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Exercise2.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   <link rel="stylesheet" href="~/CSS/formstyle.css"/>
</head>
<body>

    <div class="container">
        <div class="card">
            <h2>Login Form</h2>
            <form id="form1" runat="server">
                <asp:Label CssClass="label" ID="username" runat="server" Text="UserName"></asp:Label>
           
                <asp:TextBox CssClass="input" ID="txtUsername"  placeholder="Enter your username" runat="server"></asp:TextBox>
            
                
                <asp:Label CssClass="label" ID="password" runat="server" Text="Password"></asp:Label>
          

                <asp:TextBox CssClass="input" ID="txtPssword" placeholder="Enter your password" runat="server"></asp:TextBox>
            

                <asp:Button CssClass="btn" ID="btnSubmit" runat="server" Text="Login" />
         
            </form>

            <div class="switch">Don't have an account? <a href="~/SignUp.aspx" runat="server">Sign Up</a></div>
        </div>
    </div>
</body>
</html>
