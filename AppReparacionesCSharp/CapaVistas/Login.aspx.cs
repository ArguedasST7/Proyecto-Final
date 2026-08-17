using System;
using System.Web.UI;

namespace AppReparacionesCSharp.CapaVistas
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text.Trim();
            string clave = txtClave.Text.Trim();

            if (correo == "" || clave == "")
            {
                lblMensaje.Text = "Debe ingresar el correo y la clave.";
                return;
            }

            int resultado = CapaLogica.Usuario.ValidarUsuario(correo, clave);

            if (resultado == 1)
            {
                Session["Nombre"] = CapaLogica.Usuario.Nombre;

                Response.Redirect("Default.aspx");
            }
            else
            {
                lblMensaje.Text = "Correo o clave incorrectos.";
            }
        }
    }
}