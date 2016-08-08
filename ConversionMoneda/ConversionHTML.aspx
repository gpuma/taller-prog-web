<%--
Convertidor de soles a dólares que utiliza controles HTML genéricos
Autor: Gustavo H. Puma Tejada
--%>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConversionHTML.aspx.cs" Inherits="ConversionMoneda.ConversionHTML" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Conversión con controles HTML genéricos</title>
    <h1>Conversión con controles HTML genéricos</h1>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Convertir
        <input type="text" id="txtSoles" runat="server"/>
        Soles a Dólares
        <%--usamos el evento ServerClick porque cuando el control
        es del tipo HTML genérico, su evento click solo funciona en el lado del cliente
        y lo que queremos es que al hacer clic vaya al servidor (Postback)
        ServerClick está diseñado para eso--%>
        <input type="submit" id="btnOk" value="OK" runat="server"
        onserverclick="btnOk_ServerClick"/>
    </div>
    <div style="font-weight: bold" id="Resultado" runat="server"></div>
    </form>
</body>
</html>
