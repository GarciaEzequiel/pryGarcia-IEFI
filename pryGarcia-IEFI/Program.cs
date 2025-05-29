//using pryGarcia_IEFI.DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGarcia_IEFI
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                // Ejecuta la migración de la base de datos al iniciar
                clsConexion.EjecutarScriptMigracion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar la base de datos:\n" + ex.Message);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
