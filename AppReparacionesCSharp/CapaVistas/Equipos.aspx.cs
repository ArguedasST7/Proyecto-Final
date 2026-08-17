using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace AppReparacionesCSharp.CapaVistas
{
    public partial class Equipos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }


        protected void LlenarGrid()
        {
            string bd = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(bd))
            using (SqlCommand cmd = new SqlCommand("SELECT EquipoID, TipoEquipo, Modelo, UsuarioID FROM Equipos", con))
            {
                con.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    GridView1.DataSource = rdr;
                    GridView1.DataBind();
                }
            }
        }


        protected void consultarconfiltro()
        {
            string bd = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            using (SqlConnection con = new SqlConnection(bd))
            using (SqlCommand cmd = new SqlCommand("SELECT EquipoID, TipoEquipo, Modelo, UsuarioID FROM Equipos WHERE EquipoID = @codigo", con))
            {
                cmd.Parameters.AddWithValue("@codigo", txtcodigo.Text);

                con.Open();

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    GridView1.DataSource = rdr;
                    GridView1.DataBind();
                }
            }
        }

        protected void IngresarEquipos()
        {
            string bd = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            using (SqlConnection con = new SqlConnection(bd))
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Equipos (TipoEquipo, Modelo, UsuarioID) VALUES (@tipo, @modelo, @usuario)", con))
            {
                cmd.Parameters.AddWithValue("@tipo", txtnombre.Text);
                cmd.Parameters.AddWithValue("@modelo", txtmodelo.Text);
                cmd.Parameters.AddWithValue("@usuario", txtusuario.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }



        protected void BorrarEquipos()
        {
            string bd = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            using (SqlConnection con = new SqlConnection(bd))
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Equipos WHERE EquipoID = @codigo", con))
            {
                cmd.Parameters.AddWithValue("@codigo", txtcodigo.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            
            }

             LlenarGrid();
        }


        protected void ActualizarEquipos()
        {
            string bd = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            using (SqlConnection con = new SqlConnection(bd))
            using (SqlCommand cmd = new SqlCommand("UPDATE Equipos SET TipoEquipo=@tipo, Modelo=@modelo, UsuarioID=@usuario WHERE EquipoID=@codigo", con))
            {
                cmd.Parameters.AddWithValue("@codigo", txtcodigo.Text);
                cmd.Parameters.AddWithValue("@tipo", txtnombre.Text);
                cmd.Parameters.AddWithValue("@modelo", txtmodelo.Text);
                cmd.Parameters.AddWithValue("@usuario", txtusuario.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            LlenarGrid();
        }




        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            IngresarEquipos();
            LlenarGrid();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            BorrarEquipos();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarEquipos();
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            consultarconfiltro();
        }
    }
}