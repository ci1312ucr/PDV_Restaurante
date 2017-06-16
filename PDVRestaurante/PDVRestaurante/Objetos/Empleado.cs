using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.Objetos
{
    public class Empleado
    {
        public string Cedula { get; set; }
        public string Tipo { get; set; }
        public decimal Salario { get; set; }
        public int IdSucursal { get; set; }
        public DateTime FechaInicio { get; set; }
    }
}
