using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDVRestaurante.Ayudantes;
using PDVRestaurante.Constantes;
using PDVRestaurante.Objetos;
using System.Data.SqlClient;

namespace PDVRestaurante.BaseDatos
{
    public static class TablaPlatos_Factura
    {
        private static string Tabla()
        {
            return "Platos_Factura";
        }

        private static string Columnas()
        {
            return "IdFactura|IdPlato|Cantidad";
        }

        private static string LlavePrincipal()
        {
            return "IdFactura|IdPlato";
        }

        public static bool InsertarPlatos_Factura(params object[] parametros)
        {
            if (parametros.Count() == Columnas().Split('|').Count())
            {
                InterpreteSQL.Insertar(Tabla(), Columnas(), parametros);
            }
            return true;
        }

        public static bool ModificarPlatos_Factura(int id, params object[] parametros)
        {
            if (parametros.Count() == Columnas().Split('|').Count())
            {
                InterpreteSQL.Modificar(Tabla(), Columnas(), LlavePrincipal(), id.ToString(), parametros);
            }
            return true;
        }

        public static List<Platos_Factura> ObtenerFacturas(string columnasFiltro = null, string valoresFiltro = null, string criteriosFiltro = null)
        {
            var facturas = new List<Platos_Factura>();
            var dataSet = InterpreteSQL.Obtener(Tabla(), Columnas(), columnasFiltro, valoresFiltro, criteriosFiltro);

            if (dataSet.Tables.Count > 0)
            {
                facturas = Convertidor.DataSetAObjecto<Platos_Factura>(dataSet);
            }
            return facturas;
        }
    }
}
