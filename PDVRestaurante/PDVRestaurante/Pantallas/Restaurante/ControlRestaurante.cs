using PDVRestaurante.Ayudantes;
using PDVRestaurante.Pantallas.Mantenimiento.Facturas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDVRestaurante.Pantallas.Restaurante
{
    public partial class ControlRestaurante : Form
    {
        public ControlRestaurante()
        {
            InitializeComponent();
        }

        private void buttonNuevaFactura_Click(object sender, EventArgs e)
        {
            this.CambiarPantalla("Mantenimiento.Facturas", "CrearFactura");
        }

        private void buttonDetalleFactura_Click(object sender, EventArgs e)
        {
            this.CambiarPantalla("Restaurante", "DetalleFactura", 0);
        }

        private void buttonPagarFactura_Click(object sender, EventArgs e)
        {
            this.CambiarPantalla("Restaurante", "PagarMesaFactura");
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
