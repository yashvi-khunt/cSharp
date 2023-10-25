<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="InvoicePage.aspx.cs" Inherits="Exercise2.InvoicePage" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #<%= btnAddInvoice.ClientID %> {
            padding: 10px 20px;
            border: none;
            border-radius: 10px;
            background-color: coral;
        }

        .grid-btn:nth-last-child(1){
            background-color: darkgray;
        }
    </style>
</asp:Content>
<asp:Content ID="InvoiceTitle" ContentPlaceHolderID="PageTitle" runat="server">Invoice List</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ListContent" runat="server">

    <div class="add-btn-wrapper">
        <asp:Button ID="btnAddInvoice" runat="server" Text="Add Invoice" OnClick="btnAddInvoice_Click" />
    </div>
    <asp:GridView ID="invoiceGrid" CssClass="grid" AutoGenerateColumns="False" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
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
            <asp:BoundField DataField="InvoiceId" HeaderText="#" />
            <asp:BoundField DataField="PartyName" HeaderText="Party Name" />
            <asp:BoundField DataField="InvoiceDate" HeaderText="Date" />
            <asp:TemplateField HeaderText="Action">
                <ItemTemplate>
                    <asp:Button ID="editBtn" OnClick="editBtn_Click"  runat="server" CssClass="btn grid-btn" Text="Edit" />
                    <asp:Button ID="deleteBtn" OnClick="deleteBtn_Click"  runat="server" CssClass="btn grid-btn" Text="Delete" />
                    <asp:Button ID="viewBtn" OnClick="viewBtn_Click" runat="server" CssClass="btn grid-btn" Text="View Details" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
