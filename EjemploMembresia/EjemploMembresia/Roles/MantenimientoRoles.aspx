<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MantenimientoRoles.aspx.cs" Inherits="EjemploMembresia.MantenimientoRoles" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mantenimiento Roles</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Creación de rol</h1>
        Nombre de Rol <asp:TextBox ID="txtNombreRol" runat="server" />
        <asp:Button ID="btnCrearRol" Text="Crear rol" runat="server" 
            onclick="btnCrearRol_Click" />
    </div>
    </form>
</body>
</html>
