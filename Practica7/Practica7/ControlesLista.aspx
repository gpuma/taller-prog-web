<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ControlesLista.aspx.cs" Inherits="Practica7.ControlesLista" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Prac7 - Controles Lista</title>
</head>
<body>
    <form id="form1" runat="server">
    
    <%-- En esta archivo no hay actividades pero lea el código y
         entiéndalo antes de proceder --%>

    <h1>Data Binding con Controles Lista</h1>
    <h2>Demo DropDownList</h2>
    <p>Seleccione un lenguaje de la lista:</p>
    <div>
        <asp:DropDownList ID="drpLenguajes" AutoPostBack="true" runat="server"
         OnSelectedIndexChanged="drpLenguajes_SelectedIndexChanged" />
    </div>
    
    <h2>Demo ListBox</h2>
    <p>Seleccione los lenguajes que conoce: </p>
    <div>
        <asp:ListBox ID="lstLengDisponibles" runat="server"/>
        
        <asp:Button ID="btnAgregar" Text=">>" runat="server" onclick="btnAgregar_Click" />
        <asp:Button ID="btnQuitar" Text="<<" runat="server" onclick="btnQuitar_Click" />
        
        <asp:ListBox ID="lstLengConocidos" runat="server"/>
    </div>

    <h2>Demo CheckBox</h2>
    <p>Seleccione los lenguajes que le interesan: </p>
    <div>
        <asp:CheckBoxList ID="chkLeng" runat="server" AutoPostBack="true"
            RepeatColumns="4" OnSelectedIndexChanged="chkLeng_SelectedIndexChanged" />
        <asp:Label ID="lblCheck" runat="server" />
    </div>
    </form>
</body>
</html>
