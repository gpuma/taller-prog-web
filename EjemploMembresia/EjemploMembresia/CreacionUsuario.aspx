<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="CreacionUsuario.aspx.cs" Inherits="EjemploMembresia.CreacionUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<title>Mantenimiento Usuario</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
</asp:Content>
