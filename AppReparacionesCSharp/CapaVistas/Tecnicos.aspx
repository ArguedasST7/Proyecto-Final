<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tecnicos.aspx.cs" Inherits="AppReparacionesCSharp.CapaVistas.Tecnicos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link runat="server" rel="stylesheet" href="~/css/Estilo.css?v=999" />
    <title>Técnicos</title>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <ul>
                <li><a class="active" href="/CapaVistas/Default.aspx">Home</a></li>
                <li><a href="/CapaVistas/Equipos.aspx">Equipos</a></li>
                <li><a href="/CapaVistas/Usuarios.aspx">Usuarios</a></li>
                <li><a href="/CapaVistas/Tecnicos.aspx">Tecnicos</a></li>
            </ul>
        </div>

        <div class="contenedor">

            <div>
                <h1>Técnicos</h1>
            </div>

            <div>
                <table>

                    <tr>
                        <td>ID Técnico</td>
                        <td>
                            <asp:TextBox ID="txttecnico" runat="server"></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td>Nombre</td>
                        <td>
                            <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td>Especialidad</td>
                        <td>
                            <asp:TextBox ID="txtespecialidad" runat="server"></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td>Teléfono</td>
                        <td>
                            <asp:TextBox ID="txttelefono" runat="server"></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td colspan="2">
                            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
                            <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" />
                            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
                            <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />
                        </td>
                    </tr>

                    <tr>
                        <td colspan="2">
                            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                        </td>
                    </tr>

                </table>
            </div>

        </div>

    </form>
</body>
</html>