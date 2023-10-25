<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddInvoice.aspx.cs" Inherits="Exercise2.AddInvoice" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .invoice-container{
            display: flex;
            justify-content: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageTitle" runat="server">
    <asp:Label ID="pageTitle" runat="server" Text="Add Invoice"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ListContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col">
                <asp:Label ID="lblPartyName" runat="server" Text="Party Name"></asp:Label>
            </div>
            <div class="col">:</div>
            <div class="col">
                <asp:DropDownList ID="DDParty" CssClass="input" runat="server" AutoPostBack="true">
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
                <asp:DropDownList ID="DDProduct" CssClass="input" runat="server" AutoPostBack="true">
                </asp:DropDownList>
            </div>
        </div>

        <div class="row">
            <div class="col">
                <asp:Label ID="lblDate" runat="server" Text="Date"></asp:Label>
            </div>
            <div class="col">:</div>
            <div class="col">
                <asp:TextBox ID="txtDate" CssClass="input" runat="server" TextMode="Date"></asp:TextBox>
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
                <asp:Label ID="lblQuantity" runat="server" Text="Quantity"></asp:Label>
            </div>
            <div class="col">:</div>
            <div class="col">
                <asp:TextBox ID="txtQuantity" CssClass="input" runat="server" TextMode="Number"></asp:TextBox>
            </div>
        </div>

        <div class="row error">
            <asp:Label ID="lblError" ForeColor="Red" runat="server"></asp:Label>
        </div>

        <div class="row">
            <div class="col">
                <asp:Button ID="btnAddInvoice" CssClass="btn btn-save" runat="server" Text="Add to Invoice" OnClick="btnAddInvoice_Click" />
            </div>
        </div>
    </div>
    <br />
    <div class="invoice-container-wrapper">

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
                <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
                <asp:BoundField DataField="ProductRate" HeaderText="Product Rate" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                <asp:BoundField DataField="Total" HeaderText="Total" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
