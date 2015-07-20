<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="My_Account.aspx.cs" Inherits="ToyStore.My_Account" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
    .auto-style2 {
        width: 72px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>My Account Page<br />
                    <span class="auto-style1"></span></h1>
            </hgroup>
            <p>
                &nbsp;</p>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    <br />
</p>
<p>
    <table style="width: 100%;">
        <tr>
            <td class="auto-style2">Firstname<br />
                Surname</td>
            <td>Bob<br />
                Davies</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Address:</td>
            <td>10 Cresent Avenue<br />
                London<br />
                W19JK</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Payment Details:</td>
            <td>You have chosen 1 Click payment for PayPal</td>
            <td>
                <br />
            </td>
        </tr>
    </table>
</p>
</asp:Content>
