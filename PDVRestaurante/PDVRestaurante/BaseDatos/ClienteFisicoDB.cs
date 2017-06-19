using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using PDVRestaurante.Objetos;

namespace PDVRestaurante.BaseDatos
{
    public static class ClienteFisicoDB
    {
        private static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["RestauranteConn"].ConnectionString;
        }

        public static bool InsertarCliente(string cedula, string nombre1, string nombre2, string ape1, string ape2, char sexo, string estCivil,
            DateTime fechaNacimiento, bool frecuente)
        {
            // inserta cliente como persona fisica para mantener integridad referencial
            PersonaFisicaDB.InsertarPersonaFisica(cedula, nombre1, nombre2, ape1, ape2, sexo, estCivil, fechaNacimiento);

            using (var conn = new SqlConnection(ConnectionString()))
            {
                conn.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "INSERT INTO Cliente (Cedula,Frecuente) VALUES (@cedula, @freceunte)";
                    command.Parameters.AddWithValue("@cedula", cedula);
                    command.Parameters.AddWithValue("@frecuente", frecuente);
                    command.ExecuteNonQuery();
                }
                conn.Close();
            }
            return true;
        }

        public static ClienteFisico ObtenerCliente(string cedula)
        {
            ClienteFisico cliente = null;
            using (var conn = new SqlConnection(ConnectionString()))
            {
                conn.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT Cedula, Tipo, Salario, IdSucursal, FechaInicio FROM Empleado WHERE Cedula = @cedula";
                    command.Parameters.AddWithValue("@cedula", cedula);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cliente = new ClienteFisico();
                            cliente.Cedula = reader["Cedula"].ToString();
                            cliente.Frecuente = (bool)reader["Frecuente"];
                        }
                    }
                }
                conn.Close();
            }
            return cliente;
        }

        public static List<ClienteFisico> ObtenerClientes()
        {
            var clientes= new List<ClienteFisico>();
            using (var conn = new SqlConnection(ConnectionString()))
            {
                conn.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT Cedula, Tipo, Salario, IdSucursal, FechaInicio FROM Empleado";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var cliente = new ClienteFisico();
                            cliente.Cedula = reader["Cedula"].ToString();
                            cliente.Frecuente = (bool)reader["Frecuente"];

                            clientes.Add(cliente);
                        }
                    }
                }
                conn.Close();
            }
            return clientes;
        }
    }
}
