using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.Ayudantes
{
    public static class Convertidor
    {
        public static List<TipoObjeto> DataSetAObjecto<TipoObjeto>(DataSet dataSet)
        {
            var listaObjetos = new List<TipoObjeto>();
            //try
            //{
            //    var propiedades = typeof(TipoObjeto).GetType().GetProperties();
            //    foreach (DataRow row in dataSet.Tables[0].Rows)
            //    {
            //        var objeto = default(TipoObjeto);
            //        foreach (var propiedad in propiedades)
            //        {
            //            var value = row[propiedad.Name] == DBNull.Value ? default(propiedad.PropertyType.GetType()) : row[propiedad.Name];
            //            objeto.GetType().GetProperty(propiedad.Name).SetValue(objeto, value);
            //}
            //    }
            //}
            //catch (Exception ex)
            //{
            //    ManejoExcepciones.LogearExcepcion(ex);
            //}
            return listaObjetos;
        }
    }
}
