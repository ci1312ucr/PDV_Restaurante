using PDVRestaurante.BaseDatos;
using PDVRestaurante.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDVRestaurante.Pantallas.Mantenimiento.Empleados
{
    public partial class ModificarEmpleado : Form
    {
        PersonaFisica _personaFisica;
        Empleado _empleado;

        public ModificarEmpleado(string cedulaEmpleado)
        {
            InitializeComponent();

            _empleado = TablaEmpleado.ObtenerEmpleado(cedulaEmpleado);
            _personaFisica = TablaPersonaFisica.ObtenerPersonaFisica(cedulaEmpleado);
        }
    }
}
