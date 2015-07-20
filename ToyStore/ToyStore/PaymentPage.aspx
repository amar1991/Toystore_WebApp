<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PaymentPage.aspx.cs" Inherits="ToyStore.PaymentPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 406px;
        }
        .auto-style3 {
            width: 260px;
        }
        .auto-style4 {
            width: 260px;
            height: 40px;
        }
        .auto-style5 {
            height: 40px;
        }
        .auto-style6 {
        }
        .auto-style7 {
            width: 182px;
        }
        .auto-style8 {
            height: 21px;
        }
        .auto-style9 {
            width: 163px;
        }
        .auto-style10 {
            height: 21px;
            width: 163px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width:100%; text-align: center;" aria-orientation="horizontal">
        <tr>
            <td style="text-align: left" class="auto-style2">
                <asp:Label ID="Label1" runat="server" Font-Size="Large" Font-Underline="True" Text="Shopping Basket:"></asp:Label>
                <asp:Label ID="lblEmpty" runat="server" ForeColor="Red"></asp:Label>
            </td>
            <td style="text-align: left" class="auto-style2" rowspan="3">
                <table style="width: 100%; margin-right: 53px;">
                    <tr>
                        <td class="auto-style3">
                            <asp:Label ID="Label2" runat="server" Text="Payment Method"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                                <asp:ListItem>Debit</asp:ListItem>
                                <asp:ListItem Value="Credit"></asp:ListItem>
                                <asp:ListItem>Paypal</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="Label3" runat="server" Text="Select Shipping Address"></asp:Label>
                        </td>
                        <td class="auto-style5">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style6" colspan="2">
                            <table style="width:100%;">
                                <tr>
                                    <td class="auto-style7">
                                        <asp:Label ID="Label9" runat="server" Text="Customer First Name"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtFname" runat="server"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="txtFnameVAL" runat="server" ControlToValidate="txtFname" Display="Dynamic" ErrorMessage="* This is required!" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style7">
                                        <asp:Label ID="Label10" runat="server" Text="Customer Surname"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtLname" runat="server"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="txtLnameVAL" runat="server" ControlToValidate="txtLname" Display="Dynamic" ErrorMessage="* This is required!" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style7">
                                        <asp:Label ID="Label4" runat="server" Text="House Name/Number"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtNo" runat="server"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="txtNoVAL" runat="server" ControlToValidate="txtNo" Display="Dynamic" ErrorMessage="* This is required!" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style7">
                                        <asp:Label ID="Label5" runat="server" Text="Road Name"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtRoad" runat="server"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="txtRoadVAL" runat="server" ControlToValidate="txtRoad" Display="Dynamic" ErrorMessage="* This is required!" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style7">
                                        <asp:Label ID="Label6" runat="server" Text="City/Town"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="txtCityVAL" runat="server" ControlToValidate="txtCity" Display="Dynamic" ErrorMessage="* This is required!" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style7">
                                        <asp:Label ID="Label7" runat="server" Text="Post Code"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtPostCode" runat="server"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="txtPostCodeVAL" runat="server" ControlToValidate="txtPostCode" Display="Dynamic" ErrorMessage="* This is required!" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">
                            &nbsp;</td>
                        <td>
                            <asp:Button ID="btnBuy" runat="server" Text="Commit To Buy" Width="207px" OnClick="btnBuy_Click" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="auto-style2"> 
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand" OnRowDeleting="GridView1_RowDeleting">
                    <Columns>
                        <asp:BoundField DataField="ItemName" HeaderText="Item Name" />
                        <asp:BoundField DataField="Price(PerUnit)" HeaderText="Price" />
                        <asp:BoundField DataField="Description" HeaderText="Description" />
                        <asp:ImageField HeaderText="Item Picture" DataImageUrlField="PicDir"  ControlStyle-Width="150px" ControlStyle-Height="150px">
<ControlStyle Height="150px" Width="150px"></ControlStyle>
                        </asp:ImageField>
                        <asp:ButtonField Text="Remove" ButtonType="Button" ControlStyle-Width="75px" ControlStyle-Height="25px" CommandName="Remove" >
<ControlStyle Height="25px" Width="75px"></ControlStyle>
                        </asp:ButtonField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="auto-style2"> 
                <table style="width:100%;">
                    <tr>
                        <td>&nbsp;</td>
                        <td class="auto-style9">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style8"></td>
                        <td class="auto-style10">&nbsp;</td>
                        <td class="auto-style8"></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td class="auto-style9">
                            <asp:Label ID="Label8" runat="server" Text="SubTotal:"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lblTotal" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
