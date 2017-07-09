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
        [DisplayName("Tipo de Empleado")]
        public string TipoE { get; set; }
        public decimal Salario { get; set; }
        [DisplayName("Id de Sucursal")]
        public int IdSucursal { get; set; }
        [DisplayName("Sucursal Asignada")]
        public string NombreSucursal
        {
            get {return TablaSucursal.ObtenerSucursal("IdSucursal", IdSucursal.ToString()).Detalle; }
        }
        [DisplayName("Fecha de Inicio")]
        public DateTime FechaInicio { get; set; }
    }
}
