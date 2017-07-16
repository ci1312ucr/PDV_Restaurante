using PDVRestaurante.Ayudantes;
using PDVRestaurante.Constantes;
using PDVRestaurante.Objetos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.BaseDatos
{
    public static class TablaCliente
    {
        private static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["RestauranteConn"].ConnectionString;
        }

        private static string Tabla()
        {
            return "Cliente";
        }

        private static string TablaClienteFisico()
        {
            return "Cliente c INNER JOIN PersonaFisica p ON p.CodPerFisica = c.Cedula";
        }

        private static string Columnas()
        {
            return "Cedula|Frecuente";
        }

        private static string ColumnasClienteFisico()
        {
            return "Cedula|Nombre1|Nombre2|Apellido1|Apellido2|Sexo|EstadoCivil|FechaNacimiento|Frecuente ";
        }

        private static string LlavePrincipal()
        {
            return "Cedula";
        }

        public static bool InsertarCliente(params object[] parametros)
        {
            if (parametros.Count() == Columnas().Split('|').Count())
            {
                InterpreteSQL.Insertar(Tabla(), Columnas(), parametros);
            }
            return true;
        }

        public static bool ModificarCliente(string cedula, params object[] parametros)
        {
            if (parametros.Count() == Columnas().Split('|').Count())
            {
                InterpreteSQL.Modificar(Tabla(), Columnas(), LlavePrincipal(), cedula, parametros);
            }
            return true;
        }

        public static ClienteFisico ObtenerClienteFisico(string cedula)
        {
            ClienteFisico cliente = null;
            var dataSet = InterpreteSQL.Obtener(TablaClienteFisico(), ColumnasClienteFisico(), "c.Cedula", cedula, CriterioSQL.IgualA);

            if (dataSet.Tables.Count > 0)
            {
                cliente = Convertidor.DataSetAObjecto<ClienteFisico>(dataSet).FirstOrDefault();
            }
            return cliente;
        }

        public static List<ClienteFisico> ObtenerClientesFisicos(string columnasFiltro = null, string valoresFiltro = null, string criteriosFiltro = null)
        {
            var clientes = new List<ClienteFisico>();
            var dataSet = InterpreteSQL.Obtener(TablaClienteFisico(), ColumnasClienteFisico(), columnasFiltro, valoresFiltro, criteriosFiltro);

            if (dataSet.Tables.Count > 0)
            {
                clientes = Convertidor.DataSetAObjecto<ClienteFisico>(dataSet);
            }
            return clientes;
        }
    }
}
