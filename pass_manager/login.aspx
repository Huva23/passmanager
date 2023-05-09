<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="pass_manager.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <form id="loginForm">
        <asp:Label ID="usernameLabel" runat="server" Text="Username:"></asp:Label>
        <asp:TextBox ID="username" runat="server"></asp:TextBox>
        <asp:Label ID="passwordLabel" runat="server" Text="Password:"></asp:Label>
        <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
        <asp:Button ID="loginButton" runat="server" Text="Login" OnClick="Login_Click" />
    </form>
</asp:Content>
