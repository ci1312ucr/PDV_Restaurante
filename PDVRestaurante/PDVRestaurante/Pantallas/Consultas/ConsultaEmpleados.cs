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

namespace PDVRestaurante.Pantallas.Consultas
{
    public partial class ConsultaEmpleados : Form
    {
        public ConsultaEmpleados()
        {
            InitializeComponent();

            //Carga el Grid con la lista de todos los empleados
            dataGridConsultaEmpleados.DataSource = TablaEmpleado.ObtenerEmpleados();
            dataGridConsultaEmpleados.ClearSelection();

            //Carga la lista de posibles filtros para búsqueda
            List<DataGridViewColumn> columnasFiltro = new List<DataGridViewColumn>();
            foreach(DataGridViewColumn c in dataGridConsultaEmpleados.Columns)
            {
                if (c.Visible == true)
                {
                    columnasFiltro.Add(c);
                }
            }
            comboBoxBuscarEmpleado.DataSource = columnasFiltro;
            comboBoxBuscarEmpleado.DisplayMember = "HeaderText";

            buttonBuscarEmpleado.Enabled = false;
        }

        private void buttonBuscarEmpleado_Click(object sender, EventArgs e)
        {
            //Realiza una búsqueda de empleado(s) basado en el filtro seleccionado
            var columna = (DataGridViewTextBoxColumn)comboBoxBuscarEmpleado.SelectedValue;
            var valor = textBoxBuscarEmpleado.Text;
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
            if (columna.DataPropertyName == "NombreSucursal")
            {
                criterio = CriterioSQL.IgualA;
                columna.DataPropertyName = "IdSucursal";
                var sucursal = TablaSucursal.ObtenerSucursal("Detalle", valor);
                valor = sucursal == null ? "NULL" : sucursal.IdSucursal.ToString();
            }
            dataGridConsultaEmpleados.DataSource = TablaEmpleado.ObtenerEmpleados(columna.DataPropertyName,valor,criterio);
            dataGridConsultaEmpleados.ClearSelection();
        }

        private void buttonLimpiarFiltro_Click(object sender, EventArgs e)
        {
            //Limpia el filtro de búsqueda y carga el Grid de nuevo con todos los empleados
            comboBoxBuscarEmpleado.ResetText();
            textBoxBuscarEmpleado.Clear();
            dataGridConsultaEmpleados.DataSource = TablaEmpleado.ObtenerEmpleados();
            dataGridConsultaEmpleados.ClearSelection();
        }

        private void textBoxBuscarEmpleado_TextChanged(object sender, EventArgs e)
        {
            //Para realizar una búsqueda por filtro tiene que haber algo escrito en el campo del valor del filtro
            buttonBuscarEmpleado.Enabled = textBoxBuscarEmpleado.Text.Length > 0;
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
