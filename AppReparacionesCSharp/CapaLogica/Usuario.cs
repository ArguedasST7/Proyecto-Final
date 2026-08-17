using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace AppReparacionesCSharp.CapaLogica
{
    public class Usuario
    {
        public static string Nombre { get; set; }

        // LOGIN
        public static int ValidarUsuario(string correo, string clave)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand("ValidarLogin", conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@CorreoElectronico", correo);
                comando.Parameters.AddWithValue("@Clave", clave);

                conexion.Open();

                using (SqlDataReader registro = comando.ExecuteReader())
                {
                    if (registro.Read())
                    {
                        Nombre = registro["Nombre"].ToString();

                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        // INGRESAR USUARIO
        public static void IngresarUsuario(string nombre, string correo, string telefono, string clave)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand("IngresarUsuario", conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@CorreoElectronico", correo);
                comando.Parameters.AddWithValue("@Telefono", telefono);
                comando.Parameters.AddWithValue("@Clave", clave);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }

        // CONSULTAR USUARIO
        public static DataTable ConsultarUsuario(int usuarioID)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand("ConsultarUsuario", conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@UsuarioID", usuarioID);

                using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                {
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    return tabla;
                }
            }
        }

        // ACTUALIZAR USUARIO
        public static void ActualizarUsuario(int usuarioID, string nombre, string correo, string telefono, string clave)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand("ActualizarUsuario", conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@UsuarioID", usuarioID);
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@CorreoElectronico", correo);
                comando.Parameters.AddWithValue("@Telefono", telefono);
                comando.Parameters.AddWithValue("@Clave", clave);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }

        // BORRAR USUARIO
        public static void BorrarUsuario(int usuarioID)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand("BorrarUsuario", conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@UsuarioID", usuarioID);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }

        // LISTAR USUARIOS
        public static DataTable ListarUsuarios()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand("ListarUsuarios", conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;

                using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                {
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    return tabla;
                }
            }
        }
    }
}