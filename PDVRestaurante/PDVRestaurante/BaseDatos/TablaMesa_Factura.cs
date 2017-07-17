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
    public static class TablaMesa_Factura
    {
        private static string Tabla()
        {
            return "Mesa_Factura";
        }

        private static string TablaFacturasDeMesa()
        {
            return "Mesa_Factura mf inner join Factura f on f.IdFactura = mf.IdFactura";
        }

        private static string Columnas()
        {
            return "IdFactura|NumeroMesa";
        }

        private static string ColumnasFacturasDeMesa()
        {
            return "mf.IdFactura|NumeroMesa|Fecha|Monto|CedulaCliente";
        }

        private static string LlavePrincipal()
        {
            return "IdFactura|NumeroMesa";
        }

        public static bool InsertarMesa_Factura(params object[] parametros)
        {
            if (parametros.Count() == Columnas().Split('|').Count())
            {
                InterpreteSQL.Insertar(Tabla(), Columnas(), parametros);
            }
            return true;
        }

        public static bool ModificarMesa_Factura(int id, params object[] parametros)
        {
            if (parametros.Count() == Columnas().Split('|').Count())
            {
                InterpreteSQL.Modificar(Tabla(), Columnas(), LlavePrincipal(), id.ToString(), parametros);
            }
            return true;
        }

        public static List<Mesa_Facturas> ObtenerMesa_Facturas(string columnasFiltro = null, string valoresFiltro = null, string criteriosFiltro = null)
        {
            var mesa_facturas = new List<Mesa_Facturas>();
            var dataSet = InterpreteSQL.Obtener(TablaFacturasDeMesa(), ColumnasFacturasDeMesa(), columnasFiltro, valoresFiltro, criteriosFiltro);

            if (dataSet.Tables.Count > 0)
            {
                mesa_facturas = Convertidor.DataSetAObjecto<Mesa_Facturas>(dataSet);
            }
            return mesa_facturas;
        }
    }
}
