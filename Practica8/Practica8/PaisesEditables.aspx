<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaisesEditables.aspx.cs" Inherits="Practica8.PaisesEditables" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Países</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <%--DataKeyNames necesario para poder recuperar el id de la fila--%>
        <asp:GridView ID="grdPaises" AutoGenerateColumns="False" runat="server"
            OnRowUpdating="grdPaises_RowUpdating"
            OnRowEditing="grdPaises_RowEditing"
            OnRowCancelingEdit="grdPaises_RowCancelingEdit"
            DataKeyNames="id_pais">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <%-- podemos especificar un campo como solo lectura --%>
                <asp:BoundField HeaderText="id" DataField="id_pais" ReadOnly="true" Visible="false"/>
                <asp:BoundField HeaderText="Nombre" DataField="nom_pais" ReadOnly="true"/>
                <asp:BoundField HeaderText="PBI" DataField="pbi_pais" />
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
