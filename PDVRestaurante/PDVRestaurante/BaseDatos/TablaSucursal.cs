using PDVRestaurante.Ayudantes;
using PDVRestaurante.Constantes;
using PDVRestaurante.Objetos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.BaseDatos
{
    public static class TablaSucursal
    {
        private static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["RestauranteConn"].ConnectionString;
        }

        private static string Tabla()
        {
            return "Sucursal";
        }

        private static string Columnas()
        {
            return "IdSucursal|FechaApertura|IdDistrito|IdCanton|IdProvincia|IdGerente|FechaInicio|Detalle";
        }

        private static string LlavePrincipal()
        {
            return "IdSucursal";
        }

        public static bool InsertarSucursal(params object[] parametros)
        {
            if (parametros.Count() == Columnas().Split('|').Count())
            {
                InterpreteSQL.Insertar(ConnectionString(), Tabla(), Columnas(), parametros);
            }
            return true;
        }

        public static bool ModificarSucursal(int idSucursal, params object[] parametros)
        {
            if (parametros.Count() == Columnas().Split('|').Count())
            {
                InterpreteSQL.Modificar(ConnectionString(), Tabla(), Columnas(), LlavePrincipal(), idSucursal.ToString(), parametros);
            }
            return true;
        }

        public static Sucursal ObtenerSucursal(string columnaBusqueda, string valorBusqueda)
        {
            Sucursal sucursal = null;
            var dataSet = InterpreteSQL.Obtener(ConnectionString(), Tabla(), Columnas(), columnaBusqueda, valorBusqueda, CriterioSQL.IgualA);

            if (dataSet.Tables.Count > 0)
            {
                sucursal = Convertidor.DataSetAObjecto<Sucursal>(dataSet).FirstOrDefault();
            }
            return sucursal;
        }

        public static List<Sucursal> ObtenerSucursales(string columnasFiltro = null, string valoresFiltro = null, string criteriosFiltro = null)
        {
            var sucursales = new List<Sucursal>();
            var dataSet = InterpreteSQL.Obtener(ConnectionString(), Tabla(), Columnas(), columnasFiltro, valoresFiltro, criteriosFiltro);

            if (dataSet.Tables.Count > 0)
            {
                sucursales = Convertidor.DataSetAObjecto<Sucursal>(dataSet);
            }
            return sucursales;
        }
    }
}
