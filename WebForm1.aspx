<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="attendancemanagament.registration.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:TextBox ID="uname" runat="server"></asp:TextBox>
    <p>
        <asp:TextBox ID="passwd" TextMode="Password" runat="server"></asp:TextBox>
    </p>
    <asp:Button ID="submit" runat="server" Text="submit" OnClick="submit_Click" />
</asp:Content>
