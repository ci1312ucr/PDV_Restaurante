using PDVRestaurante.Ayudantes;
using PDVRestaurante.Constantes;
using PDVRestaurante.Objetos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.BaseDatos
{
    public static class TablaEmpleado
    {
        private static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["RestauranteConn"].ConnectionString;
        }

        private static string Tabla()
        {
            return "Empleado";
        }

        private static string TablaEmpleadoPersona()
        {
            return "Empleado e INNER JOIN PersonaFisica p ON p.CodPerFisica = e.Cedula INNER JOIN Sucursal s ON s.IdSucursal = e.IdSucursal";
        }

        private static string Columnas()
        {
            return "Cedula,TipoE,Salario,IdSucursal,FechaInicio";
        }
        private static string ColumnasEmpleadoPersona()
        {
            return "CodPerFisica,Nombre1,Nombre2,Apellido1,Apellido2,Sexo,EstadoCivil,FechaNacimiento,TipoE,Salario,e.IdSucursal,Detalle,e.FechaInicio";
        }

        private static string LlavePrincipal()
        {
            return "Cedula";
        }

        public static bool InsertarEmpleado(params object[] parametros)
        {
            if (parametros.Count() == Columnas().Split(',').Count())
            {
                InterpreteSQL.Insertar(ConnectionString(), Tabla(), Columnas(), parametros);
            }
            return true;
        }

        public static bool ModificarEmpleado(string cedula, params object[] parametros)
        {
            if (parametros.Count() == Columnas().Split(',').Count())
            {
                InterpreteSQL.Modificar(ConnectionString(), Tabla(), Columnas(), LlavePrincipal(), cedula, parametros);
            }
            return true;
        }

        public static Empleado ObtenerEmpleado(string cedula)
        {
            Empleado empleado = null;
            var dataSet = InterpreteSQL.Obtener(ConnectionString(), TablaEmpleadoPersona(), ColumnasEmpleadoPersona(), "p.CodPerFisica", cedula, CriterioSQL.IgualA);

            if (dataSet.Tables.Count > 0)
            {
                try
                {
                    var dataRow = dataSet.Tables[0].Rows[0];
                    empleado = new Empleado();
                    empleado.Cedula = dataRow["CodPerFisica"].ToString();
                    empleado.Nombre1 = dataRow["Nombre1"].ToString();
                    empleado.Nombre2 = dataRow["Nombre2"] == DBNull.Value ? "" : dataRow["Nombre2"].ToString();
                    empleado.Apellido1 = dataRow["Apellido1"].ToString();
                    empleado.Apellido2 = dataRow["Apellido2"] == DBNull.Value ? "" : dataRow["Apellido2"].ToString();
                    empleado.Sexo = dataRow["Sexo"].ToString()[0];
                    empleado.EstadoCivil = dataRow["EstadoCivil"] == DBNull.Value ? "" : dataRow["EstadoCivil"].ToString();
                    empleado.FechaNacimiento = (DateTime)dataRow["FechaNacimiento"];
                    empleado.TipoE = dataRow["TipoE"].ToString();
                    empleado.Salario = (decimal)dataRow["Salario"];
                    empleado.IdSucursal = (int)dataRow["IdSucursal"];
                    empleado.NombreSucursal = dataRow["Detalle"] == DBNull.Value ? "" : dataRow["Detalle"].ToString();
                    empleado.FechaInicio = (DateTime)dataRow["FechaInicio"];
                    empleado.TipoP = 'F';
                }
                catch (Exception ex)
                {
                    ManejoExcepciones.LogearExcepcion(ex);
                }
            }
            return empleado;
        }

        public static List<Empleado> ObtenerEmpleados(string columnasFiltro = null, string valoresFiltro = null, string criteriosFiltro = null)
        {
            var empleados = new List<Empleado>();
            var dataSet = InterpreteSQL.Obtener(ConnectionString(), TablaEmpleadoPersona(), ColumnasEmpleadoPersona(), columnasFiltro, valoresFiltro, criteriosFiltro);

            if (dataSet.Tables.Count > 0)
            {
                try
                {
                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        var empleado = new Empleado();
                        empleado.Cedula = row["CodPerFisica"].ToString();
                        empleado.Nombre1 = row["Nombre1"].ToString();
                        empleado.Nombre2 = row["Nombre2"] == DBNull.Value ? "" : row["Nombre2"].ToString();
                        empleado.Apellido1 = row["Apellido1"].ToString();
                        empleado.Apellido2 = row["Apellido2"] == DBNull.Value ? "" : row["Apellido2"].ToString();
                        empleado.Sexo = row["Sexo"].ToString()[0];
                        empleado.EstadoCivil = row["EstadoCivil"] == DBNull.Value ? "" : row["EstadoCivil"].ToString();
                        empleado.FechaNacimiento = (DateTime)row["FechaNacimiento"];
                        empleado.TipoE = row["TipoE"].ToString();
                        empleado.Salario = (decimal)row["Salario"];
                        empleado.IdSucursal = (int)row["IdSucursal"];
                        empleado.NombreSucursal = row["Detalle"] == DBNull.Value ? "" : row["Detalle"].ToString();
                        empleado.FechaInicio = (DateTime)row["FechaInicio"];
                        empleado.TipoP = 'F';
                        empleados.Add(empleado);
                    }
                }
                catch (Exception ex)
                {
                    ManejoExcepciones.LogearExcepcion(ex);
                }
            }
            return empleados;
        }
    }
}
