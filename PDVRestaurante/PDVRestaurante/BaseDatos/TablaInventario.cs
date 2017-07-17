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
    public static class TablaInventario
    {
        private static string Tabla()
        {
            return "Inventario";
        }

        private static string TablaInventarioSucursal()
        {
            return "Inventario i inner join Sucursal s on s.IdSucursal = i.IdSucursal";
        }

        private static string Columnas()
        {
            return "IdInventario|Fecha|IdSucursal|TiempoReal";
        }

        private static string ColumnasInventarioSucursal()
        {
            return "IdInventario|Fecha|i.IdSucursal|s.Detalle as Sucursal";
        }

        private static string LlavePrincipal()
        {
            return "IdInventario";
        }

        public static bool InsertarInventario(params object[] parametros)
        {
            if (parametros.Count() == Columnas().Split('|').Count())
            {
                InterpreteSQL.Insertar(Tabla(), Columnas(), parametros);
            }
            return true;
        }

        public static bool ModificarInventario(string cedula, params object[] parametros)
        {
            if (parametros.Count() == Columnas().Split('|').Count())
            {
                InterpreteSQL.Modificar(Tabla(), Columnas(), LlavePrincipal(), cedula, parametros);
            }
            return true;
        }

        public static Inventario ObtenerInventario(int idSucursal)
        {
            Inventario inventario = null;
            var dataSet = InterpreteSQL.Obtener(TablaInventarioSucursal(), ColumnasInventarioSucursal(), "i.IdSucursal", idSucursal.ToString(), CriterioSQL.IgualA);

            if (dataSet.Tables.Count > 0)
            {
                inventario = Convertidor.DataSetAObjecto<Inventario>(dataSet).FirstOrDefault();
            }
            return inventario;
        }

        public static List<Inventario> ObtenerInventarios(string columnasFiltro = null, string valoresFiltro = null, string criteriosFiltro = null)
        {
            var inventarios = new List<Inventario>();
            var dataSet = InterpreteSQL.Obtener(TablaInventarioSucursal(), ColumnasInventarioSucursal(), columnasFiltro, valoresFiltro, criteriosFiltro);

            if (dataSet.Tables.Count > 0)
            {
                inventarios = Convertidor.DataSetAObjecto<Inventario>(dataSet);
            }
            return inventarios;
        }

        public static int ObtenerSiguienteId()
        {
            return InterpreteSQL.ObtenerSiguienteId(Tabla(), LlavePrincipal());
        }
    }
}
