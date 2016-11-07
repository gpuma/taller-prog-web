<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ficheros.aspx.cs" Inherits="Practica9.Ficheros" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Ficheros</h1>
    <form id="form1" runat="server">
    <p>
        Seleccione un archivo para verlo:
    </p>
        <asp:ListBox ID="lstArchivos" runat="server" AutoPostBack="true"
            OnSelectedIndexChanged="lstArchivos_SelectedIndexChanged"/>
        <asp:TextBox ID="txtInfoArchivo" ReadOnly="true" runat="server" TextMode="MultiLine" />
    <p>
        Contenido:
    </p>
    <div>
    <%--Recuerde que nuestro Textbox es multilínea para poder mostrar el contenido de un archivo--%>
        <asp:TextBox ID="txtContenido" runat="server" TextMode="MultiLine"/>
    </div>
    <div>
        <asp:Button ID="btnGuardar" Text = "Guardar" runat="server" OnClick="btnGuardar_OnClick" />
    </div>
    </form>
</body>
</html>
