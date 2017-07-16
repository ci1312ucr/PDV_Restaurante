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
    public static class TablaFactura
    {
        private static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["RestauranteConn"].ConnectionString;
        }

        private static string Tabla()
        {
            return "Factura";
        }

        private static string Columnas()
        {
            return "IdFactura|Fecha|Monto|TipoPago|CedulaCliente";
        }

        private static string LlavePrincipal()
        {
            return "IdFactura";
        }

        public static bool InsertarFactura(params object[] parametros)
        {
            if (parametros.Count() == Columnas().Split('|').Count())
            {
                InterpreteSQL.Insertar(ConnectionString(), Tabla(), Columnas(), parametros);
            }
            return true;
        }

        public static bool ModificarFactura(int id, params object[] parametros)
        {
            if (parametros.Count() == Columnas().Split('|').Count())
            {
                InterpreteSQL.Modificar(ConnectionString(), Tabla(), Columnas(), LlavePrincipal(), id.ToString(), parametros);
            }
            return true;
        }

        public static Factura ObtenerFactura(int id)
        {
            Factura factura = null;
            var dataSet = InterpreteSQL.Obtener(ConnectionString(), Tabla(), Columnas(), "c.IdFactura", id.ToString(), CriterioSQL.IgualA);

            if (dataSet.Tables.Count > 0)
            {
                factura = Convertidor.DataSetAObjecto<Factura>(dataSet).FirstOrDefault();
            }
            return factura;
        }

        public static List<Factura> ObtenerFacturas(string columnasFiltro = null, string valoresFiltro = null, string criteriosFiltro = null)
        {
            var facturas = new List<Factura>();
            var dataSet = InterpreteSQL.Obtener(ConnectionString(), Tabla(), Columnas(), columnasFiltro, valoresFiltro, criteriosFiltro);

            if (dataSet.Tables.Count > 0)
            {
                facturas = Convertidor.DataSetAObjecto<Factura>(dataSet);
            }
            return facturas;
        }
    }
}