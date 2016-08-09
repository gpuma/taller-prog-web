<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Convertidor.aspx.cs" Inherits="ConversionMoneda_v2.Convertidor" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Convertir:
        <asp:TextBox ID="txtSoles" runat="server"/>
        Soles a 
        <asp:DropDownList ID="drpMoneda" runat="server">
            <%--Utilizamos códigos (propiedad Value) para identificar
            cada moneda en el código de servidor, pero lo que mostramos
            al usuario es un texto más verboso--%>
            <asp:ListItem Value="EUR">Euro</asp:ListItem>
            <asp:ListItem Value="AUD">Dólar Australiano</asp:ListItem>
            <asp:ListItem Value="JPY">Yen Japonés</asp:ListItem>
            <asp:ListItem Value="THB">Baht Tailandés</asp:ListItem>
        </asp:DropDownList>
    </div>
    <div>
        <asp:Button ID="btnConvertir" OnClick="btnConvertir_OnClick" Text="Convertir" runat="server" />
    </div>
    <div>
        <asp:Label ID="lblResultado" Font-Bold="true" runat="server"/>
    </div>
    </form>
</body>
</html>
