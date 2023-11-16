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


    public partial class frmConsultaEstadistica : Form
    {
        public frmConsultaEstadistica()
        {
            InitializeComponent();
        }
        
        // Método que se ejecuta al hacer clic en el botón "Consulta General"
        private void btnConsultaGneral_Click(object sender, EventArgs e)
        {
            try
            {
                // Se instancia la clase de conexión a la base de datos
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();


                // Se crea un objeto clsEstadisticasBd para realizar la consulta
                clsEstadisticasBd Consluta = new clsEstadisticasBd();

                // Se obtienen los datos de la consulta y se actualiza el DataGridView con esos datos
                dtgConsultarEstadisticaJugador.DataSource = Consluta.Consultar();
            }
            catch (Exception)
            {
                // Se muestra un mensaje de error en caso de problemas con los datos o la conexión
                MessageBox.Show("ERROR EN LOS DATOS"); ;
            }
        }

        // Método que se ejecuta al hacer clic en el botón "Consulta Específica"
        private void btnConsultaEspecifica_Click(object sender, EventArgs e)
        {
            try
            {
                // Se instancia la clase de conexión a la base de datos
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                // Se verifica si el campo de texto "txtconsultarID" está vacío
                if (txtconsultarID.Text == "")
                {
                    // Si está vacío, se realiza una consulta general y se actualiza el DataGridView
                    clsEstadisticasBd consulta = new clsEstadisticasBd();
                    dtgConsultarEstadisticaJugador.DataSource = consulta.Consultar();
                }
                else
                {
                    // Si no está vacío, se realiza una consulta específica por ID y se actualiza el DataGridView
                    clsEstadisticasBd consulta = new clsEstadisticasBd();
                    dtgConsultarEstadisticaJugador.DataSource = consulta.Seleccionar(Convert.ToInt32(txtconsultarID.Text));
                }
            }
            catch (Exception)
            {
                // Se muestra un mensaje de error en caso de problemas con los datos o la conexión
                MessageBox.Show("ERROR DE DATOS");
            }
        }
    }
}
