<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddEditParty.aspx.cs" Inherits="Exercise2.AddEditParty" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        function validateParty() {
            let x = document.getElementById(<%= txtName.ClientID %>);
            if (x == "") {
                <%= lblError.ClientID %>.Text = "Please enter a value";
                return false;
            }
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageTitle" runat="server">
    <asp:Label ID="pageTitle" runat="server" Text=""></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ListContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col">
                <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
            </div>
            <div class="col">:</div>
            <div class="col">
                <asp:TextBox ID="txtName" CssClass="input" runat="server"></asp:TextBox>
            </div>
        </div>
        
        <div class="row error">
            <asp:Label ID="lblError" ForeColor="Red" runat="server"></asp:Label>    
        </div>

        <div class="row">
            <div class="col">
                <asp:Button ID="btnSave" CssClass="btn btn-save" runat="server" Text="Save" OnClientClick="return ValidateParty()" OnClick="btnSave_Click" />
            </div>
            <div class="col">
                <asp:Button ID="btnCancel"  CssClass="btn btn-cancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
             </div>
        </div>
    </div>
</asp:Content>
