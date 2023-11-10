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

        private void btnConsultaGneral_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                clsEstadisticasBd Consluta = new clsEstadisticasBd();
                dtgConsultarEstadisticaJugador.DataSource = Consluta.Consultar();
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR EN LOS DATOS"); ;
            }
        }

        private void btnConsultaEspecifica_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                if (txtconsultarID.Text == "")
                {
                    clsEstadisticasBd consulta = new clsEstadisticasBd();
                    dtgConsultarEstadisticaJugador.DataSource = consulta.Consultar();
                }
                else
                {
                    clsEstadisticasBd consulta = new clsEstadisticasBd();
                    dtgConsultarEstadisticaJugador.DataSource = consulta.Seleccionar(Convert.ToInt32(txtconsultarID.Text));
                }
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR DE DATOS");
            }
        }
    }
}
