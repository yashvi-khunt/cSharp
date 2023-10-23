<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ProductPage.aspx.cs" Inherits="Exercise2.ProductPage" EnableEventValidation="false"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #<%= btnAddProduct.ClientID %> {
            padding: 10px 20px;
            border: none;
            border-radius: 10px;
            background-color: coral;
        }
    </style>

</asp:Content>
<asp:Content ID="ProductTitle" ContentPlaceHolderID="PageTitle" runat="server">Product List</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ListContent" runat="server">
    <div class="add-btn-wrapper">
        <asp:Button ID="btnAddProduct" runat="server" Text="Add Product" OnClick="btnAddProduct_Click" />
    </div>
    <asp:GridView ID="productGrid" CssClass="grid" AutoGenerateColumns="False" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
        <HeaderStyle BackColor="#FFFFFF" Font-Bold="True" ForeColor="#3f51b5" />
        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
        <RowStyle BackColor="White" ForeColor="#003399" />
        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
        <SortedAscendingCellStyle BackColor="#EDF6F6" />
        <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
        <SortedDescendingCellStyle BackColor="#D6DFDF" />
        <SortedDescendingHeaderStyle BackColor="#002876" />

        <Columns>
            <asp:BoundField DataField="ProductID" HeaderText="#" />
            <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
            <asp:BoundField DataField="ProductRate" HeaderText="Product Rate" />
            <asp:BoundField DataField="ProductDate" HeaderText="Date" />
            <asp:TemplateField HeaderText="Action">
                <ItemTemplate>
                    <asp:Button ID="editBtn" OnClick="editBtn_Click" runat="server" CssClass="btn grid-btn" Text="Edit" />
                    <asp:Button ID="deleteBtn" OnClick="deleteBtn_Click" runat="server" CssClass="btn grid-btn" Text="Delete" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>


</asp:Content>
