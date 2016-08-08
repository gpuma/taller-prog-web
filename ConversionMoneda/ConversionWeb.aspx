<%--
Convertidor de soles a dólares que utiliza controles Web ASP.NET
Autor: Gustavo H. Puma Tejada
--%>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConversionWeb.aspx.cs" Inherits="ConversionMoneda.ConversionWeb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Conversión con controles web ASP.NET</title>
    <h1>Conversión con controles web ASP.NET</h1>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Convertir
        <asp:TextBox ID="txtSoles" runat="server"/>
        Soles a Dólares
        <asp:Button ID="btnOk" Text="OK" runat="server"
        OnClick="btnOk_OnClick"/>
    </div>
    <div>
        <asp:Label ID="Resultado" Font-Bold=true runat="server" />
    </div>
    
    </form>
</body>
</html>
