using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoccerLineF
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Habilita los estilos visuales de la aplicación.
            Application.EnableVisualStyles();

            // Establece el valor predeterminado para la representación de texto compatible con Windows.
            Application.SetCompatibleTextRenderingDefault(false);
            // Ejecuta la aplicación, mostrando la ventana de inicio (frmInicio).
            Application.Run(new frmInicio());
        }
    }
}
