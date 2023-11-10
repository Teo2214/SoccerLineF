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
    public partial class frmRegistroResultados : Form
    {
        private static frmRegistroResultados insConsultaE;
        public static frmRegistroResultados ventanaEC()
        {
            if (insConsultaE == null)
            {
                insConsultaE = new frmRegistroResultados();
                return insConsultaE;
            }
            return insConsultaE;
        }

        public frmRegistroResultados()
        {
            InitializeComponent();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {

            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            clsResultadoBd jugadores = new clsResultadoBd(Convert.ToInt32(txtmarcadorLocal.Text), Convert.ToInt32(txtmarcadorVisitante.Text), txteventoDestacado.Text, Convert.ToInt32(txtpartidoID.Text));
                jugadores.InsertarDato();
                MessageBox.Show("RESULTADO REGISTRADO");
                dtgRegistroResultado.DataSource = jugadores.Consultar();
            

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            {
                
                    clsConexion conexion = new clsConexion();
                    conexion.abrirConexion();
                    clsResultadoBd elimina = new clsResultadoBd();
                    elimina.EliminarResultado(Convert.ToInt32(txtpartidoID.Text));
                    MessageBox.Show("RESULTADO ELIMINADO");
                    dtgRegistroResultado.DataSource = elimina.Consultar();
                
                
            }


        }

        private void frmRegistroResultados_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultaGeneral_Click(object sender, EventArgs e)
        {

            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();

            clsResultadoBd Consluta = new clsResultadoBd();
            dtgRegistroResultado.DataSource = Consluta.Consultar();
        }
    }
}
