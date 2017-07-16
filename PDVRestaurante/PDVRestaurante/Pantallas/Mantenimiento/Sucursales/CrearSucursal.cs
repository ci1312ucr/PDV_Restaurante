using System;
using PDVRestaurante.Ayudantes;
using PDVRestaurante.BaseDatos;
using PDVRestaurante.Objetos;
using System.Collections.Generic;
using System.ComponentModel;
using PDVRestaurante.Constantes;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDVRestaurante.Pantallas.Mantenimiento.Sucursales
{
    public partial class CrearSucursal : Form
    {
        public CrearSucursal()
        {
            InitializeComponent();
            comboBoxProvincia.DataSource = TablaProvincia.ObtenerProvincias();
            comboBoxProvincia.DisplayMember = "Descripcion";
        }

        private void comboBoxProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            var provincia = (Provincia)comboBoxProvincia.SelectedItem;
            comboBoxCanton.DataSource = TablaCanton.ObtenerCantones("IdProvincia",provincia.IdProvincia.ToString(),CriterioSQL.IgualA);
            comboBoxCanton.DisplayMember = "Descripcion";
        }

        private void comboBoxCanton_SelectedIndexChanged(object sender, EventArgs e)
        {
            var provincia = (Provincia)comboBoxProvincia.SelectedItem;
            var canton = (Canton)comboBoxCanton.SelectedItem;
            comboBoxDistrito.DataSource = TablaDistrito.ObtenerDistritos("IdProvincia|IdCanton",provincia.IdProvincia.ToString() + "|" + canton.IdCanton.ToString(),CriterioSQL.IgualA + "|" + CriterioSQL.IgualA);
            comboBoxDistrito.DisplayMember = "Descripcion";
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            try
            {
                var provincia = (Provincia)comboBoxProvincia.SelectedItem;
                var canton = (Canton)comboBoxCanton.SelectedItem;
                var distrito = (Distrito)comboBoxDistrito.SelectedItem;
                int idSucursal = TablaSucursal.ObtenerIdSucursal();
                if (TablaSucursal.InsertarSucursal(idSucursal, DateTime.Today, distrito.IdDistrito, canton.IdCanton, provincia.IdProvincia, textBoxDetalle.Text.ToLower()))
                {
                    MessageBox.Show("Se agregó la nueva sucursal exitosamente", "Nueva sucursal creada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    throw new Exception("Error insertando la sucursal en la base de datos");
                }
            }
            catch (Exception ex)
            {
                ManejoExcepciones.LogearExcepcion(ex);
                MessageBox.Show("Se produjo un error al tratar de crear la sucursal", "Error al crear sucursal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
