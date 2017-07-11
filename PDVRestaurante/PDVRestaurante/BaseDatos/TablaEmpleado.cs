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
            return "Cedula,Nombre1,Nombre2,Apellido1,Apellido2,Sexo,EstadoCivil,FechaNacimiento,TipoE,Salario,e.IdSucursal,Detalle as NombreSucursal,e.FechaInicio";
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
                empleado = Convertidor.DataSetAObjecto<Empleado>(dataSet).FirstOrDefault();
            }
            return empleado;
        }

        public static List<Empleado> ObtenerEmpleados(string columnasFiltro = null, string valoresFiltro = null, string criteriosFiltro = null)
        {
            var empleados = new List<Empleado>();
            var dataSet = InterpreteSQL.Obtener(ConnectionString(), TablaEmpleadoPersona(), ColumnasEmpleadoPersona(), columnasFiltro, valoresFiltro, criteriosFiltro);

            if (dataSet.Tables.Count > 0)
            {
                empleados = Convertidor.DataSetAObjecto<Empleado>(dataSet);
            }
            return empleados;
        }
    }
}
