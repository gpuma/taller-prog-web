<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Practica4.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Nombre de usuario: <asp:TextBox ID="txtNomUsuario" runat="server"/>
    </div>
    <div>
    Contraseña: <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"/>
    </div>
    <div>
    <asp:Button ID="btnLogin" Text = "Iniciar sesión" runat="server" 
            onclick="btnLogin_Click" />
    </div>
    </form>
</body>
</html>
