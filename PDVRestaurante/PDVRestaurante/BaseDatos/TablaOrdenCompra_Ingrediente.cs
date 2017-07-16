﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.BaseDatos
{
    public static class TablaOrdenCompra_Ingrediente
    {
        private static string Tabla()
        {
            return "OrdenCompra_Ingrediente";
        }

        private static string Columnas()
        {
            return "IdCompra|IdIngredientes|MontoUnitario|Cantidad";
        }

        private static string LlavePrincipal()
        {
            return "IdCompra|IdIngrediente";
        }
    }
}
