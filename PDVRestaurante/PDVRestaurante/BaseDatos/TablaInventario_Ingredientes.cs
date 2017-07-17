using PDVRestaurante.Ayudantes;
using PDVRestaurante.Constantes;
using PDVRestaurante.Objetos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.BaseDatos
{
    public static class TablaInventario_Ingredientes
    {
        private static string Tabla()
        {
            return "Inventario_Ingredientes";
        }

        private static string TablaInventarioIngrediente()
        {
            return "Inventario_Ingredientes ii inner join Ingrediente i on i.IdIngrediente = ii.IdIngrediente";
        }

        private static string Columnas()
        {
            return "IdInventario|IdIngrediente|Existencias";
        }

        private static string ColumnasInventarioIngrediente()
        {
            return "IdInventario|ii.IdIngrediente|Existencias|i.Nombre";
        }

        private static string LlavePrincipal()
        {
            return "IdInventario|IdIngrediente";
        }

        public static bool InsertarInventarioIngrediente(params object[] parametros)
        {
            if (parametros.Count() == Columnas().Split('|').Count())
            {
                InterpreteSQL.Insertar(Tabla(), Columnas(), parametros);
            }
            return true;
        }

        public static bool ModificarInventarioIngrediente(string cedula, params object[] parametros)
        {
            if (parametros.Count() == Columnas().Split('|').Count())
            {
                InterpreteSQL.Modificar(Tabla(), Columnas(), LlavePrincipal(), cedula, parametros);
            }
            return true;
        }

        public static InventarioIngrediente ObtenerInventarioIngrediente(int idInventario)
        {
            InventarioIngrediente inventario = null;
            var dataSet = InterpreteSQL.Obtener(TablaInventarioIngrediente(), ColumnasInventarioIngrediente(), "ii.IdInventario", idInventario.ToString(), CriterioSQL.IgualA);

            if (dataSet.Tables.Count > 0)
            {
                inventario = Convertidor.DataSetAObjecto<InventarioIngrediente>(dataSet).FirstOrDefault();
            }
            return inventario;
        }

        public static List<InventarioIngrediente> ObtenerInventarioIngredientes(string columnasFiltro = null, string valoresFiltro = null, string criteriosFiltro = null)
        {
            var inventarios = new List<InventarioIngrediente>();
            var dataSet = InterpreteSQL.Obtener(TablaInventarioIngrediente(), ColumnasInventarioIngrediente(), columnasFiltro, valoresFiltro, criteriosFiltro);

            if (dataSet.Tables.Count > 0)
            {
                inventarios = Convertidor.DataSetAObjecto<InventarioIngrediente>(dataSet);
            }
            return inventarios;
        }
    }
}
