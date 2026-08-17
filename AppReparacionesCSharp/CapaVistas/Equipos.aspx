<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Equipos.aspx.cs" Inherits="AppReparacionesCSharp.CapaVistas.Equipos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link runat="server" rel="stylesheet" href="~/css/Estilo.css?v=999" />
    <title>Equipos</title>
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
        </div>

        <div class="contenedor">

            <div>
                <h1>Equipos</h1>
            </div>

            <div>
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                <br />
            </div>

            <div>

                <asp:Label ID="lcodigo" runat="server" Text="Equipo ID"></asp:Label>
                <br />
                <asp:TextBox ID="txtcodigo" runat="server"></asp:TextBox>
                <br />

                <asp:Label ID="lnombre" runat="server" Text="Tipo de Equipo"></asp:Label>
                <br />
                <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
                <br />

                <asp:Label ID="lmodelo" runat="server" Text="Modelo"></asp:Label>
                <br />
                <asp:TextBox ID="txtmodelo" runat="server"></asp:TextBox>
                <br />

                <asp:Label ID="lusuario" runat="server" Text="Usuario ID"></asp:Label>
                <br />
                <asp:TextBox ID="txtusuario" runat="server"></asp:TextBox>
                <br />

            </div>

            <div>
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
                <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
                <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" />
            </div>

        </div>

    </form>
</body>
</html>