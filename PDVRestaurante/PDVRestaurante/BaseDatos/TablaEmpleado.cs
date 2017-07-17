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
            return "Cedula|TipoE|Salario|IdSucursal|FechaInicio";
        }
        private static string ColumnasEmpleadoPersona()
        {
            return "Cedula|Nombre1|Nombre2|Apellido1|Apellido2|Sexo|EstadoCivil|FechaNacimiento|TipoE|Salario|e.IdSucursal|Detalle as NombreSucursal|e.FechaInicio";
        }

        private static string LlavePrincipal()
        {
            return "Cedula";
        }

        public static bool InsertarEmpleado(params object[] parametros)
        {
            if (parametros.Count() == Columnas().Split('|').Count())
            {
                InterpreteSQL.Insertar(Tabla(), Columnas(), parametros);
            }
            return true;
        }

        public static bool ModificarEmpleado(string cedula, params object[] parametros)
        {
            if (parametros.Count() == Columnas().Split('|').Count())
            {
                InterpreteSQL.Modificar(Tabla(), Columnas(), LlavePrincipal(), cedula, parametros);
            }
            return true;
        }

        public static Cliente ObtenerEmpleado(string cedula)
        {
            Cliente empleado = null;
            var dataSet = InterpreteSQL.Obtener(TablaEmpleadoPersona(), ColumnasEmpleadoPersona(), "p.CodPerFisica", cedula, CriterioSQL.IgualA);

            if (dataSet.Tables.Count > 0)
            {
                empleado = Convertidor.DataSetAObjecto<Cliente>(dataSet).FirstOrDefault();
            }
            return empleado;
        }

        public static List<Cliente> ObtenerEmpleados(string columnasFiltro = null, string valoresFiltro = null, string criteriosFiltro = null)
        {
            var empleados = new List<Cliente>();
            var dataSet = InterpreteSQL.Obtener(TablaEmpleadoPersona(), ColumnasEmpleadoPersona(), columnasFiltro, valoresFiltro, criteriosFiltro);

            if (dataSet.Tables.Count > 0)
            {
                empleados = Convertidor.DataSetAObjecto<Cliente>(dataSet);
            }
            return empleados;
        }
    }
}
