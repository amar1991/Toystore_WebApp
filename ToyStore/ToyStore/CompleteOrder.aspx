<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CompleteOrder.aspx.cs" Inherits="ToyStore.CompleteOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style2 {
            height: 21px;
            width: 317px;
        }
        .auto-style3 {
            height: 21px;
            width: 240px;
        }
        .auto-style4 {
            width: 240px;
        }
        .auto-style7 {
            width: 196px;
            height: 22px;
        }
        .auto-style8 {
            height: 21px;
            width: 196px;
        }
        .auto-style9 {
            width: 196px;
        }
        .auto-style10 {
            width: 317px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label1" runat="server" Text="Shipping Address"></asp:Label>
            </td>
            <td class="auto-style8"></td>
            <td class="auto-style2">
                <asp:Label ID="Label2" runat="server" Text="Items"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style4" rowspan="4">
                <asp:TextBox ID="txtAreaS" runat="server" Height="146px" TextMode="MultiLine" Width="223px" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="auto-style9">&nbsp;</td>
            <td rowspan="4" class="auto-style10"> 
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="40px">
                    <Columns>
                        <asp:BoundField DataField="ItemName" HeaderText="Item Name" >
                        <ControlStyle Width="40px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Price(PerUnit)" HeaderText="Price" >
                        <ControlStyle Width="40px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Description" HeaderText="Description" >
                        <ControlStyle Width="40px" />
                        </asp:BoundField>
                        <asp:ImageField HeaderText="Item Picture" DataImageUrlField="PicDir"  ControlStyle-Width="150px" ControlStyle-Height="150px" Visible="False">
<ControlStyle Height="150px" Width="150px"></ControlStyle>
                        </asp:ImageField>
                        <asp:ButtonField Text="Remove" ButtonType="Button" ControlStyle-Width="75px" ControlStyle-Height="25px" CommandName="Remove" Visible="False" >
<ControlStyle Height="25px" Width="75px"></ControlStyle>
                        </asp:ButtonField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="auto-style7"></td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style10">
                <asp:Label ID="lblTotal" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
