<%@ Page Title="C-Sharp Course Details" Language="C#" MasterPageFile="~/CourseMasterPage.Master" AutoEventWireup="true" CodeBehind="CSharp.aspx.cs" Inherits="WebApplication3.CSharp" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="cphCourseDetails">
    <p>
        CSharp Course Details :
    </p>
    <br />
    Following are the details of c#<br />
    .......<br />
    <br />
    <asp:Button ID="btncs" runat="server" OnClick="btncs_Click" Text="Button" />
    <br />
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="head">
</asp:Content>


<asp:Content ID="Content3" runat="server" contentplaceholderid="cphStartDate">
    <p>
                                            1st March</p>
</asp:Content>



