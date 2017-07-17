using PDVRestaurante.Ayudantes;
using PDVRestaurante.BaseDatos;
using PDVRestaurante.Objetos;
using PDVRestaurante.Pantallas.Mantenimiento.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using PDVRestaurante.Constantes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDVRestaurante.Pantallas.Consultas
{
    public partial class ConsultaUsuarios : Form
    {
        private List<Propiedad> _columnas;
        private List<Usuario> _usuarios;
        private string _ordenActual = "Nombre";

        public ConsultaUsuarios()
        {
            InitializeComponent();

            InicializaListView();

            //Carga la lista de todos los usuarios            
            CargarListView(TablaUsuario.ObtenerUsuarios());

            //Carga la lista de posibles filtros para búsqueda
            comboBoxBuscar.Items.AddRange(_columnas.ToArray());
            comboBoxBuscar.DisplayMember = "DisplayName";

            //Carga la lista de posibles filtros para ordenar
            comboBoxOrdenar.Items.AddRange(_columnas.ToArray());
            comboBoxOrdenar.DisplayMember = "DisplayName";

            buttonBuscar.Enabled = false;
        }

        private void listViewUsuarios_Ajuste(object sender, EventArgs e)
        {
            listView.AjustarColumnas();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            //Realiza una búsqueda de empleado(s) basado en el filtro seleccionado
            var columna = (Propiedad)comboBoxBuscar.SelectedItem;
            var valor = textBoxBuscar.Text;

            //Define el criterio de comparación para enviar la consulta SQL adecuada
            var criterio = CriterioSQL.IgualA;
            if (columna.ValueType == typeof(string))
            {
                criterio = CriterioSQL.Contiene;
                valor = "'%" + valor + "%'";
            }
            if (columna.ValueType == typeof(DateTime))
            {
                valor = "'" + valor + "'";
            }

            //Para el filtro de sucursal, debe hacer la búsqueda según el Id de Sucursal
            if (columna.Name == "NombreSucursal")
            {
                criterio = CriterioSQL.IgualA;
                columna.Name = "IdSucursal";
                var sucursal = TablaSucursal.ObtenerSucursal("Detalle", valor);
                valor = sucursal == null ? "NULL" : sucursal.IdSucursal.ToString();
            }
            CargarListView(TablaUsuario.ObtenerUsuarios(columna.Name, valor, criterio));
        }

        private void buttonLimpiarFiltro_Click(object sender, EventArgs e)
        {
            //Limpia el filtro de búsqueda y carga el Grid de nuevo con todos los empleados
            comboBoxBuscar.ResetText();
            textBoxBuscar.Clear();
            CargarListView(TablaUsuario.ObtenerUsuarios());
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            //Para realizar una búsqueda por filtro tiene que haber algo escrito en el campo del valor del filtro
            buttonBuscar.Enabled = textBoxBuscar.Text.Length > 0;
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
       
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            this.CambiarPantalla("Mantenimiento.Usuarios", "CrearUsuario");
        }

        private void comboBoxOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            var columna = (Propiedad)comboBoxOrdenar.SelectedItem;
            _ordenActual = columna.Name;
            CargarListView(_usuarios);
        }


        #region Funciones
        private void InicializaListView()
        {
            listView.DoubleBuffer();
            var properties = typeof(Usuario).GetProperties().
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
                listView.Columns.Add(columna.DisplayName);
            }
        }

        private void CargarListView(List<Usuario> usuarios)
        {
            _usuarios = usuarios.OrderBy(e => e.GetType().GetProperty(_ordenActual).GetValue(e)).ToList();
            var newListView = new List<ListViewItem>();
            foreach (Usuario usuario in _usuarios)
            {
                var row = "";
                foreach (var columna in _columnas)
                {
                    if (columna.Name.Contains("Fecha"))
                    {
                        var valor = (DateTime)usuario.GetType().GetProperty(columna.Name).GetValue(usuario);
                        row += valor.ToString("dd-MM-yyyy") + "|";
                    }
                    else
                    {
                        row += usuario.GetType().GetProperty(columna.Name).GetValue(usuario).ToString() + "|";
                    }
                }
                row = row.TrimEnd(',');
                newListView.Add(new ListViewItem(row.Split('|')));
            }
            listView.Items.Clear();
            listView.Items.AddRange(newListView.ToArray());
            listView.View = View.Details;
            listView.AjustarColumnas();
        }
        #endregion

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
