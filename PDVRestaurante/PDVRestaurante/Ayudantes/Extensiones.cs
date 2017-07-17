using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDVRestaurante.Ayudantes
{
    public static class Extensiones
    {
        public static void DoubleBuffer(this Control control)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession) return;
            System.Reflection.PropertyInfo dbProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            dbProp.SetValue(control, true, null);
        }

        public static void AjustarColumnas(this ListView listView)
        {
            var columnWidth = listView.Width / listView.Columns.Count;
            foreach(ColumnHeader column in listView.Columns)
            {
                column.Width = columnWidth;
            }
        }

        public static void CambiarPantalla(this Form pantallaActual, string areaPantalla, string nombrePantalla, params object[] args)
        {
            Form formPadre;
            if (pantallaActual.IsMdiContainer)
            {
                formPadre = pantallaActual;
            } else
            {
                formPadre = pantallaActual.ParentForm;
            }
            var siguienteForm = formPadre.MdiChildren.ToList().Find(f => f.Name == nombrePantalla);
            if (siguienteForm == null)
            {
                var pantallaType = Type.GetType("PDVRestaurante.Pantallas." + areaPantalla + "." + nombrePantalla);
                if (pantallaType != null)
                {
                    try
                    {
                        formPadre.EsconderPantallasHijo();

                        var pantallaSiguiente = new Form();
                        pantallaSiguiente = (Form)Activator.CreateInstance(pantallaType, args);
                        pantallaSiguiente.MdiParent = formPadre;
                        pantallaSiguiente.FormBorderStyle = FormBorderStyle.None;
                        pantallaSiguiente.Dock = DockStyle.Fill;
                        pantallaSiguiente.StartPosition = FormStartPosition.CenterParent;
                        pantallaSiguiente.WindowState = FormWindowState.Maximized;
                        pantallaSiguiente.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Se produjo un error al tratar de abrir la pantalla >> " + ex.Message, "Error al abrir pantalla", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                formPadre.EsconderPantallasHijo();
                siguienteForm.Show();
            }
        }

        public static void EsconderPantallasHijo(this Form formPadre)
        {
            foreach(var form in formPadre.MdiChildren)
            {
                form.Hide();
            }
        }
    }
}
