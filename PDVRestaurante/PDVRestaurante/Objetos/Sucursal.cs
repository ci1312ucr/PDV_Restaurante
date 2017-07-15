using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.Objetos
{
    public class Sucursal
    {
        [Display(Name = "IdSucursal", Order = 0)]
        public int IdSucursal { get; set; }
        [Display(Name = "Fecha Apertura", Order = 15)]
        public DateTime FechaApertura { get; set; }
        [Display(Name = "IdDistrito", Order = 0)]
        public int IdDistrito { get; set; }
        [Display(Name = "Distrito", Order = 2)]
        public String Distrito { get; set; }
        [Display(Name = "IdCanton", Order = 0)]
        public int IdCanton { get; set; }
        [Display(Name = "Canton", Order = 3)]
        public String Canton { get; set; }
        [Display(Name = "IdProvincia", Order = 0)]
        public int IdProvincia { get; set; }
        [Display(Name = "Provincia", Order = 4)]
        public String Provincia { get; set; }
        [Display(Name = "IdGerente", Order = 5)]
        public string IdGerente { get; set; }
        [Display(Name = "Nombre Gerente", Order = 6)]
        public string Gerente { get; set; }
        [Display(Name = "Fecha Inicio Gerente", Order = 14)]
        public DateTime? FechaInicio { get; set; }
        [Display(Name = "Detalle", Order = 1)]
        public string Detalle { get; set; }
    }
}
