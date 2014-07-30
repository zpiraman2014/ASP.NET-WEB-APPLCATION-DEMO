<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="CoffeeshopWebApp.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="JavaScript/jquery-2.1.1.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $('#btnCheckAvailabiltiy').click(function () {
                var data = {
                    "user": $('[id$=txtUser]').val()
                    
                };


                $.ajax({
                    type: "POST",
                    url: "Register.aspx/CheckUser",
                    data: JSON.stringify(data),
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (msg) {
                        alert(msg.d);
                    }
                });

        
            });
        });
    </script> 
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ControlToCompare="txtPass2" ControlToValidate="txtPass" 
                    ErrorMessage="Password is not match!" ForeColor="Red"></asp:CompareValidator>
    <asp:ValidationSummary ID="ValidationSummary2" runat="server" ForeColor="Red" />
    <table style="width: 93%; margin-top: 0px;">
        <tr>
            <td style="width: 172px">
                Username:</td>
            <td style="width: 248px">
                <asp:TextBox ID="txtUser" runat="server" Width="237px"></asp:TextBox>
                <input id="btnCheckAvailabiltiy" type="button" value="Check Availability" /></td>
            <td id="lblUsername">
              
      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ErrorMessage="Username is required!" ForeColor="Red" 
                    ControlToValidate="txtUser">*</asp:RequiredFieldValidator>
              
            </td>
        </tr>
        <tr>
            <td style="width: 172px; height: 23px">
                Password:</td>
            <td style="height: 23px; width: 248px">
                <asp:TextBox ID="txtPass" runat="server" Width="237px"></asp:TextBox>
            </td>
            <td style="height: 23px">
      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ErrorMessage="Password is required!" ForeColor="Red" 
                    ControlToValidate="txtPass">*</asp:RequiredFieldValidator>

            </td>
        </tr>
        <tr>
            <td style="width: 172px">
                Confirm Password</td>
            <td style="width: 248px">
                <asp:TextBox ID="txtPass2" runat="server" Width="237px"></asp:TextBox>
            </td>
            <td>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ErrorMessage="Confirm password is required!" ForeColor="Red" 
                    ControlToValidate="txtPass2">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 172px">
                Email:</td>
            <td style="width: 248px">
                <asp:TextBox ID="txtEmail" runat="server" Width="237px"></asp:TextBox>
            </td>
            <td>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ErrorMessage="Email is required!" ForeColor="Red" 
                    ControlToValidate="txtEmail">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 172px">
                User Type:</td>
            <td style="width: 248px">
                <asp:DropDownList ID="ddlUserType" runat="server" Height="18px" Width="232px">
                    <asp:ListItem>Admin</asp:ListItem>
                    <asp:ListItem>Guest</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 172px">
                &nbsp;</td>
            <td style="width: 248px">
&nbsp;
                <asp:Button ID="btnRegister" runat="server" onclick="btnRegister_Click" 
                    Text="Register" Width="98px" />
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" Text="Cancel" Width="94px" 
                    onclick="Button1_Click2" />
                </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 172px">
                &nbsp;</td>
            <td style="width: 248px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
