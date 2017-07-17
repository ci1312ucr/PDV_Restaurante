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
    public static class TablaFactura
    {
        private static string Tabla()
        {
            return "Factura";
        }

        private static string TablaFacturaEmpleado()
        {
            return "Factura f INNER JOIN PersonaFisica e ON f.CedulaCliente = e.CodPerFisica";
        }

        private static string Columnas()
        {
            return "IdFactura|Fecha|Monto|TipoPago|CedulaCliente|Cancelada";
        }

        private static string ColumnasFacturaEmpleado()
        {
            return "f.IdFactura|f.Fecha|f.Monto|f.TipoPago|f.CedulaCliente|e.Nombre1 + ' ' + e.Apellido1 AS Cliente";
        }

        private static string ColumnasFacturaSiguienteId()
        {
            return "max(IdFactura) + 1";
        }

        private static string LlavePrincipal()
        {
            return "IdFactura";
        }

        public static bool InsertarFactura(params object[] parametros)
        {
            if (parametros.Count() == Columnas().Split('|').Count())
            {
                InterpreteSQL.Insertar(Tabla(), Columnas(), parametros);
            }
            return true;
        }

        public static bool ModificarFactura(int id, params object[] parametros)
        {
            if (parametros.Count() == Columnas().Split('|').Count())
            {
                InterpreteSQL.Modificar(Tabla(), Columnas(), LlavePrincipal(), id.ToString(), parametros);
            }
            return true;
        }

        public static Factura ObtenerFactura(int id)
        {
            Factura factura = null;
            var dataSet = InterpreteSQL.Obtener(Tabla(), Columnas(), "IdFactura", id.ToString(), CriterioSQL.IgualA);

            if (dataSet.Tables.Count > 0)
            {
                factura = Convertidor.DataSetAObjecto<Factura>(dataSet).FirstOrDefault();
            }
            return factura;
        }

        public static List<Factura> ObtenerFacturas(string columnasFiltro = null, string valoresFiltro = null, string criteriosFiltro = null)
        {
            var facturas = new List<Factura>();
            var dataSet = InterpreteSQL.Obtener(TablaFacturaEmpleado(), ColumnasFacturaEmpleado(), columnasFiltro, valoresFiltro, criteriosFiltro);

            if (dataSet.Tables.Count > 0)
            {
                facturas = Convertidor.DataSetAObjecto<Factura>(dataSet);
            }
            return facturas;
        }

        public static int ObtenerIdFactura()
        {
            return InterpreteSQL.ObtenerSiguienteId(Tabla(),LlavePrincipal());
        }
    }
}