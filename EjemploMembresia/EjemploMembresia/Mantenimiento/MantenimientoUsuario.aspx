<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MantenimientoUsuario.aspx.cs" Inherits="EjemploMembresia.Mantenimiento.MantenimientoUsuario" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mantenimiento Usuario</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Creación usuario</h1>
        <p>
        DNI <asp:TextBox ID="txtDNI" runat="server" />
        </p>
        <p>
        Nombre de usuario <asp:TextBox ID="txtNombreUsuario" runat="server" />
        </p>
        <p>
        Contraseña <asp:TextBox ID="txtContraseña" runat="server" />
        </p>
        <p>
        Nombres <asp:TextBox ID="txtNombres" runat="server" />
        </p>
        <p>
        Apellidos <asp:TextBox ID="txtApellidos" runat="server" />
        </p>
        <p>
        Telefono <asp:TextBox ID="txtTelefono" runat="server" />
        </p>
        <p>
        Rol <asp:DropDownList ID="drpRol" runat="server" />
        </p>
        <p>
        <asp:Button ID="btnCrearUsuario" Text="Crear usuario" runat="server" 
                onclick="btnCrearUsuario_Click" />
        </p>
    </div>
    </form>
</body>
</html>
