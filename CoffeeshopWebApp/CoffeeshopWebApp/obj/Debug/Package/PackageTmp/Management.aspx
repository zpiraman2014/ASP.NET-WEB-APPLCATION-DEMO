<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Management.aspx.cs" Inherits="CoffeeshopWebApp.Management" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <script src="JavaScript/jquery-1.3.2.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $('.deleteButton').click(function () {
                return confirm('Are you sure you wish to delete this record?');
            });
        });
    </script> 

    <asp:HyperLink ID="HyperLink1" runat="server" 
    NavigateUrl="~/InsertUpdate.aspx" ForeColor="#333333">Add new coffee</asp:HyperLink>
    <br />
    <br />

    <asp:GridView ID="GridView1" runat="server" BackColor="White" 
    BorderColor="#DEDFDE" BorderStyle="Solid" BorderWidth="1px" CellPadding="4" 
    EnableViewState="False" ForeColor="Black" GridLines="Vertical" Width="739px" 
        AutoGenerateColumns="False" Height="240px" PageSize="10000000" 
        onrowcommand="GridView1_RowCommand"
        DataKeyNames='id' onrowdeleting="GridView1_RowDeleting" >

    <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="id" 
                DataNavigateUrlFormatString="~/InsertUpdate.aspx?ID={0}" Text="Edit" 
                Target="_blank" >


            <ControlStyle ForeColor="#333333" />
            </asp:HyperLinkField>


        <asp:ButtonField  ButtonType="Link" 
            CommandName="Delete"
            Text="Delete"
            ItemStyle-CssClass="deleteButton" >
<ItemStyle CssClass="deleteButton"></ItemStyle>
         </asp:ButtonField>



            <asp:BoundField DataField="name" HeaderText="Name" />
            <asp:BoundField DataField="roast" HeaderText="Roast" />
            <asp:BoundField DataField="country" HeaderText="Country" />

  
        </Columns>



    <FooterStyle BackColor="#CCCC99" />
    <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
    <RowStyle BackColor="#F7F7DE" />
    <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
    <SortedAscendingCellStyle BackColor="#FBFBF2" />
    <SortedAscendingHeaderStyle BackColor="#848384" />
    <SortedDescendingCellStyle BackColor="#EAEAD3" />
    <SortedDescendingHeaderStyle BackColor="#575357" />
</asp:GridView>


</asp:Content>
