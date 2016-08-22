<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearUsuario.aspx.cs" Inherits="Practica4.CrearUsuario" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Nuevo usuario</title>
</head>
<body>
    <form id="form1" runat="server">
    <%--TODO: Actividad 1 - Formulario de creación de usuario
    El nombre lo dice, este formulario servirá para registrar
    un nuevo usuario en un sistema X. En esta actividad
    hará uso de, además de los controles que ya conoce, los
    controles de validación (Revise la pestaña Validation a la izq.)
    
    - Los campos que deberá incluir son los siguientes (TextBox):
        * Nombre de usuario -- máximo 10 caracteres
        * Contraseña -- máximo 10 caracteres
        * Confirmar contraseña -- igual que contraseña
        * Nombres -- máximo 25 caracteres
        * Apellidos -- máximo 25 caracteres
        * Correo electrónico
        * Nro de celular -- máximo 9 caracteres, solo números
    
    - Deberá validar lo siguiente:
        * Todos los campos son requeridos (RequiredFieldValidator)
        * Deberá comparar que lo ingresado en ambos campos
          de contraseña sea igual (CompareValidator)
        * Para limitar el número de caracteres, revise la propiedad
          'MaxLength' de TextBox
        * Deberá validar que el número telefónico solo contenga
          números (RegularExpressionValidator). Use la siguiente
          expresión regular: "[0-9][0-9]+" (sin comillas)
        * Deberá validar que el correo electrónico tenga un formato
          válido (RegularExpressionValidator). Use la siguiente
          expresión regular: ".+[@].+" (sin comillas)

    - Luego de terminar esta parte pase al archivo Usuario.cs

    - TIPS:
        * No se olvide de indicar un Mensaje de Error en cada control
          Validator. Use la propiedad ErrorMessage
        * Recuerde que todo control del tipo Validator debe indicar
          el nombre del control que valida en su propiedad ControlToValidate
        * La expresión regular de un RegularExpressionValidator
          se indica en la propiedad ValidationExpression de dicho control--%>
    
    <%--TODO: AQUÍ VA SU CÓDIGO--%>
    <asp:Button ID="btnCrearUsuario" Text="Crear Usuario" OnClick="btnCrearUsuario_Click" runat="server" />
    </form>
</body>
</html>
