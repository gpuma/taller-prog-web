<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AJAX.aspx.cs" Inherits="Practica9.AJAX" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <%-- ScriptManager es el control necesario para cualquier funcionalidad AJAX
         Debe haber uno por formulario --%>
    <asp:ScriptManager ID="scriptManager" runat="server"></asp:ScriptManager>
    
    <%-- Haremos uso de un cronómetro para refrescar la página automáticamente 
         Recordemos que Interval se expresa en milisegundos: 1000 ms = 1 seg--%>
    <asp:Timer ID="timer" runat="server" Interval="1000" />
    
    <%-- Para hacer que una porción de la página se actualice sin refrescar la
         página empleamos el control UpdatePanel. Modo Condicional quiere
         decir que habrá un evento o Trigger que haga que se actualice.--%>
    <asp:UpdatePanel ID="updatePanel" UpdateMode="Conditional"
        runat="server">
        <%-- En este caso, nuestro evento Trigger es el evento Tick de nuestro
             cronómetro --%>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="timer" EventName="Tick" />
        </Triggers>
        <ContentTemplate>
            <!--Ponemos el contenido que
             queremos que se actualice dentro del tag ContentTemplate-->
            <asp:Label ID="lblFechaActual"  runat="server" />
        </ContentTemplate>
    </asp:UpdatePanel>

    <h1>Ganador de la tinka</h1>
    <p>
        <asp:Label Text="Refresque la página para ver el nuevo ganador!" runat="server" />

        <%-- TODO: Actividad X: modifique el código para que el ganador se actualice 
             sin refrescar la página, al igual que la hora--%>
    </p>
    <asp:Label ID="lblGanador" runat="server" />
    <div>
    
    </div>
    </form>
</body>
</html>
