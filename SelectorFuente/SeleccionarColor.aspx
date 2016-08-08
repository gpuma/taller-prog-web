<%--
Programa que cambia el color de un Label según sea seleccionado en el combo
Autor: Gustavo H. Puma Tejada
--%>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeleccionarColor.aspx.cs" Inherits="SelectorFuente.SeleccionarColor" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Selección de Color</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblMensaje" Text="Este es un mensaje de prueba!" runat="server" Font-Bold="True" Font-Size="X-Large" />
    </div>
    <div>
        Seleccione el color del mensaje
        <%--Si ponemos AutoPostBack = true entonces nuestro control
        generará un postback cuando cambiemos la opción seleccionada--%>
        <asp:DropDownList ID="drpColores" runat="server" AutoPostBack="true"
        OnSelectedIndexChanged="drpColores_OnSelectedIndexChanged">
            <asp:ListItem>Negro</asp:ListItem>
            <asp:ListItem>Rojo</asp:ListItem>
            <asp:ListItem>Azul</asp:ListItem>
        </asp:DropDownList>
    </div>
    </form>
</body>
</html>
