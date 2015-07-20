<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Category.aspx.cs" Inherits="ToyStore.Category" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 409px;
        }
        .auto-style3 {
            width: 177px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Category Page<br />
                    <span class="auto-style1"></span></h1>
            </hgroup>
            <p>
                &nbsp;</p>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style2">
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3">
                            <asp:Label ID="Label1" runat="server" Text="Select A Category"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlist" runat="server" AutoPostBack="True" Height="16px" OnSelectedIndexChanged="ddlist_SelectedIndexChanged" Width="148px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
            <td>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand">
                    <Columns>
                        <asp:ImageField DataImageUrlField="PicDir" HeaderText="Item Picture" ControlStyle-Width="150px" ControlStyle-Height="150px">
<ControlStyle Height="150px" Width="150px"></ControlStyle>
                        </asp:ImageField>
                        <asp:BoundField DataField="ItemName" HeaderText="Item Name" ControlStyle-BorderWidth="100px" >
<ControlStyle BorderWidth="100px"></ControlStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="Price(PerUnit)" HeaderText="Price" ControlStyle-BorderWidth="100px" >
<ControlStyle BorderWidth="100px"></ControlStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="Description" HeaderText="Decription" />
                        <asp:ButtonField CommandName="addToCart" Text="Add To Basket" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        </table>
</asp:Content>
