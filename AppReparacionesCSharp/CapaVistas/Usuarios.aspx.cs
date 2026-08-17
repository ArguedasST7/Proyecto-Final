using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace AppReparacionesCSharp.CapaVistas
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        protected void LlenarGrid()
        {
            DataTable tabla = CapaLogica.Usuario.ListarUsuarios();

            GridView1.DataSource = tabla;
            GridView1.DataBind();
        }

        protected void IngresarUsuario()
        {
            CapaLogica.Usuario.IngresarUsuario(
                txtnombre.Text,
                txtcorreo.Text,
                txttelefono.Text,
                txtclave.Text
            );
        }


        protected void ConsultarUsuario()
        {
            int usuarioID = Convert.ToInt32(txtusuario.Text);

            DataTable tabla = CapaLogica.Usuario.ConsultarUsuario(usuarioID);

            if (tabla.Rows.Count > 0)
            {
                txtusuario.Text = tabla.Rows[0]["UsuarioID"].ToString();
                txtnombre.Text = tabla.Rows[0]["Nombre"].ToString();
                txttelefono.Text = tabla.Rows[0]["Telefono"].ToString();
                txtcorreo.Text = tabla.Rows[0]["CorreoElectronico"].ToString();
                txtclave.Text = tabla.Rows[0]["Clave"].ToString();
            }
        }



        protected void BorrarUsuario()
        {
            int usuarioID = Convert.ToInt32(txtusuario.Text);

            CapaLogica.Usuario.BorrarUsuario(usuarioID);

            LlenarGrid();
        }


        protected void ActualizarUsuario()
        {
            int usuarioID = Convert.ToInt32(txtusuario.Text);

            CapaLogica.Usuario.ActualizarUsuario(
                usuarioID,
                txtnombre.Text,
                txtcorreo.Text,
                txttelefono.Text,
                txtclave.Text
            );

            LlenarGrid();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            IngresarUsuario();
            LlenarGrid();
        }

        protected void btnConsultar_Click(Object sender, EventArgs e)
        {
            ConsultarUsuario();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            BorrarUsuario();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarUsuario();
        }
    }
}