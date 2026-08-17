<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AppReparacionesCSharp.CapaVistas.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" type="text/css" href="../css/Estilo.css?v=999" />
    <title>Sistema de Reparaciones</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <ul>
                    <li><a class="active" href="/CapaVistas/Default.aspx">Home</a></li>
                    <li><a href="/CapaVistas/Equipos.aspx">Equipos</a></li>
                    <li><a href="/CapaVistas/Usuarios.aspx">Usuarios</a></li>
                    <li><a href="/CapaVistas/Tecnicos.aspx">Técnicos</a></li>
                    </ul>
            </ul>
        </div>
        <div class="contenedor">

    <h1>Sistema de Reparaciones</h1>

    <h2 style="text-align:center;">Bienvenido</h2>

    <p style="text-align:center;">
        Este sistema permite administrar la información de:
    </p>

    <br />

    <h3>👤 Usuarios</h3>
    <h3>💻 Equipos</h3>
    <h3>🛠 Técnicos</h3>

    <br />

    <p style="text-align:center;">
        Universidad Hispanoamericana<br />
        Programación II
    </p>

</div>
    </form>
</body>
</html>
