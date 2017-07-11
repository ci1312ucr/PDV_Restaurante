using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using PDVRestaurante.Ayudantes;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.BaseDatos
{
    public static class TablaCorreosPersona
    {
        private static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["RestauranteConn"].ConnectionString;
        }

        private static string Tabla()
        {
            return "CorreosPersona";
        }

        private static string Columnas()
        {
            return "Cedula|Tipo|Correo";
        }

        private static string LlavePrincipal()
        {
            return "Cedula|Tipo";
        }

        public static bool InsertarCorreo(params object[] parametros)
        {
            if (parametros.Count() == Columnas().Split('|').Count())
            {
                InterpreteSQL.Insertar(ConnectionString(), Tabla(), Columnas(), parametros);
            }
            return true;
        }

        public static bool ModificarCorreo(string cedula, params object[] parametros)
        {
            if (parametros.Count() == Columnas().Split('|').Count())
            {
                InterpreteSQL.Modificar(ConnectionString(), Tabla(), Columnas(), LlavePrincipal(), cedula, parametros);
            }
            return true;
        }

    }
}
