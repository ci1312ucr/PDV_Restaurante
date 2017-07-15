using PDVRestaurante.Ayudantes;
using PDVRestaurante.BaseDatos;
using PDVRestaurante.Constantes;
using PDVRestaurante.Objetos;
using PDVRestaurante.Pantallas.Mantenimiento.Empleados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDVRestaurante.Pantallas.Consultas
{
    public partial class ConsultaFacturas : Form
    {
        private List<Propiedad> _columnas;
        private List<Factura> _clientes;
        private string _ordenActual = "IdIngrediente";

        public ConsultaFacturas()
        {
            InitializeComponent();

            InicializaListView();
        }
    }
}
