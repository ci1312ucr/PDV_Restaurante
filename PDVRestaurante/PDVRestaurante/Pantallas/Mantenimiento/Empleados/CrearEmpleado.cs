using System;
using PDVRestaurante.Ayudantes;
using PDVRestaurante.BaseDatos;
using PDVRestaurante.Objetos;
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
    public partial class CrearEmpleado : Form
    {
        public CrearEmpleado()
        {
            InitializeComponent();
            comboBoxCedula.DataSource = TablaPersona.ObtenerPersonas();
            comboBoxCedula.DisplayMember = "Cedula";
            comboBoxSucursal.DataSource = TablaSucursal.ObtenerSucursales();
            comboBoxSucursal.DisplayMember = "Detalle";

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {

            try
            {
                var persona = (Persona)comboBoxCedula.SelectedItem;
                var sucursal = (Sucursal)comboBoxSucursal.SelectedItem;
                if (TablaEmpleado.InsertarEmpleado(persona.Cedula,textBoxTipoE.Text,Convert.ToDecimal(textBoxSalario.Text),
                                                   sucursal.IdSucursal,DateTime.Now))
                {
                    MessageBox.Show("Se agregó el nuevo empleado exitosamente", "Nuevo empleado creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    throw new Exception("Error insertando el empleado en la base de datos");
                }
            }
            catch (Exception ex)
            {
                ManejoExcepciones.LogearExcepcion(ex);
                MessageBox.Show("Se produjo un error al tratar de empleado el usuario", "Error al crear empelado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
