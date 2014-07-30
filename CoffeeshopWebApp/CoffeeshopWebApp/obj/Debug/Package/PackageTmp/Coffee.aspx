<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Coffee.aspx.cs" Inherits="CoffeeshopWebApp.Coffee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Label">Select Coffee Type:</asp:Label>
    <asp:DropDownList ID="DropDownList1"  AutoPostBack="true"  runat="server"
        onselectedindexchanged="DropDownList1_SelectedIndexChanged">
    </asp:DropDownList>
    <asp:Label ID="Label2" runat="server" Text="Label" EnableViewState="False"></asp:Label>
</asp:Content>
