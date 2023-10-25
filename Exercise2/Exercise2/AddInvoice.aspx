<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddInvoice.aspx.cs" Inherits="Exercise2.AddInvoice" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
            <asp:Label ID="lblError" ForeColor="Red" runat="server"></asp:Label>
        </div>

        <div class="row">
            <div class="col">
                <asp:Button ID="btnAddInvoice" CssClass="btn btn-save" runat="server" Text="Add to Invoice" />
            </div>
        </div>
    </div>
    <div class="container">
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
                <asp:BoundField DataField="PartyName" HeaderText="Party Name" />
                <asp:BoundField DataField="InvoiceDate" HeaderText="Date" />
                <asp:TemplateField HeaderText="Action">
                    <ItemTemplate>
                        <asp:Button ID="editBtn" runat="server" CssClass="btn grid-btn" Text="Edit" />
                        <asp:Button ID="deleteBtn" runat="server" CssClass="btn grid-btn" Text="Delete" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
