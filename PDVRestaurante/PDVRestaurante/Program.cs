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

            var login = new Login();
            int tipo;
            if (login.ShowDialog() == DialogResult.OK)
            {
                tipo = login.tipo();
                switch (tipo)
                {
                    //SuperAdmin
                    case 1:
                    Application.Run(new Principal(login.usuario()));
                        break;
                    //Gerente
                    case 2:
                        //Application.Run(new Principal(login.usuario()));
                        break;
                        //Cajero
                    case 3:
                        //Application.Run(new Principal(login.usuario()));
                        break;
                        //Asistente
                    case 4:
                        //Application.Run(new Principal(login.usuario()));
                        break;
                        //Mesero
                    case 5:
                        //Application.Run(new Principal(login.usuario()));
                        break;
                        //Repartidor
                    case 6:
                        //Application.Run(new Principal(login.usuario()));
                        break;
                }
            } else
            {
                Application.Exit();
            }
        }
    }
}
