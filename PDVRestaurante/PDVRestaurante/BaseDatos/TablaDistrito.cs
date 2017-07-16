using PDVRestaurante.Ayudantes;
using PDVRestaurante.Objetos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.BaseDatos
{
    public static class TablaDistrito
    {
        private static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["RestauranteConn"].ConnectionString;
        }

        private static string Tabla()
        {
            return "Distrito";
        }

        private static string Columnas()
        {
            return "IdProvincia|IdCanton|IdDistrito|Descripcion";
        }

        private static string LlavePrincipal()
        {
            return "IdProvincia|IdCanton|IdDistrito";
        }

        public static List<Distrito> ObtenerDistritos(string columnasFiltro = null, string valoresFiltro = null, string criteriosFiltro = null)
        {
            var distritos = new List<Distrito>();
            var dataSet = InterpreteSQL.Obtener(ConnectionString(), Tabla(), Columnas(), columnasFiltro, valoresFiltro, criteriosFiltro);

            if (dataSet.Tables.Count > 0)
            {
                distritos = Convertidor.DataSetAObjecto<Distrito>(dataSet);
            }
            return distritos;
        }
    }
}
