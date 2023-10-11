<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Part2.aspx.cs" Inherits="WebApplication3.Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:RadioButton ID="rbnRed"  runat="server" OnCheckedChanged="rbnColor_CheckedChanged" GroupName="color" Text="Red" AutoPostBack="True" />
            <asp:RadioButton ID="rbnGreen" runat="server" OnCheckedChanged="rbnColor_CheckedChanged" GroupName="color" Text="Green" AutoPostBack="True"/>
            <asp:RadioButton ID="rbnBlue" runat="server" OnCheckedChanged="rbnColor_CheckedChanged" GroupName="color" Text="Blue" AutoPostBack="True"/>
            <br />
            <br />
            <%--<asp:Button ID="Button1" runat="server" Text="Submit" />--%>
        </div>
       
    </form>
</body>
</html>
