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

        public static bool InsertarEmpleado(string cedula, string tipoEmpleado, decimal salario, int idSucursal, DateTime fechaInicio)
        {
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
                    command.CommandText = "SELECT Cedula, Tipo, Salario, IdSucursal, FechaInicio FROM Empleado WHERE Cedula = @cedula";
                    command.Parameters.AddWithValue("@cedula", cedula);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            empleado = new Empleado();
                            empleado.Cedula = reader["Cedula"].ToString();
                            empleado.Tipo = reader["Tipo"].ToString();
                            empleado.Salario = (decimal)reader["Salario"];
                            empleado.IdSucursal = (int)reader["IdSucursal"];
                            empleado.FechaInicio = (DateTime)reader["FechaInicio"];
                        }
                    }
                }
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
                    command.CommandText = "SELECT Cedula, Tipo, Salario, IdSucursal, FechaInicio FROM Empleado";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var empleado = new Empleado();
                            empleado.Cedula = reader["Cedula"].ToString();
                            empleado.Tipo = reader["Tipo"].ToString();
                            empleado.Salario = (decimal)reader["Salario"];
                            empleado.IdSucursal = (int)reader["IdSucursal"];
                            empleado.FechaInicio = (DateTime)reader["FechaInicio"];

                            empleados.Add(empleado);
                        }
                    }
                }
            }
            return empleados;
        }
    }
}
