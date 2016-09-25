<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormPais.aspx.cs" Inherits="Practica8.FormPais" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Práctica 8</title>
</head>
<body>
    <form id="form1" runat="server">
    <h1>Paises</h1>
    <%--Panel es un contenedor de controles. Podemos ocultar o mostrar todos los controles
    ----contenidos dentro de el panel--%>
    <asp:Panel ID="pnlPais" runat="server">
    <div>
        Id País: <asp:TextBox ID="txtIdPais" runat="server" />
    </div>
    <div>
        Nombre País: <asp:TextBox ID="txtNomPais" runat="server" />
    </div>
    <div>
        Producto Bruto Interno <asp:TextBox ID="txtPBI" runat="server" />
    </div>
    <div>
        <asp:Button ID="btnAgregarPais" Text="Agregar País" runat="server" />
    </div>
    <div>
        <asp:Button ID="btnActualizarPais" Text="Actualizar País" runat="server" 
            onclick="btnActualizarPais_Click" />
    </div>
    <div>
        <asp:Button ID="btnEliminar" Text="ELIMINAR" BackColor="Red" ForeColor="White"
         OnClick="btnEliminar_Click" runat="server" />
    </div>
    </asp:Panel>

    </form>
</body>
</html>
