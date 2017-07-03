using PDVRestaurante.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace PDVRestaurante.BaseDatos
{
    public static class PersonaFisicaDB
    {
        private static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["RestauranteConn"].ConnectionString;
        }

        public static bool InsertarPersonaFisica(string cedula, string nombre1, string nombre2, string apellido1, string apellido2, 
            char sexo, string estadoCivil, DateTime fechaNacimiento)
        {
            // inserta la persona regular para mantener integridad referencial
            PersonaDB.InsertarPersona(cedula, 'F');

            // inserta la persona física
            using (var conn = new SqlConnection(ConnectionString()))
            {
                conn.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "INSERT INTO PersonaFisica (CodPerFisica,Nombre1,Nombre2,Apellido1,Apellido2,Sexo,EstadoCivil,FechaNacimiento) VALUES (@codPerFisica,@nombre1,@nombre2,@apellido1,@apellido2,@sexo,@estadoCivil,@fechaNacimiento)";
                    command.Parameters.AddWithValue("@codPerFisica", cedula);
                    command.Parameters.AddWithValue("@nombre1", nombre1);
                    command.Parameters.AddWithValue("@nombre2", nombre2);
                    command.Parameters.AddWithValue("@apellido1", apellido1);
                    command.Parameters.AddWithValue("@apellido2", apellido2);
                    command.Parameters.AddWithValue("@sexo", sexo);
                    command.Parameters.AddWithValue("@estadoCivil", estadoCivil);
                    command.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                    command.ExecuteNonQuery();
                }
                conn.Close();
            }
            return true;
        }

        public static PersonaFisica ObtenerPersonaFisica(string cedula)
        {
            PersonaFisica personaFisica = null;
            using (var conn = new SqlConnection(ConnectionString()))
            {
                conn.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT CodPerFisica,Nombre1,Nombre2,Apellido1,Apellido2,Sexo,EstadoCivil,FechaNacimiento  FROM PersonaFisica WHERE CodPerFisica = @codPerFisica";
                    command.Parameters.AddWithValue("@codPerFisica", cedula);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            personaFisica = new PersonaFisica();
                            personaFisica.Cedula = reader["CodPerFisica"].ToString();
                            personaFisica.Nombre1 = reader["Nombre1"].ToString();
                            personaFisica.Nombre2 = reader["Nombre2"].ToString();
                            personaFisica.Apellido1 = reader["Apellido1"].ToString();
                            personaFisica.Apellido2 = reader["Apellido2"].ToString();
                            personaFisica.Sexo = (char)reader["Sexo"];
                            personaFisica.EstadoCivil = reader["EstadoCivil"].ToString();
                            personaFisica.FechaNacimiento = (DateTime)reader["FechaNacimiento"];
                            personaFisica.TipoP = 'F';
                        }                 
                    }                     
                }                         
                conn.Close();
            }
            return personaFisica;
        }

        public static List<PersonaFisica> ObtenerPersonasFisicas()
        {
            var personasFisicas = new List<PersonaFisica>();
            using (var conn = new SqlConnection(ConnectionString()))
            {
                conn.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT CodPerFisica,Nombre1,Nombre2,Apellido1,Apellido2,Sexo,EstadoCivil,FechaNacimiento  FROM PersonaFisica";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var personaFisica = new PersonaFisica();
                            personaFisica.Cedula = reader["CodPerFisica"].ToString();
                            personaFisica.Nombre1 = reader["Nombre1"].ToString();
                            personaFisica.Nombre2 = reader["Nombre2"].ToString();
                            personaFisica.Apellido1 = reader["Apellido1"].ToString();
                            personaFisica.Apellido2 = reader["Apellido2"].ToString();
                            personaFisica.Sexo = (char)reader["Sexo"];
                            personaFisica.EstadoCivil = reader["EstadoCivil"].ToString();
                            personaFisica.FechaNacimiento = (DateTime)reader["FechaNacimiento"];
                            personaFisica.TipoP = 'F';

                            personasFisicas.Add(personaFisica);
                        }
                    }
                }
                conn.Close();
            }
            return personasFisicas;
        }

    }
}
