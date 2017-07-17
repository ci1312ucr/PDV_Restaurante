using PDVRestaurante.Ayudantes;
using PDVRestaurante.BaseDatos;
using PDVRestaurante.Constantes;
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
    public partial class ImprimirFactura : Form
    {
        private string _ordenActual = "IdFactura";
        private List<Propiedad> _columnas;
        private List<Platos_Factura> _platos;
        private Factura _factura;
        private string _nombreCliente = "";

        public ImprimirFactura()
        {
            InitializeComponent();
            InicializaListView();
            buttonImprimir.Enabled = false;
            buttonBuscar.Enabled = false;
            _platos = new List<Platos_Factura>();
            _factura = new Factura();
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            //Para realizar una búsqueda tiene que haber algo escrito en el campo de búsqueda
            buttonBuscar.Enabled = textBuscar.Text.Length > 0;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            _platos.Clear();
            _factura = new Factura();
            _nombreCliente = "";
            int n;
            if (int.TryParse(textBuscar.Text, out n)) {
                _factura = TablaFactura.ObtenerFactura(n);
                if (TablaPersona.ObtenerPersona(_factura.CedulaCliente).TipoP == "F")
                {
                    var cliente = TablaCliente.ObtenerClienteFisico(_factura.CedulaCliente);
                    _nombreCliente = cliente.Nombre1 + " " + cliente.Apellido1;
                }
                else
                {
                    var cliente = TablaCliente.ObtenerClienteJuridico(_factura.CedulaCliente);
                    _nombreCliente = cliente.Nombre;
                }
                var platos = TablaPlatos_Factura.ObtenerPlatos_Factura("IdFactura", _factura.IdFactura.ToString(), CriterioSQL.IgualA);
                CargarListView(platos);
            }
            buttonImprimir.Enabled = _platos.Count > 0;
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            decimal subtotal = 0;
            Principal principal = (Principal)this.ParentForm;
            var sucursal = principal.SucursalActual();
            var sb = new StringBuilder();
            sb.AppendLine("Restaurante El Paladar Feliz");
            sb.AppendLine(DateTime.Now.ToShortDateString());
            sb.AppendLine(sucursal.Detalle);
            sb.AppendLine(sucursal.Distrito + ", " + sucursal.Canton + ", " + sucursal.Provincia);
            sb.AppendLine();
            sb.AppendLine();
            sb.AppendLine(("Cliente: " + _nombreCliente).PadRight(121 - _nombreCliente.Length));
            sb.AppendLine();
            sb.AppendLine();
            sb.AppendLine(("Cantidad").PadRight(30) + ("Descripción").PadRight(60) + ("Valor").PadRight(16));
            sb.Append('_', 70);
            sb.AppendLine();
            foreach (var plato in _platos)
            {
                subtotal += plato.Precio * plato.Cantidad;
                var cantidad = plato.Cantidad.ToString();
                var descripcion = plato.Nombre;
                var precio = plato.Precio.ToString();
                sb.AppendLine(cantidad.PadRight(33 - cantidad.Length) + descripcion.PadRight(71 - descripcion.Length) + precio.PadRight(16 - precio.Length));
                sb.Append('_', 70);
                sb.AppendLine();
            }
            sb.AppendLine("Sub-Total:".PadLeft(86) + " ".PadRight(15 - subtotal.ToString().Length) + subtotal.ToString());
            var impVentas = subtotal * 13 / 100;
            sb.AppendLine("Impuesto de Ventas:".PadLeft(80) + " ".PadRight(15 - impVentas.ToString().Length) + impVentas.ToString());
            var impServicio = subtotal * 10 / 100;
            sb.AppendLine("Impuesto de servicio:".PadLeft(81) + " ".PadRight(15 - impServicio.ToString().Length) + impServicio.ToString());
            var total = subtotal + impVentas + impServicio;
            sb.AppendLine("TOTAL:".PadLeft(87) + " ".PadRight(15 - total.ToString().Length) + total.ToString());
            sb.AppendLine();
            sb.AppendLine();
            sb.AppendLine();
            sb.AppendLine("_________________________________________");
            sb.AppendLine("Firma Cliente");
            ControladorPDF.CrearNuevoPDF(_factura.IdFactura.ToString() + ".pdf", sb);
        }


        #region Funciones

        private void InicializaListView()
        {
            listViewFactura.DoubleBuffer();
            var properties = typeof(Platos_Factura).GetProperties().
                                  Select(p => new Propiedad
                                  {
                                      Name = p.Name,
                                      ValueType = p.PropertyType,
                                      DisplayName = p.CustomAttributes.First().NamedArguments.Where(n => n.MemberName == "Name").Select(n => n.TypedValue.Value).First().ToString(),
                                      Order = (int)p.CustomAttributes.First().NamedArguments.Where(n => n.MemberName == "Order").Select(n => n.TypedValue.Value).First()
                                  }).ToList();
            _columnas = properties.Where(p => p.Order > 0).OrderBy(p => p.Order).ToList();
            foreach (var columna in _columnas)
            {
                listViewFactura.Columns.Add(columna.DisplayName);
            }
        }

        private void CargarListView(List<Platos_Factura> listaDePlatos)
        {
            _platos = listaDePlatos.OrderBy(e => e.GetType().GetProperty(_ordenActual).GetValue(e)).ToList();
            var newListView = new List<ListViewItem>();
            foreach (Platos_Factura plato in _platos)
            {
                var row = "";
                foreach (var columna in _columnas)
                {
                    if (columna.Name.Contains("Fecha"))
                    {
                        var valor = (DateTime)plato.GetType().GetProperty(columna.Name).GetValue(plato);
                        row += valor.ToString("dd-MM-yyyy") + ",";
                    }
                    else
                    {
                        row += plato.GetType().GetProperty(columna.Name).GetValue(plato).ToString() + ",";
                    }
                }
                row = row.TrimEnd(',');
                newListView.Add(new ListViewItem(row.Split(',')));
            }
            listViewFactura.Items.Clear();
            listViewFactura.Items.AddRange(newListView.ToArray());
            listViewFactura.View = View.Details;
            listViewFactura.AjustarColumnas();
        }

        #endregion

    }
}
