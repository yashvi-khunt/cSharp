<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddEditProduct.aspx.cs" Inherits="Exercise2.AddEditProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageTitle" runat="server">
    <asp:Label ID="pageTitle" runat="server" Text=""></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ListContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col">
                <asp:Label ID="lblName" runat="server" Text="Product Name"></asp:Label>
            </div>
            <div class="col">:</div>
            <div class="col">
                <asp:TextBox ID="txtName" CssClass="input" runat="server"></asp:TextBox>
            </div>
        </div>

        <div class="row">
            <div class="col">
                <asp:Label ID="lblRate" runat="server" Text="Product Rate"></asp:Label>
            </div>
            <div class="col">:</div>
            <div class="col">
                <asp:TextBox ID="txtRate" CssClass="input" runat="server" TextMode="Number"></asp:TextBox>
            </div>
        </div>

        <div class="row">
            <div class="col">
                <asp:Label ID="lblDate" runat="server" Text="Date"></asp:Label>
            </div>
            <div class="col">:</div>
            <div class="col">
                <asp:TextBox ID="txtDate" TextMode="Date" CssClass="input" runat="server"></asp:TextBox>
            </div>
        </div>

        <div class="row">
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
