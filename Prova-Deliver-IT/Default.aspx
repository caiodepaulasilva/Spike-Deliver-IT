<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Prova._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">  
   <asp:GridView runat="server" ID="Usuario" CssClass="table table-bordered">  
   </asp:GridView>  
    <asp:GridView runat="server" ID="Entidade" CssClass="table table-bordered">  
</asp:GridView>  
 </asp:Content>