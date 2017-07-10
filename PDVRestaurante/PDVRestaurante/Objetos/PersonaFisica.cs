using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PDVRestaurante.Objetos
{
    public class PersonaFisica : Persona
    {
        [Display(Name = "Primer Nombre", Order = 2)]
        public string Nombre1 { get; set; }
        [Display(Name = "Segundo Nombre", Order = 3)]
        public string Nombre2 { get; set; }
        [Display(Name = "Primer Apellido", Order = 4)]
        public string Apellido1 { get; set; }
        [Display(Name = "Segundo Apellido", Order = 5)]
        public string Apellido2 { get; set; }
        [Display(Name = "Sexo", Order = 10)]
        public char Sexo { get; set; }
        [Display(Name = "Estado Civil", Order = 11)]
        public string EstadoCivil { get; set; }
        [Display(Name ="Fecha de Nacimiento", Order = 9)]
        public DateTime FechaNacimiento { get; set; }
    }
}

