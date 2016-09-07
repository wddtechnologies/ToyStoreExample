<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="newdataset.aspx.cs" Inherits="ToyStoreExample.newdataset" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1">
    <ItemTemplate>
        LastName:
        <asp:Label ID="LastNameLabel" runat="server" Text='<%# Eval("LastName") %>' />
        <br />
<br />
    </ItemTemplate>
</asp:DataList>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SchoolDBConnectionString %>" SelectCommand="SELECT [LastName] FROM [Teacher]"></asp:SqlDataSource>
</asp:Content>
