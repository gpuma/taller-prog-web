<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EjemploMembresia.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<%-- Este es un control de Login que viene con ASP.NET, aunque también podríamos
    usar el método tradicional de crear nuestras cajas de texto, labels, etc. --%>
<asp:Login ID="ctlLogin" runat="server" onauthenticate="ctlLogin_Authenticate" />
</asp:Content>
