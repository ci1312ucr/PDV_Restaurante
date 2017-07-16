using PDVRestaurante.Ayudantes;
using PDVRestaurante.Constantes;
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
    public static class TablaTipoUsuario
    {
        private static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["RestauranteConn"].ConnectionString;
        }

        private static string Tabla()
        {
            return "TipoUsuario";
        }

        private static string Columnas()
        {
            return "IdTipoUsuario|Nombre";
        }

        private static string LlavePrincipal()
        {
            return "IdTipoUsuario";
        }

        public static bool InsertarTipoUsuario(params object[] parametros)
        {
            if (parametros.Count() == Columnas().Split('|').Count())
            {
                InterpreteSQL.Insertar(Tabla(), Columnas(), parametros);
            }
            return true;
        }

        public static bool ModificarTipoUsuario(string idTipoUsuario, params object[] parametros)
        {
            if (parametros.Count() == Columnas().Split('|').Count())
            {
                InterpreteSQL.Modificar(Tabla(), Columnas(), LlavePrincipal(), idTipoUsuario, parametros);
            }
            return true;
        }

        public static TipoUsuario ObtenerTipoUsuario(int idTipoUsuario)
        {
            TipoUsuario tipoUsuario = null;
            var dataSet = InterpreteSQL.Obtener(Tabla(), Columnas(), "IdTipoUsuario", idTipoUsuario.ToString(), CriterioSQL.IgualA);

            if (dataSet.Tables.Count > 0)
            {
                tipoUsuario = Convertidor.DataSetAObjecto<TipoUsuario>(dataSet).FirstOrDefault();
            }
            return tipoUsuario;
        }

        public static List<TipoUsuario> ObtenerTiposUsuarios(string columnasFiltro = null, string valoresFiltro = null, string criteriosFiltro = null)
        {
            var tipoUsuarioLista = new List<TipoUsuario>();
            var dataSet = InterpreteSQL.Obtener(Tabla(), Columnas(), columnasFiltro, valoresFiltro, criteriosFiltro);

            if (dataSet.Tables.Count > 0)
            {
                tipoUsuarioLista = Convertidor.DataSetAObjecto<TipoUsuario>(dataSet);
            }
            return tipoUsuarioLista;
        }
    }
}
