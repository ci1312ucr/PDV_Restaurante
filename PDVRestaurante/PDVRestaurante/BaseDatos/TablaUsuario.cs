using PDVRestaurante.Ayudantes;
using PDVRestaurante.Constantes;
using PDVRestaurante.Objetos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.BaseDatos
{
    public static class TablaUsuario
    {
        private static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["RestauranteConn"].ConnectionString;
        }

        private static string Tabla()
        {
            return "Usuario";
        }

        private static string Columnas()
        {
            return "Nombre|Contrasena|Salt|IdEmpleado|IdTipoUsuario";
        }

        private static string LlavePrincipal()
        {
            return "Nombre";
        }

        public static bool InsertarUsuario(params object[] parametros)
        {
            if (parametros.Count() == Columnas().Split(',').Count())
            {
                InterpreteSQL.Insertar(ConnectionString(), Tabla(), Columnas(), parametros);
            }
            return true;
        }

        public static bool ModificarUsuario(string nombre, params object[] parametros)
        {
            if (parametros.Count() == Columnas().Split(',').Count())
            {
                InterpreteSQL.Modificar(ConnectionString(), Tabla(), Columnas(), LlavePrincipal(), nombre, parametros);
            }
            return true;
        }

        public static Usuario ObtenerUsuario(string nombre)
        {
            Usuario usuario = null;
            var dataSet = InterpreteSQL.Obtener(ConnectionString(), Tabla(), Columnas(), "Nombre", "'" + nombre + "'", CriterioSQL.IgualA);

            if (dataSet.Tables.Count > 0)
            {
                usuario = Convertidor.DataSetAObjecto<Usuario>(dataSet).FirstOrDefault();
            }
            return usuario;
        }

        public static List<Usuario> ObtenerUsuarios(string columnasFiltro = null, string valoresFiltro = null, string criteriosFiltro = null)
        {
            var usuarios = new List<Usuario>();
            var dataSet = InterpreteSQL.Obtener(ConnectionString(), Tabla(), Columnas(), columnasFiltro, valoresFiltro, criteriosFiltro);

            if (dataSet.Tables.Count > 0)
            {
                usuarios = Convertidor.DataSetAObjecto<Usuario>(dataSet);
            }
            return usuarios;
        }
    }
}
