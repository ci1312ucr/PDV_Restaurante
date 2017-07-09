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
            return "PersonaFisica a INNER JOIN Empleado b ON a.CodPerFisica = b.Cedula";
        }

        private static string Columnas()
        {
            return "Cedula,TipoE,Salario,IdSucursal,FechaInicio";
        }
        private static string ColumnasEmpleadoPersona()
        {
            return "CodPerFisica,Nombre1,Nombre2,Apellido1,Apellido2,Sexo,EstadoCivil,FechaNacimiento,TipoE,Salario,IdSucursal,FechaInicio";
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
            var dataSet = InterpreteSQL.Obtener(ConnectionString(), TablaEmpleadoPersona(), ColumnasEmpleadoPersona(), "a.CodPerFisica", cedula, CriterioSQL.IgualA);

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
                    foreach (DataRow r in dataSet.Tables[0].Rows)
                    {
                        var empleado = new Empleado();
                        empleado.Cedula = r["CodPerFisica"].ToString();
                        empleado.Nombre1 = r["Nombre1"].ToString();
                        empleado.Nombre2 = r["Nombre2"] == DBNull.Value ? "" : r["Nombre2"].ToString();
                        empleado.Apellido1 = r["Apellido1"].ToString();
                        empleado.Apellido2 = r["Apellido2"] == DBNull.Value ? "" : r["Apellido2"].ToString();
                        empleado.Sexo = r["Sexo"].ToString()[0];
                        empleado.EstadoCivil = r["EstadoCivil"] == DBNull.Value ? "" : r["EstadoCivil"].ToString();
                        empleado.FechaNacimiento = (DateTime)r["FechaNacimiento"];
                        empleado.TipoE = r["TipoE"].ToString();
                        empleado.Salario = (decimal)r["Salario"];
                        empleado.IdSucursal = (int)r["IdSucursal"];
                        empleado.FechaInicio = (DateTime)r["FechaInicio"];
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
