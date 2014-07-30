<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="InsertUpdate.aspx.cs" Inherits="CoffeeshopWebApp.InsertUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
    &nbsp;<asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Label"></asp:Label>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
            ForeColor="Red" />
    </div>
    <table style="width: 100%">
        <tr>
            <td style="width: 133px; height: 29px;">
                Name:</td>
            <td style="height: 29px">
                <asp:TextBox ID="txtName" runat="server" Width="425px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtName" ErrorMessage="name is required" ForeColor="Red" 
                    SetFocusOnError="True">required</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 133px">
                Type:</td>
            <td>
                <asp:TextBox ID="txtType" runat="server" Width="425px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtType" ErrorMessage="type is required" ForeColor="Red" 
                    SetFocusOnError="True">required</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 133px">
                Price:</td>
            <td>
                <asp:TextBox ID="txtPrice" runat="server" Width="425px" TextMode="Number"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                    ControlToValidate="txtPrice" ErrorMessage="Price must be numeric value" ForeColor="Red" 
                    SetFocusOnError="True">invalid</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 133px">
                Roast:</td>
            <td>
                <asp:TextBox ID="txtRoast" runat="server" Width="425px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="txtRoast" ErrorMessage="roast is required" ForeColor="Red" 
                    SetFocusOnError="True">required</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 133px">
                Country:</td>
            <td>
                <asp:TextBox ID="txtCountry" runat="server" Width="425px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="txtCountry" ErrorMessage="country is required" 
                    ForeColor="Red" SetFocusOnError="True">required</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 133px">
                Image:</td>
            <td>
                <asp:DropDownList ID="ddlImages" runat="server" Height="20px" Width="411px">
                </asp:DropDownList>
                <asp:FileUpload ID="FileUpload1" runat="server" Width="293px" />
                <asp:Button ID="Button5" runat="server" onclick="Button5_Click" 
                    style="margin-left: 0px" Text="Upload" Width="147px" />
                <br />
                <asp:Label ID="lblResult" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 133px">
                Review:</td>
            <td>
                <asp:TextBox ID="txtReview" runat="server" Height="135px" TextMode="MultiLine" 
                    Width="437px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                    ControlToValidate="txtReview" ErrorMessage="review is required" ForeColor="Red" 
                    SetFocusOnError="True">required</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 133px">
                &nbsp;</td>
            <td>
                <table style="width: 72%">
                    <tr>
                        <td style="width: 180px">
                            <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="Save" 
                                Width="152px" />
                        </td>
                        <td>
                            <asp:Button ID="Button4" runat="server" Text="Cancel" Width="152px" 
                                CausesValidation="False" onclick="Button4_Click" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
