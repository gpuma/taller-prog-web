<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ControlesComplejos.aspx.cs" Inherits="Practica7.ControlesComplejos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Prac7 - Controles Complejos</title>
</head>
<body>
    <form id="form1" runat="server">
    <h1>Demo GridView y ListView</h1>
    <h2>Inventario</h2>
    <div>
    <%--Vamos a especificar las columnas del GridView explícitamente para
        poder elegir exactamente qué mostramos y con qué formato
        Adicionalmente estamos convirtiendo el código del producto en un LinkButton
        para que cuando se haga click muestre el detalle del Producto. Para indicar
        el item que ha sido seleccionado también se aplica un estilo
        
        ANTES de continuar haga la Actividad 11 en el archivo code-behind--%>

        <asp:GridView ID="grdProductos" runat="server" AutoGenerateColumns="false"
            SelectedRowStyle-BackColor="Blue" SelectedRowStyle-ForeColor="White"
            OnSelectedIndexChanged="grdProductos_SelectedIndexChanged">
            <Columns>
                <asp:ButtonField ButtonType="Link" CommandName="Select"
                    HeaderText="Codigo" DataTextField="Codigo" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre"/>

                <%-- TODO: Actividad 12: añada los campos restantes de la clase Producto
                     Excepto el Proveedor, Descontinuado y Descripción--%>
                
                <%-- TODO: Actividad 13: Muestre solo la fecha para el campo FechaRegistro
                    TIP: Revise la propiedad DataFormatString y use el siguiente formato
                    "{0:dd/MM/yyyy}"--%>
                
                <%--TODO: PUNTO EXTRA: Muestre el monto Precio del producto en soles (e.g. S/.500.00)--%>
            </Columns>
        </asp:GridView>
    </div>
    <h2>Detalle del Inventario</h2>
    <div>
        <%--Lo ocultamos para que solo se muestre cuando se seleccione algún item
        en el GridView--%>
        <%--OJO: Los controles de este tipo por defecto auto generan columnas si no
            especificamos nada explícitamente--%>
        <asp:DetailsView ID="dtlProductos" Visible="false" runat="server"/>
    </div>
    </form>
</body>
</html>
