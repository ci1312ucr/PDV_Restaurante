using PDVRestaurante.Ayudantes;
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

namespace PDVRestaurante.Pantallas.Mantenimiento.Facturas
{
    public partial class CrearFactura : Form
    {
        public CrearFactura()
        {
            InitializeComponent();
            comboBoxCedula.DataSource = TablaCliente.ObtenerClientesFisicos();
            comboBoxCedula.DisplayMember = "Cedula";

            comboBoxPlato.DataSource = TablaPlato.ObtenerPlatos();
            comboBoxPlato.DisplayMember = "Nombre";

            listViewPlatos.Columns.Add("Nombre");
            listViewPlatos.Columns.Add("ID");
            listViewPlatos.Columns.Add("Cantidad");
            listViewPlatos.Columns.Add("Precio");
            listViewPlatos.AjustarColumnas();
        }

        private bool InsertarPlatos(int idFac)
        {
            foreach (ListViewItem item in listViewPlatos.Items)
            {
                int idPlat = Int32.Parse(item.SubItems[1].Text);
                int cantidad = Int32.Parse(item.SubItems[2].Text);
                TablaPlatos_Factura.InsertarPlatos_Factura(idFac, idPlat, cantidad);
            }
            return true;
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            try
            {
                int id = TablaFactura.ObtenerIdFactura();
                if (comboBoxCedula.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione una cédula de cliente.");
                    return;
                }
                ClienteFisico cliente = (ClienteFisico)comboBoxCedula.SelectedItem;

                if (comboBoxTipoPago.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un tipo de pago.");
                    return;
                }
                string tipopago = (string)comboBoxTipoPago.SelectedItem;
                int mesa = 0;
                if(!int.TryParse(numericUpDownMesa.Value.ToString(), out mesa))
                {
                    MessageBox.Show("Seleccione una mesa válida.");
                    return;
                }
                if (mesa == 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Confirme que la orden es un pedido express o para llevar", "Pedido Express", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
                Decimal monto = 0;
                if (!Decimal.TryParse(textBoxMonto.Text.Substring(1), out monto))
                {
                    MessageBox.Show("Imposible leer el monto.");
                    return;
                }

                if(monto == 0)
                {
                    MessageBox.Show("Agregue platos por facturar.");
                    return;
                }

                if (TablaFactura.InsertarFactura(id, DateTime.Now, monto, tipopago, cliente.Cedula, 0) &&
                    TablaMesa_Factura.InsertarMesa_Factura(id, mesa) &&
                    InsertarPlatos(id))
                {
                    MessageBox.Show("Se generó la factura exitosamente", "Factura generada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                } else
                {
                    throw new Exception("Error generando la factura.");
                }
            } catch (Exception ex)
            {
                ManejoExcepciones.LogearExcepcion(ex);
                MessageBox.Show("Se produjo un error al tratar de generar la factura.", "Error al generar factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonAgregarPlato_Click(object sender, EventArgs e)
        {
            decimal monto;
            int cantidad = 0;
            if(comboBoxPlato.SelectedItem != null && int.TryParse(numericUpDownCantidad.Value.ToString(),out cantidad) && cantidad > 0){
                Plato p = (Plato)comboBoxPlato.SelectedItem;
                bool found = false;

                if (Decimal.TryParse(textBoxMonto.Text.Substring(1), out monto))
                {
                    monto += p.Precio * cantidad;
                    textBoxMonto.Text = "₡" + monto.ToString();
                }

                foreach (ListViewItem item in listViewPlatos.Items)
                {
                    if(item.SubItems[1].Text == p.IdPlato.ToString())
                    {
                        found = true;
                        cantidad += Int32.Parse(item.SubItems[2].Text);
                        item.SubItems[2].Text = cantidad.ToString();
                    }
                }

                if(!found)
                {
                    var newListView = new List<ListViewItem>();
                    string row = p.Nombre + "|" + p.IdPlato.ToString() + "|" + cantidad.ToString() + "|" + p.Precio.ToString();
                    newListView.Add(new ListViewItem(row.Split('|')));
                    listViewPlatos.Items.AddRange(newListView.ToArray());
                    listViewPlatos.View = View.Details;
                    listViewPlatos.AjustarColumnas();
                }

            } else
            {
                MessageBox.Show("Debe agregar por lo menos una existencia.");
            }
        }

        private void listViewFacturas_Ajuste(object sender, EventArgs e)
        {
            listViewPlatos.AjustarColumnas();
        }
    }
}