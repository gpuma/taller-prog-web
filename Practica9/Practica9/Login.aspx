<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Practica9.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Login ID="ctlLogin" DisplayRememberMe="false" runat="server" OnAuthenticate="ctlLogin_Authenticate" />
    </div>
    </form>
</body>
</html>
