<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Credit.aspx.cs" Inherits="ToyStore.Credit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 134px;
        }
        .auto-style3 {
            width: 134px;
            height: 21px;
        }
        .auto-style4 {
            height: 21px;
        }
        .auto-style5 {
            width: 236px;
        }
        .auto-style6 {
            height: 21px;
            width: 236px;
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5">
                <asp:Label ID="lblShipping" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label1" runat="server" Text="Credit Card Number"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="txtCardNo" runat="server" Width="208px"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lblError" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label2" runat="server" Text="Expire Date"></asp:Label>
            </td>
            <td class="auto-style6">
                <asp:TextBox ID="txtMon" runat="server" MaxLength="2" Width="27px"></asp:TextBox>
                <asp:Label ID="Label4" runat="server" Font-Size="X-Large" Text="  /  "></asp:Label>
                <asp:TextBox ID="txtYear" runat="server" MaxLength="2" Width="31px"></asp:TextBox>
            </td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label3" runat="server" Text="Security Number"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="txtSecNo" runat="server" MaxLength="3" Width="61px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>
                <asp:Button ID="btnConfirm" runat="server" OnClick="btnConfirm_Click" Text="Confirm Payment" Width="121px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
