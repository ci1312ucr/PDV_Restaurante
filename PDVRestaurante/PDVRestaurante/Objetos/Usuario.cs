using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.Objetos
{
    public class Usuario
    {
        [Display(Name = "Nombre", Order = 1)]
        public string Nombre { get; set; }
        [Display(Name = "Contrasena", Order = 0)]
        public string Contrasena { get; set; }
        [Display(Name = "Id de Empleado", Order = 3)]
        public string IdEmpleado { get; set; }
        [Display(Name = "Salt", Order = 0)]
        public string Salt { get; set; }
        [Display(Name = "Tipo de Usuario", Order = 2)]
        public int IdTipoUsuario { get; set; }
    }
}
