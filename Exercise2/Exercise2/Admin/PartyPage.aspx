<% @Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="PartyPage.aspx.cs" Inherits="Exercise2.PartyPage"  EnableEventValidation="false"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #<%= btnAddParty.ClientID %>{
            padding: 10px 20px;
            border: none;
            border-radius: 10px;
            background-color: coral;
        }
    </style>

</asp:Content>
<asp:Content ID="PartyTitle" ContentPlaceHolderID="PageTitle" runat="server">Party List</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ListContent" runat="server">
    <div class="add-btn-wrapper">
        <asp:Button ID="btnAddParty" runat="server" Text="Add Party" OnClick="btnAddParty_Click" />
    </div>
    <asp:GridView ID="partyGrid" CssClass="grid" AutoGenerateColumns="False" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" >
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
            <asp:BoundField DataField="PartyID" HeaderText="#" />
            <asp:BoundField DataField="PartyName" HeaderText="Party Name" />
           <asp:TemplateField HeaderText="Action">
               <ItemTemplate>
                   <asp:Button ID="editBtn" OnClick="editBtn_Click" runat="server" CssClass="btn grid-btn" Text="Edit"/>
                   <asp:Button ID="deleteBtn" OnClick="deleteBtn_Click" runat="server"  CssClass="btn grid-btn" Text="Delete"/>
               </ItemTemplate>
           </asp:TemplateField>
        </Columns>
    </asp:GridView>

</asp:Content>
