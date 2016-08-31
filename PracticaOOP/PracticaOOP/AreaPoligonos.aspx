<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AreaPoligonos.aspx.cs" Inherits="PracticaOOP.AreaPoligonos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculador de áreas</title>
</head>
<body>
    <form id="form1" runat="server">
    <h1>Calculador de áreas</h1>
    <%--
        TODO: 10. Agregue los controles necesarios para poder cálcular las áreas
        de ambos objetos. Para un triángulo serían tres campos de texto para cada lado
        y para un rectángulo, dos, además de los controles para mostrar el resultado.
    --%>
    <h2>Área de un triángulo</h2>
    <div>
        Complete la interfaz necesaria
        <div>
        <asp:Button ID="btnAreaTriangulo" Text="Área Triángulo" runat="server" OnClick="btnAreaTriangulo_Click" />
        </div>
    </div>
    <h2>Área de un rectángulo</h2>
    <div>
        Complete la interfaz necesaria
        <div>
        <asp:Button ID="btnAreaRectangulo" Text="Área Rectángulo" runat="server" OnClick="btnAreaRectangulo_Click" />
        </div>
    </div>
    </form>
</body>
</html>
