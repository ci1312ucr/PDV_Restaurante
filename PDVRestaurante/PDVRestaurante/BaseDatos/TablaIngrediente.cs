using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDVRestaurante.Ayudantes;
using PDVRestaurante.Constantes;
using PDVRestaurante.Objetos;

namespace PDVRestaurante.BaseDatos
{
    public static class TablaIngrediente
    {
        private static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["RestauranteConn"].ConnectionString;
        }

        private static string Tabla()
        {
            return "Ingrediente";
        }

        private static string Columnas()
        {
            return "IdIngrediente|Nombre";
        }

        private static string LlavePrincipal()
        {
            return "IdIngrediente";
        }

        public static bool InsertarIngrediente(params object[] parametros)
        {
            if (parametros.Count() == Columnas().Split('|').Count())
            {
                InterpreteSQL.Insertar(ConnectionString(), Tabla(), Columnas(), parametros);
            }
            return true;
        }

        public static bool ModificarIngrediente(int id, params object[] parametros)
        {
            if (parametros.Count() == Columnas().Split('|').Count())
            {
                InterpreteSQL.Modificar(ConnectionString(), Tabla(), Columnas(), LlavePrincipal(), id.ToString(), parametros);
            }
            return true;
        }

        public static Ingrediente ObtenerIngrediente(int id)
        {
            Ingrediente ingrediente = null;
            var dataSet = InterpreteSQL.Obtener(ConnectionString(), Tabla(), Columnas(), "c.IdIngrediente", id.ToString(), CriterioSQL.IgualA);

            if (dataSet.Tables.Count > 0)
            {
                ingrediente = Convertidor.DataSetAObjecto<Ingrediente>(dataSet).FirstOrDefault();
            }
            return ingrediente;
        }

        public static List<Ingrediente> ObtenerIngredientes(string columnasFiltro = null, string valoresFiltro = null, string criteriosFiltro = null)
        {
            var ingredientes = new List<Ingrediente>();
            var dataSet = InterpreteSQL.Obtener(ConnectionString(), Tabla(), Columnas(), columnasFiltro, valoresFiltro, criteriosFiltro);

            if (dataSet.Tables.Count > 0)
            {
                ingredientes = Convertidor.DataSetAObjecto<Ingrediente>(dataSet);
            }
            return ingredientes;
        }
    }
}