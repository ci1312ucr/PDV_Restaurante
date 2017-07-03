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
    public static class EmpleadoDB
    {
        private static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["RestauranteConn"].ConnectionString;
        }

        public static bool InsertarEmpleado(string cedula, string nombre1, string nombre2, string apellido1, string apellido2,
            char sexo, string estadoCivil, DateTime fechaNacimiento,string tipoEmpleado, decimal salario, int idSucursal, DateTime fechaInicio)
        {
            // inserta la persona física para mantener la integridad referencial
            PersonaFisicaDB.InsertarPersonaFisica(cedula, nombre1, nombre2, apellido1, apellido2, sexo, estadoCivil, fechaNacimiento);

            // inserta el empleado
            using (var conn = new SqlConnection(ConnectionString()))
            {
                conn.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "INSERT INTO Empleado (Cedula, Tipo, Salario, IdSucursal, FechaInicio) VALUES (@cedula, @tipoEmpleado, @salario, @idSucursal, @fechaInicio)";
                    command.Parameters.AddWithValue("@cedula", cedula);
                    command.Parameters.AddWithValue("@tipoEmpleado", tipoEmpleado);
                    command.Parameters.AddWithValue("@salario", salario);
                    command.Parameters.AddWithValue("@idSucursal", idSucursal);
                    command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                    command.ExecuteNonQuery();
                }
                conn.Close();
            }
            return true;
        }
        public static Empleado ObtenerEmpleado(string cedula)
        {
            Empleado empleado = null;
            using (var conn = new SqlConnection(ConnectionString()))
            {
                conn.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conn;

                    command.CommandText = "SELECT CodPerFisica, Nombre1, Nombre2, Apellido1, Apellido2, Sexo, EstadoCivil, FechaNacimiento, " +
                    "TipoE, Salario, IdSucursal, FechaInicio " +
                    "FROM PersonaFisica a INNER JOIN Empleado b ON a.CodPerFisica = b.Cedula " +
                    "WHERE a.CodPerFisica = @cedula";

                    command.Parameters.AddWithValue("@cedula", cedula);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            empleado.Cedula = reader["CodPerFisica"].ToString();
                            empleado.Nombre1 = reader["Nombre1"].ToString();
                            empleado.Nombre2 = reader["Nombre2"].ToString();
                            empleado.Apellido1 = reader["Apellido1"].ToString();
                            empleado.Apellido2 = reader["Apellido2"].ToString();
                            empleado.Sexo = reader["Sexo"].ToString()[0];
                            empleado.EstadoCivil = reader["EstadoCivil"].ToString();
                            empleado.FechaNacimiento = (DateTime)reader["FechaNacimiento"];
                            empleado.TipoE = reader["TipoE"].ToString();
                            empleado.Salario = (decimal)reader["Salario"];
                            empleado.IdSucursal = (int)reader["IdSucursal"];
                            empleado.FechaInicio = (DateTime)reader["FechaInicio"];
                            empleado.TipoP = 'F';
                        }
                    }
                }
                conn.Close();
            }
            return empleado;
        }

        public static List<Empleado> ObtenerEmpleados()
        {
            var empleados = new List<Empleado>();
            using (var conn = new SqlConnection(ConnectionString()))
            {
                conn.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT CodPerFisica, Nombre1, Nombre2, Apellido1, Apellido2, Sexo, EstadoCivil, FechaNacimiento, " +
                    "TipoE, Salario, IdSucursal, FechaInicio " +
                    "FROM PersonaFisica a INNER JOIN Empleado b ON a.CodPerFisica = b.Cedula";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var empleado = new Empleado();
                            empleado.Cedula = reader["CodPerFisica"].ToString();
                            empleado.Nombre1 = reader["Nombre1"].ToString();
                            empleado.Nombre2 = reader["Nombre2"].ToString();
                            empleado.Apellido1 = reader["Apellido1"].ToString();
                            empleado.Apellido2 = reader["Apellido2"].ToString();
                            empleado.Sexo = reader["Sexo"].ToString()[0];
                            empleado.EstadoCivil = reader["EstadoCivil"].ToString();
                            empleado.FechaNacimiento = (DateTime)reader["FechaNacimiento"];
                            empleado.TipoE = reader["TipoE"].ToString();
                            empleado.Salario = (decimal)reader["Salario"];
                            empleado.IdSucursal = (int)reader["IdSucursal"];
                            empleado.FechaInicio = (DateTime)reader["FechaInicio"];
                            empleado.TipoP = 'F';

                            empleados.Add(empleado);
                        }
                    }
                }
                conn.Close();
            }
            return empleados;
        }
    }
}
