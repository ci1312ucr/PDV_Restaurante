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
        [DisplayName("Primer Nombre")]
        public string Nombre1 { get; set; }
        [DisplayName("Segundo Nombre")]
        public string Nombre2 { get; set; }
        [DisplayName("Primer Apellido")]
        public string Apellido1 { get; set; }
        [DisplayName("Segundo Apellido")]
        public string Apellido2 { get; set; }
        public char Sexo { get; set; }
        [DisplayName("Estado Civil")]
        public string EstadoCivil { get; set; }
        [DisplayName("Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }
    }
}

