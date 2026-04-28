using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_integrador
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (true)
            {
                using (var login = new frmLogin())
                {
                    if (login.ShowDialog() != DialogResult.OK)
                    {
                        break; // fechou ou cancelou → encerra a aplicação
                    }
                }

                Application.Run(new FormHome());
                // Quando o FormHome fecha (logout), volta para o login
            }
        }
    }
}

