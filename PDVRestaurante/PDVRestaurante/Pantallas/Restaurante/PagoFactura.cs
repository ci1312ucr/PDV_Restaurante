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

namespace PDVRestaurante.Pantallas.Restaurante
{
    public partial class PagoFactura : Form
    {
        private Factura _factura;
        public PagoFactura(int idFactura)
        {
            InitializeComponent();
            _factura = TablaFactura.ObtenerFactura(idFactura);
            labelFactura.Text = idFactura.ToString();
            labelMonto.Text = _factura.Monto.ToString();
            buttonPagar.Enabled = false;
            comboBoxTipoPago.Items.Add("Tarjeta de crédito");
            comboBoxTipoPago.Items.Add("Tarjeta de débito");
            comboBoxTipoPago.Items.Add("Cheque");
            comboBoxTipoPago.Items.Add("Efectivo");
            comboBoxTipoPago.Items.Add("Otro");
            comboBoxTipoPago.SelectedItem = "Efectivo";
        }

        private void buttonPagar_Click(object sender, EventArgs e)
        {
            TablaFactura.ModificarFactura(_factura.IdFactura, _factura.IdFactura, _factura.Fecha, _factura.Monto,
                                          comboBoxTipoPago.SelectedItem, _factura.CedulaCliente, 1);
            var vuelto = Convert.ToDecimal(textBoxMontoCancelado.Text) - _factura.Monto;
            MessageBox.Show("La factura # " + _factura.IdFactura.ToString() + " ha sido cancelada. Su vuelto es de " + vuelto.ToString());
            this.Dispose();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBoxMontoCancelado_TextChanged(object sender, EventArgs e)
        {
            int n;
            buttonPagar.Enabled = (textBoxMontoCancelado.Text.Length > 0 && int.TryParse(textBoxMontoCancelado.Text, out n));
        }

        private void comboBoxTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipoPago.SelectedItem.ToString().StartsWith("Tarjeta"))
            {
                textBoxMontoCancelado.Text = _factura.Monto.ToString();
                textBoxMontoCancelado.Enabled = false;
                buttonPagar.Enabled = true;
            } else
            {
                textBoxMontoCancelado.Text = "";
                textBoxMontoCancelado.Enabled = true;
            }
        }
    }
}
