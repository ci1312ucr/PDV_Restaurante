using PDVRestaurante.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace PDVRestaurante.Objetos
{
    public static class PersonaDB
    {
        private static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["RestauranteConn"].ConnectionString;
        }

        private static string Tabla()
        {
            return "Persona";
        }

        private static string Columnas()
        {
            return "Cedula,TipoP";
        }

        private static string LlavePrincipal()
        {
            return "Cedula";
        }

        public static bool InsertarPersona(string cedula, char tipo)
        {
            using (var conn = new SqlConnection(ConnectionString()))
            {
                conn.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "INSERT INTO Persona (Cedula, TipoP) VALUES (@cedula, @tipo)";
                    command.Parameters.AddWithValue("@cedula", cedula);
                    command.Parameters.AddWithValue("@tipo", tipo);
                    command.ExecuteNonQuery();
                }
                conn.Close();
            }
            return true;
        }

        public static Persona ObtenerPersona(string cedula)
        {
            Persona persona = null;
            using (var conn = new SqlConnection(ConnectionString()))
            {
                conn.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT Cedula, TipoP FROM Persona WHERE Cedula = @cedula";
                    command.Parameters.AddWithValue("@cedula", cedula);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            persona = new Persona();
                            persona.Cedula = reader["Cedula"].ToString();
                            persona.TipoP = reader["TipoP"].ToString()[0];
                        }
                    }
                }
                conn.Close();
            }
            return persona;
        }

        public static List<Persona> ObtenerPersonas()
        {
            var personas = new List<Persona>();
            using (var conn = new SqlConnection(ConnectionString()))
            {
                conn.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT Cedula, TipoP FROM Persona";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var persona = new Persona();
                            persona.Cedula = reader["Cedula"].ToString();
                            persona.TipoP = reader["TipoP"].ToString()[0];
                            personas.Add(persona);
                        }
                    }
                }
                conn.Close();
            }
            return personas;
        }

    }
}
