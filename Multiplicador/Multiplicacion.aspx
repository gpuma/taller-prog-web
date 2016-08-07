<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Multiplicacion.aspx.cs" Inherits="Multiplicador.Multiplicacion" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Multiplicación</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Ingrese dos números para multiplicar:
        <asp:TextBox ID="txtNro1" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtNro2" runat="server"></asp:TextBox>
        <asp:Button ID="btnCalcular" runat="server" Text="Calcular" OnClick="btnCalcular_OnClick" />
    </div>
    <div>
        <%--nuestro label de resultado es vacío al comienzo--%>
        <asp:Label ID="lblResultado" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
