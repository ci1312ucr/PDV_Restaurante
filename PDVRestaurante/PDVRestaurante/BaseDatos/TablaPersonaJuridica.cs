﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.BaseDatos
{
    public static class TablaPersonaJuridica
    {
        private static string Tabla()
        {
            return "PersonaJuridica";
        }

        private static string Columnas()
        {
            return "CodPerJuridica|Nombre|FechaApertura";
        }

        private static string LlavePrincipal()
        {
            return "CodPerJuridica";
        }
    }
}
