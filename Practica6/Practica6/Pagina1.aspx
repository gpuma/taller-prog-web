<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Pagina1.aspx.cs" Inherits="Practica6.Pagina1" %>

<%--Así registramos a nuestro control de usuario--%>
<%@ Register TagPrefix="prac6" TagName="Log" Src="~/LoginCtrl.ascx"%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h2>Hola desde la página 1</h2>

<%--Así llamamos a nuestro control de usuario--%>
<prac6:Log runat="server"/>

</asp:Content>
