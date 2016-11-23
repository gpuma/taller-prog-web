<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="VerUsuarios.aspx.cs" Inherits="EjemploMembresia.Mantenimiento.VerUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Usuarios</h1>
    <asp:GridView ID="grdUsuarios" runat="server"/>
</asp:Content>
