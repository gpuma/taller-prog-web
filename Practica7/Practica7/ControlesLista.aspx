<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ControlesLista.aspx.cs" Inherits="Practica7.ControlesLista" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Práctica 7</title>
</head>
<body>
    <form id="form1" runat="server">
    
    <h1>Controles Lista</h1>
    <h2>Demo DropDownList</h2>
    <div>
        <asp:DropDownList ID="drpLenguajes" AutoPostBack="true" runat="server"
         OnSelectedIndexChanged="drpLenguajes_SelectedIndexChanged" />
    </div>
    
    <h2>Demo ListBox</h2>
    <p>Seleccione los lenguajes que conoce: </p>
    <div>
        <%--<h3>Lenguajes Disponibles</h3>--%>
        <asp:ListBox ID="lstLengDisponibles" runat="server"/>
        
        <asp:Button Text="<<" runat="server" onclick="Unnamed1_Click" />
        <asp:Button ID="Button1" Text=">>" runat="server" onclick="Unnamed1_Click" />
        
        <%--<h3>Lenguajes Seleccionados</h3>--%>
        <asp:ListBox ID="lstLengConocidos" runat="server"/>
    </div>
    </form>
</body>
</html>
