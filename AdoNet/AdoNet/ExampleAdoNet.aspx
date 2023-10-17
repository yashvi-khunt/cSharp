﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExampleAdoNet.aspx.cs" Inherits="AdoNet.ExampleAdoNet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
       .auto-style1 {  
            width: 100%;  
        }  
        .auto-style2 {  
            width: 100px;  
        }  
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label runat="server" Text="User Name" ID="usernamelabelId"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="UsernameId" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label runat="server" Text="Email ID"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="EmailId" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label runat="server" Text="Contact"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="ContactId" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style2"></td>
                    <td>
                        <asp:Button ID="ButtonId" runat="server" Text="Submit" OnClick="ButtonId_Click" /></td>
                </tr>
            </table>
        </div>
        <div>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
        <asp:GridView ID="GridView1" runat="server" Width="287px">
        </asp:GridView>
    </form>
    </body>
</html>
