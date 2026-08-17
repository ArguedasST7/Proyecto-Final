<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AppReparacionesCSharp.CapaVistas.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Iniciar Sesión</title>

    <style>
        body {
            font-family: Arial;
            background-color: #1d2939;
            margin: 0;
            padding: 0;
        }

        .login {
            width: 350px;
            margin: 120px auto;
            background-color: white;
            padding: 35px;
            border-radius: 10px;
            text-align: center;
        }

        .login h1 {
            color: #1266f1;
        }

        .campo {
            width: 90%;
            padding: 10px;
            margin: 8px;
        }

        .boton {
            background-color: #00a878;
            color: white;
            border: none;
            padding: 10px 25px;
            cursor: pointer;
            margin-top: 10px;
        }

        .mensaje {
            color: red;
            margin-top: 15px;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">

        <div class="login">

            <h1>Sistema de Reparaciones</h1>

            <h2>Iniciar Sesión</h2>

            <asp:TextBox ID="txtCorreo" runat="server"
                CssClass="campo"
                placeholder="Correo electrónico">
            </asp:TextBox>

            <asp:TextBox ID="txtClave" runat="server"
                CssClass="campo"
                TextMode="Password"
                placeholder="Contraseña">
            </asp:TextBox>

            <br />

            <asp:Button ID="btnIngresar" runat="server"
                Text="Ingresar"
                CssClass="boton"
                OnClick="btnIngresar_Click" />

            <br />

            <asp:Label ID="lblMensaje" runat="server"
                CssClass="mensaje">
            </asp:Label>

        </div>

    </form>
</body>
</html>