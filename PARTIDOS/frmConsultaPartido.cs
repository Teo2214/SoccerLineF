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
    public partial class frmConsultaPartido : Form
    {
        public frmConsultaPartido()
        {
            InitializeComponent();
        }

        private void btnConsultaGeneral_Click(object sender, EventArgs e)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();

            clsPartidosBd Consluta = new clsPartidosBd();
            dtgConsultaPartidos.DataSource = Consluta.Consultar();
        }

        private void btnConsultaEspecifica_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                if (txtIdPartido.Text == "")
                {
                    clsPartidosBd consulta = new clsPartidosBd();
                    dtgConsultaPartidos.DataSource = consulta.Consultar();
                }
                else
                {
                    clsPartidosBd consulta = new clsPartidosBd();
                    dtgConsultaPartidos.DataSource = consulta.SeleccionarPartido(Convert.ToInt32(txtIdPartido.Text));
                }
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR PRUEBA DE NUEVO EL ID, ASEGURATE QUE SI ESTE REGISTRADO");
            }
        }

        private void dtgConsultaPartidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
