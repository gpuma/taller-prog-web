<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MatrixView.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:GridView ID="grdMatriz" runat="server" AutoGenerateColumns="false">
    <Columns>
        <asp:TemplateField HeaderText="hola">
            <ItemTemplate>
                <asp:TextBox Text='<%# Eval("hola") %>' runat="server"/>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
    </asp:GridView>
    </div>
    </form>
</body>
</html>
