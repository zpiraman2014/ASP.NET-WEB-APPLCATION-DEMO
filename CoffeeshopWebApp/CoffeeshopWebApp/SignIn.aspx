<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="CoffeeshopWebApp.SignIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:Label ID="Label1" runat="server" Text="Label" ForeColor="Red" 
    Visible="False"></asp:Label>
    <table style="width: 42%">
        <tr>
            <td style="width: 100px">
                Username:</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="163px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TextBox1" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                Password:</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="162px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="TextBox2" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 100px; height: 33px;">
                </td>
            <td style="height: 33px">
                <asp:Button ID="Button1" runat="server" Text="Login" Width="88px" 
                    onclick="Button1_Click" />
&nbsp;&nbsp;
            </td>
        </tr>
                <tr>
            <td style="width: 100px">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Register.aspx">Sign Up</asp:HyperLink>
                    </td>
            <td>

            </td>
        </tr>
    </table>

</asp:Content>
