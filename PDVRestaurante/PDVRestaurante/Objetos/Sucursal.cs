using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.Objetos
{
    public class Sucursal
    {
        public int IdSucursal { get; set; }
        public DateTime FechaApertura { get; set; }
        public int IdDistrito { get; set; }
        public int IdCanton { get; set; }
        public int IdProvincia { get; set; }
        public int? IdGerente { get; set; }
        public DateTime? FechaInicio { get; set; }
        public string Detalle { get; set; }
    }
}
