using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoccerLineF
{
    public partial class frmJugadorConsulta : Form
    {
        public frmJugadorConsulta()
        {
            InitializeComponent();
        }

        private void btnConsultaGeneral_Click(object sender, EventArgs e)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();

            clsJugadoresBd Consluta = new clsJugadoresBd();
            dtgConsultaJugadores.DataSource = Consluta.Consultar();
        }

        private void btnConsultaEspecifica_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                if (txtIdJugador.Text == "")
                {
                    clsJugadoresBd consulta = new clsJugadoresBd();
                    dtgConsultaJugadores.DataSource = consulta.Consultar();
                }
                else
                {
                    clsJugadoresBd consulta = new clsJugadoresBd();
                    dtgConsultaJugadores.DataSource = consulta.SeleccionarJugador(Convert.ToInt32(txtIdJugador.Text));
                }
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR PRUEBA DE NUEVO EL ID, ASEGURATE QUE SI ESTE REGISTRADO");
            }
        }

        private void frmJugadorConsulta_Load(object sender, EventArgs e)
        {

        }
    }
}
