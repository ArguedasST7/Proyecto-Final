using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppReparacionesCSharp.CapaVistas
{
    public partial class Tecnicos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        protected void LlenarGrid()
        {
            string bd = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(bd))
            using (SqlCommand cmd = new SqlCommand("SELECT TecnicoID, Nombre, Especialidad FROM Tecnicos", con))
            {
                con.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    GridView1.DataSource = rdr;
                    GridView1.DataBind();
                }
            }
        }

        protected void IngresarReservacion()
        {
            string bd = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(bd))
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Tecnicos (Nombre, Especialidad) VALUES (@nombre, @especialidad)", con))
            {
                cmd.Parameters.AddWithValue("@nombre", txtnombre.Text);
                cmd.Parameters.AddWithValue("@especialidad", txtespecialidad.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        protected void ConsultarReservacion()
        {
            string bd = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(bd))
            using (SqlCommand cmd = new SqlCommand("SELECT TecnicoID, Nombre, Especialidad FROM Tecnicos WHERE TecnicoID = @codigo", con))
            {
                cmd.Parameters.AddWithValue("@codigo", txttecnico.Text);

                con.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    if (rdr.Read())
                    {
                        txttecnico.Text = rdr["TecnicoID"].ToString();
                        txtnombre.Text = rdr["Nombre"].ToString();
                        txtespecialidad.Text = rdr["Especialidad"].ToString();
            
                    }
                }
            }
        }

        protected void BorrarReservacion()
        {
            string bd = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(bd))
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Tecnicos WHERE TecnicoID = @codigo", con))
            {
                cmd.Parameters.AddWithValue("@codigo", txttecnico.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            LlenarGrid();
        }

        protected void ActualizarReservacion()
        {
            string bd = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(bd))
            using (SqlCommand cmd = new SqlCommand("UPDATE Tecnicos SET Nombre = @nombre, Especialidad = @especialidad WHERE TecnicoID = @codigo", con))
            {
                cmd.Parameters.AddWithValue("@codigo", txttecnico.Text);
                cmd.Parameters.AddWithValue("@nombre", txtnombre.Text);
                cmd.Parameters.AddWithValue("@especialidad", txtespecialidad.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            LlenarGrid();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            IngresarReservacion();
            LlenarGrid();
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultarReservacion();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            BorrarReservacion();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarReservacion();
        }
    }
}