<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="ToyStore.Search" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1 {
            font-size: small;
        }
        .auto-style3 {
            width: 198px;
        }
        .auto-style4 {
            width: 297px;
        }
        .auto-style5 {
            width: 125px;
        }
        .auto-style6 {
            width: 309px;
        }
        .auto-style7 {
            width: 389px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Search Page<br />
                    <span class="auto-style1"></span></h1>
            </hgroup>
        </div>
    </section>
</asp:Content>

<asp:Content ID="Content3" runat="server" contentplaceholderid="MainContent">
    <br />
    <table style="width:100%;">
        <tr>
            <td class="auto-style5">
    <asp:Label ID="Label1" runat="server" Text="Search for an Item: "></asp:Label>
            </td>
            <td class="auto-style6">
                <asp:TextBox ID="txtboxsearch" runat="server" AutoPostBack="True" OnTextChanged="txtboxsearch_TextChanged"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnsearch" runat="server" OnClick="btnsearch_Click" Text="Search" Width="200px" />
            </td>
        </tr>
    </table>
    <br />
    <table style="width:100%;">
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:ListBox ID="ListBox1" runat="server" Height="207px" style="margin-top: 0px" Width="225px" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedItemChanged"></asp:ListBox>
            </td>
            <td>
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style3">
                            <asp:Image ID="Image1" runat="server" Height="173px" Width="197px" />
                        </td>
                        <td>
                            <asp:ListBox ID="ListBox2" runat="server" Height="186px" Width="265px"></asp:ListBox>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td>
                <table style="width: 100%;">
                    <tr>
                        <td class="auto-style7">&nbsp;</td>
                        <td>
                            <asp:Button ID="btnAddto" runat="server" OnClick="btnAddto_Click" Text="Add To Basket" />

                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    <br />
    <br />
    <p>
    </p>
</asp:Content>


