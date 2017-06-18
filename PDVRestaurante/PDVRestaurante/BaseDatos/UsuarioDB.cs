using PDVRestaurante.Objetos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.BaseDatos
{
    public static class UsuarioDB
    {
        private static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["RestauranteConn"].ConnectionString;
        }

        public static bool InsertarUsuario(string nombre, string contrasena, string salt, string cedula, int IdTipoUsuario)
        {
            using (var conn = new SqlConnection(ConnectionString()))
            {
                conn.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "INSERT INTO Usuario (Nombre, Contrasena, Salt, IdEmpleado, IdTipoUsuario) VALUES (@nombre, @contrasena, @salt, @IdEmpleado, @IdTipoUsuario)";
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@contrasena", contrasena);
                    command.Parameters.AddWithValue("@salt", salt);
                    command.Parameters.AddWithValue("@IdEmpleado", cedula);
                    command.Parameters.AddWithValue("@IdTipoUsuario", IdTipoUsuario);
                    command.ExecuteNonQuery();
                }
            }
            return true;
        }
        public static Usuario ObtenerUsuario(string nombre)
        {
            Usuario usuario = null;
            using (var conn = new SqlConnection(ConnectionString()))
            {
                conn.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT Nombre, Contrasena, Salt, IdEmpleado, IdTipoUsuario FROM Usuario WHERE Nombre = @nombre";
                    command.Parameters.AddWithValue("@nombre", nombre);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new Usuario();
                            usuario.Nombre = reader["Nombre"].ToString();
                            usuario.Constrasena = reader["Contrasena"].ToString();
                            usuario.Salt = reader["Salt"].ToString();
                            usuario.IdEmpleado = reader["IdEmpleado"].ToString();
                            usuario.IdTipoUsuario = Convert.ToInt32(reader["IdTipoUsuario"]);
                        }
                    }
                }
            }
            return usuario;
        }

        public static List<Usuario> ObtenerUsuarios()
        {
            var usuarios = new List<Usuario>();
            using (var conn = new SqlConnection(ConnectionString()))
            {
                conn.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT Nombre, Cedula, IdTipoUsuario FROM Usuario";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var usuario = new Usuario();
                            usuario.Nombre = reader["Nombre"].ToString();
                            usuario.IdEmpleado = reader["Cedula"].ToString();
                            usuario.IdTipoUsuario = Convert.ToInt32(reader["IdTipoUsuario"]);
                            usuarios.Add(usuario);
                        }
                    }
                }
            }
            return usuarios;
        }
    }
}
