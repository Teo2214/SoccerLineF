using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoccerLineF
{
    /// <summary>
    /// Clase principal que contiene el punto de entrada principal para la aplicación.
    /// </summary>
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
            // Establece la compatibilidad predeterminada para el rendimiento de representación de texto.
            Application.SetCompatibleTextRenderingDefault(false);
            // Ejecuta la aplicación y muestra la interfaz de usuario inicial (frmInicio).
            Application.Run(new frmInicio());
        }
    }
}
