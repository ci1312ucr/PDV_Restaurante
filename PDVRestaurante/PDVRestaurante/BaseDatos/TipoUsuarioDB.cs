using PDVRestaurante.Objetos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.BaseDatos
{
    public static class TipoUsuarioDB
    {
        private static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["RestauranteConn"].ConnectionString;
        }

        public static bool InsertarTipoUsuario(int tipoUsuarioId, string nombre)
        {
            using (var conn = new SqlConnection(ConnectionString()))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "INSERT INTO TipoUsuario (TipoUsuarioId, Nombre) VALUES (@tipoUsuarioId, @nombre)";
                    command.Parameters.AddWithValue("@tipoUsuarioId", tipoUsuarioId);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    conn.Open();
                    command.ExecuteNonQuery();
                }
            }
            return true;
        }
        public static TipoUsuario ObtenerTipoUsuario(int tipoUsuarioId)
        {
            TipoUsuario tipoUsuario = null;
            using (var conn = new SqlConnection(ConnectionString()))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT TipoUsuarioId, Nombre FROM TipoUsuario WHERE tipoUsuarioId = @tipoUsuarioId";
                    command.Parameters.AddWithValue("@tipoUsuarioId", tipoUsuarioId);
                    conn.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tipoUsuario = new TipoUsuario();
                            tipoUsuario.TipoUsuarioId = Convert.ToInt32(reader["TipoUsuarioId"]);
                            tipoUsuario.Nombre = reader["Nombre"].ToString();
                        }
                    }
                }
            }
            return tipoUsuario;
        }

        public static List<TipoUsuario> ObtenerTipoUsuarios()
        {
            var tipoUsuarioLista = new List<TipoUsuario>();
            using (var conn = new SqlConnection(ConnectionString()))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT TipoUsuarioId, Nombre FROM TipoUsuario";
                    conn.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var tipoUsuario = new TipoUsuario();
                            tipoUsuario.TipoUsuarioId = Convert.ToInt32(reader["TipoUsuarioId"]);
                            tipoUsuario.Nombre = reader["Nombre"].ToString();
                            tipoUsuarioLista.Add(tipoUsuario);
                        }
                    }
                }
            }
            return tipoUsuarioLista;
        }
    }
}
