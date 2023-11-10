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
    public partial class frmConsultaTecnico : Form
    {
        public frmConsultaTecnico()
        {
            InitializeComponent();
        }

        private void btnConsultaGeneral_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                clsTecnicoBd Consluta = new clsTecnicoBd();
                dtgConsultaTecnicos.DataSource = Consluta.Consultar();
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

                if (txtIdTecnico.Text == "")
                {
                    clsTecnicoBd consulta = new clsTecnicoBd();
                    dtgConsultaTecnicos.DataSource = consulta.Consultar();
                }
                else
                {
                    clsTecnicoBd consulta = new clsTecnicoBd();
                    dtgConsultaTecnicos.DataSource = consulta.Seleccionar(Convert.ToInt32(txtIdTecnico.Text));
                }
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR DE DATOS");
            }
        }
    }
}
