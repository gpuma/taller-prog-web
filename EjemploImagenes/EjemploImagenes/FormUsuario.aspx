<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormUsuario.aspx.cs" Inherits="EjemploImagenes.FormUsuario" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Nombre <asp:TextBox ID="txtNombre" runat="server" />
    </div>
    <div>
        Apellido <asp:TextBox ID="txtApellido" runat="server" />
    </div>
    <div>
        <input type='file' id="imgEntrada"  runat="server"
         onchange="document.getElementById('imgPreview').src = window.URL.createObjectURL(this.files[0])" />
    </div>
    <div>
        <%--Esta es para cuando se sube la imagen--%>
        <img id="imgPreview" src="#" alt="Tu imagen"/>
    </div>
    <div>
        <%--Esta es para cuando se muestra la imagen ya guardada en el servidor--%>
        <img id="imgUsuario" runat="server"/>
    </div>
    <div>
        <asp:Button ID="btnGuardar" Text="Guardar" OnClick="btnGuardar_Click" runat="server" />
    </div>
    </form>
</body>
</html>
