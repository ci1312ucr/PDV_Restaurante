using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDVRestaurante
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            Login login = new Login();
            DialogResult res = DialogResult.OK;
            // si el ususario elige "cerrar sesión" el código es OK, si elige "salir de la aplicación" es Abort
            while (login.ShowDialog() == DialogResult.OK && res == DialogResult.OK)
            {
                login.Hide();
                switch (login.usuario().IdTipoUsuario)
                {
                    case 1:
                        // superadmin
                        PantallaAdmin admin = new PantallaAdmin(login.usuario());
                        res = admin.ShowDialog();
                        break;

                    case 2:
                        // gerente
                        PantallaGerente ger = new PantallaGerente(login.usuario());
                        res = ger.ShowDialog();
                        break;

                    case 3:
                        // cajero
                        PantallaCajero caj = new PantallaCajero(login.usuario());
                        res = caj.ShowDialog();
                        break;
                }
                if (res == DialogResult.Abort)
                {
                    // terminar ejecución si elige "salir de la aplicación" 
                    Environment.Exit(0);
                }
            }
        }
    }
}
