﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.BaseDatos
{
    public static class TablaEmpleados_Factura
    {
        private static string Tabla()
        {
            return "Empleados_Factura";
        }

        private static string Columnas()
        {
            return "IdFactura|CedulaEmpleado";
        }

        private static string LlavePrincipal()
        {
            return "IdFactura|CedulaEmpleado";
        }
    }
}
