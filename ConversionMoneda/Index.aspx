<%--
Página índice para nuestros dos tipos de convertidores
usa HTML puro ya que solo necesitamos hipervínculos
Autor: Gustavo H. Puma Tejada
--%>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ConversionMoneda.Index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <%--Una lista no ordenada con vínculos a nuestros Web Forms--%>
    <ul>
        <li><a href="ConversionHTML.aspx">Convertidor con controles HTML genéricos</a></li>
        <li><a href="ConversionWeb.aspx">Convertidor con controles web ASP.NET</a></li>
    </ul>
    </div>
    </form>
</body>
</html>
