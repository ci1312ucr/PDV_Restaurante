using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.Objetos
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Constrasena { get; set; }
        public string IdEmpleado { get; set; }
        public string Salt { get; set; }
        public int IdTipoUsuario { get; set; }
    }
}
