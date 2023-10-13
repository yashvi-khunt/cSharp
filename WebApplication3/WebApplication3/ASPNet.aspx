<%@ Page Title="ASP.NET Course Details" Language="C#" MasterPageFile="~/CourseMasterPage.Master" AutoEventWireup="true" CodeBehind="ASPNet.aspx.cs" Inherits="WebApplication3.ASPNet" %>

<%@ MasterType VirtualPath="~/CourseMasterPage.Master" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="cphCourseDetails">
    <p>
        ASP.NET
    </p>
    <p>
        &nbsp;
    </p>
    <p>
        Following are the details of ASP.NET :
    </p>
    <p>
        ......
    </p>
    <p>
        <img alt="brand 1" src="images/brand-1.png" />
    </p>
    <p>
        <asp:Button ID="btnasp" runat="server" OnClick="btnasp_Click" Text="Button" />
    </p>
</asp:Content>

<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="cphStartDate">
    <p>
        15 March
    </p>
</asp:Content>


<asp:Content ID="Content3" runat="server" ContentPlaceHolderID="head">
    <style type="text/css">
       
    </style>
</asp:Content>



