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
    public partial class frmConsultaResultado : Form
    {
        public frmConsultaResultado()
        {
            InitializeComponent();
        }

        private void btnConsultaGeneral_Click(object sender, EventArgs e)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();

            clsResultadoBd Consluta = new clsResultadoBd();
            dtgConsultaResultado.DataSource = Consluta.Consultar();
        }

        private void btnConsultaEspecifica_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                if (txtIdResultado.Text == "")
                {
                    clsResultadoBd consulta = new clsResultadoBd();
                    dtgConsultaResultado.DataSource = consulta.Consultar();
                }
                else
                {
                    clsResultadoBd consulta = new clsResultadoBd();
                    dtgConsultaResultado.DataSource = consulta.SeleccionarResultado(Convert.ToInt32(txtIdResultado.Text));
                }
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR EN LOS DATOS");
            }
        }
    }
}
