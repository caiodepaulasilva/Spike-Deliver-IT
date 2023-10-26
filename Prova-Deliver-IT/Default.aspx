<%@ Page Title="Prova - Deliver-IT" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Prova_Deliver_IT._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="Usuarios" runat="server" Style=" position: relative; width: 80%; left: 10%"
        Caption="Usuarios"  CaptionAlign="Top" CssClass="table table-bordered">
    </asp:GridView>
<%--    <asp:GridView runat="server" ID="Usuarios" CssClass="table table-bordered">
    </asp:GridView>--%>
    <asp:GridView ID="Entidades" runat="server" Style=" position: relative; width: 80%; left: 10%"
        Caption="Entidades"  CaptionAlign="Top" CssClass="table table-bordered">
    </asp:GridView>
</asp:Content>
