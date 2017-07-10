using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using PDVRestaurante.BaseDatos;

namespace PDVRestaurante.Objetos
{
    public class Empleado : PersonaFisica
    {
        [Display(Name = "Tipo de Empleado", Order = 6)]
        public string TipoE { get; set; }
        [Display(Name = "Salario", Order = 12)]
        public decimal Salario { get; set; }
        [Display(Name = "Id de Sucursal", Order = 0)]
        public int IdSucursal { get; set; }
        [Display(Name = "Sucursal Asignada", Order = 8)]
        public string NombreSucursal { get; set; }
        [Display(Name = "Fecha de Inicio", Order = 7)]
        public DateTime FechaInicio { get; set; }
    }
}
