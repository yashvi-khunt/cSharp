<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddAssign.aspx.cs" Inherits="Exercise2.Admin.AddAssign" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageTitle" runat="server">
    <asp:Label ID="pageTitle" runat="server" Text="Add Assign"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ListContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col">
                <asp:Label ID="lblPartyName" runat="server" Text="Party Name"></asp:Label>
            </div>
            <div class="col">:</div>
            <div class="col">
                <%-- <asp:TextBox TextMode="" ID="txtName" CssClass="input" runat="server"></asp:TextBox>--%>
                <asp:DropDownList ID="DDParty" CssClass="input" runat="server">
                </asp:DropDownList>
            </div>
        </div>

        <div class="row">
            <div class="col">
                <asp:Label ID="lblProductName" runat="server" Text="Product Name"></asp:Label>
            </div>
            <div class="col">:</div>
            <div class="col">
                <%-- <asp:TextBox ID="txtRate" CssClass="input" runat="server" TextMode="Number"></asp:TextBox>--%>
                <asp:DropDownList ID="DDProduct" CssClass="input" runat="server">
                </asp:DropDownList>
            </div>
        </div>


        <div class="row error"  >
            <asp:Label ID="lblError" ForeColor="Red" runat="server"></asp:Label>
        </div>

        <div class="row">
            <div class="col">
                <asp:Button ID="btnSave" CssClass="btn btn-save" runat="server" Text="Save" OnClick="btnSave_Click" />
            </div>
            <div class="col">
                <asp:Button ID="btnCancel" CssClass="btn btn-cancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
            </div>
        </div>
    </div>
</asp:Content>
