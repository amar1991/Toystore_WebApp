<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ToyStore.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
    .auto-style2 {
        width: 245px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Login Page<br />
            </hgroup>

        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        Please login using your details here:</p>
<p>
        &nbsp;</p>
<p>
        <table style="width:100%;">
            <tr>
                <td class="auto-style2">Username</td>
                <td>
                    <asp:TextBox ID="UsernameBox" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Password</td>
                <td>
                    <input id="PasswordBox" type="password" /></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
                    <br />
                    forgot password?</td>
                <td>&nbsp;</td>
            </tr>
        </table>
</p>
<p>
    &nbsp;</p>
<p>
        &nbsp;</p>
</asp:Content>
