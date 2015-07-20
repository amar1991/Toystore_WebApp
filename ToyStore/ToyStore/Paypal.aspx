<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Paypal.aspx.cs" Inherits="ToyStore.Paypal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 154px;
        }
        .auto-style3 {
            width: 154px;
            height: 45px;
        }
        .auto-style4 {
            height: 45px;
        }
        .auto-style5 {
            width: 183px;
        }
        .auto-style6 {
            height: 45px;
            width: 183px;
        }
        .auto-style7 {
            width: 177px;
        }
        .auto-style8 {
            height: 45px;
            width: 177px;
        }
        .auto-style9 {
            width: 154px;
            height: 21px;
        }
        .auto-style10 {
            width: 183px;
            height: 21px;
        }
        .auto-style11 {
            width: 177px;
            height: 21px;
        }
        .auto-style12 {
            height: 21px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style7">
                <asp:Label ID="lblError" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label1" runat="server" Text="User Login"></asp:Label>
            </td>
            <td class="auto-style6">
                <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style8"></td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="txtPass" TextMode="Password" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9"></td>
            <td class="auto-style10"></td>
            <td class="auto-style11">
                <asp:Button ID="btnCommit" runat="server" Height="25px" OnClick="btnCommit_Click" Text="Confirm Payment" Width="114px" />
            </td>
            <td class="auto-style12"></td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
