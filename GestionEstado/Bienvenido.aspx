<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bienvenido.aspx.cs" Inherits="GestionEstado.Bienvenido" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h3>Hola, este es un "Hola mundo" en HTML</h3>
    <asp:Label ID="lblHTML" Text="Su codigo HTML debería mostrarse en este label" runat="server"/>
    </div>
    <div>
    <asp:Button ID="btnIr" Text="Ir a otra página" runat="server" 
            onclick="btnIr_Click" />
    </div>
    </form>
</body>
</html>
