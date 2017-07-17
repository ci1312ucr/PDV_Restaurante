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

        public static void CambiarPantalla<TipoPantalla>(this Form formActual, string nombreSiguienteForm, params object[] args)
        {
            var siguienteForm = formActual.ParentForm.MdiChildren.ToList().Find(f => f.Name == nombreSiguienteForm);
            if (siguienteForm == null)
            {
                var tipo = typeof(TipoPantalla);
                var pantallaSiguiente = new Form();
                pantallaSiguiente = (Form)Activator.CreateInstance(tipo, args);
                pantallaSiguiente.MdiParent = formActual.ParentForm;
                pantallaSiguiente.Dock = DockStyle.Fill;
                pantallaSiguiente.StartPosition = FormStartPosition.CenterParent;
                formActual.Hide();
                pantallaSiguiente.Show();
            }
            else
            {
                formActual.Hide();
                siguienteForm.Show();
            }
        }
    }
}
