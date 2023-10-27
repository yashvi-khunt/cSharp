<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ViewInvoice.aspx.cs" Inherits="Exercise2.ViewInvoice" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="title" ContentPlaceHolderID="PageTitle" runat="server">
    View Invoice
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ListContent" runat="server">
    <div id="detailView" runat="server" class="invoice-container-wrapper">
    <div class="invoice-container">
        <div class="row">
            <div class="col"><b>Invoice No</b></div>
            <div class="col">:</div>
            <div class="col">
                <asp:Label ID="lblInvoiceid" runat="server" Text="100"></asp:Label>
            </div>
        </div>
        <div class="row">
            <div class="col"><b>Party Name</b></div>
            <div class="col">:</div>
            <div class="col">
                <asp:Label ID="lblParty" runat="server" Text="Party3"></asp:Label>
            </div>
        </div>
        <div class="row">
            <div class="col"><b>Date</b></div>
            <div class="col">:</div>
            <div class="col">
                <asp:Label ID="lblInvDate" runat="server" Text="25-10-2023"></asp:Label>
            </div>
        </div>
    </div>


    <asp:GridView ID="currentInvoiceGrid" CssClass="grid" AutoGenerateColumns="False" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
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
            <asp:BoundField DataField="id" HeaderText="#"  />
            
            <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
            <asp:BoundField DataField="ProductRate" HeaderText="Product Rate"/>
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
            <asp:BoundField DataField="Total" HeaderText="Total" />
        </Columns>
    </asp:GridView>


    <div class="invoice-container">
        <div class="row">
            <div class="col"><b>Grand Total</b></div>
            <div class="col">:</div>
            <div class="col">
                <asp:Label ID="lblGTotal" runat="server" Text="100"></asp:Label>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <asp:Button ID="btnClose" CssClass="btn btn-delete" runat="server" Text="Close" OnClick="btnClose_Click"/>
            </div>
        </div>
    </div>
</div>
</asp:Content>
