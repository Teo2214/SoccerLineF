using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoccerLineF
{

    /// <summary>
    /// Formulario para la consulta de fechas en el software SoccerLine.
    /// </summary>
    public partial class frmConsultaFecha : Form
    {

        /// <summary>
        /// Constructor del formulario.
        /// </summary>
        public frmConsultaFecha()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Maneja el evento de hacer clic en el botón "Consulta General".
        /// </summary>
        private void btnConsultaGeneral_Click(object sender, EventArgs e)
        {
            try
            {
                // Establecer conexión a la base de datos
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                // Crear una instancia de la clase clsRegistroCalendario para realizar la consulta general
                clsRegistroCalendario Consluta = new clsRegistroCalendario();
                dtgConsultaFechas.DataSource = Consluta.Consultar();
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR EN EL SISTEMA"); ;
            }
        }


        /// <summary>
        /// Maneja el evento de hacer clic en el botón "Consulta Específica".
        /// </summary
        private void btnConsultaEspecifica_Click(object sender, EventArgs e)
        {
            try
            {

                // Establecer conexión a la base de datos
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();


                // Verificar si se proporcionó una fecha específica para la consulta
                if (dtFechaCalendario.Text == "")
                {

                    // Crear una instancia de la clase clsRegistroCalendario para realizar la consulta general
                    clsRegistroCalendario consulta = new clsRegistroCalendario();
                    dtgConsultaFechas.DataSource = consulta.Consultar();
                }
                else
                {

                    // Crear una instancia de la clase clsRegistroCalendario para realizar la consulta por fecha específica
                    clsRegistroCalendario consulta = new clsRegistroCalendario();
                    dtgConsultaFechas.DataSource = consulta.Seleccionar(dtFechaCalendario.Value.Date);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR PRUEBA DE NUEVO EL ID, ASEGURATE QUE SI ESTE REGISTRADO");
            }
        }
    }
}
