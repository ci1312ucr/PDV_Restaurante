using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.Objetos
{
    public class Propiedad
    {
        public string Name { get; set; }
        public Type ValueType { get; set; }
        public string DisplayName { get; set; }
        public int Order { get; set; }
    }
}
