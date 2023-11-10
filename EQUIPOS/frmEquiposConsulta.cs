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
    public partial class frmEquiposConsulta : Form
    {
        private static frmEquiposConsulta insConsultaE;
        public static frmEquiposConsulta ventanaEC()
        {
            if (insConsultaE==null)
            {
                insConsultaE = new frmEquiposConsulta();
                return insConsultaE;
            }
            return insConsultaE;
        }

        public frmEquiposConsulta()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultaGeneral_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                clsModificacionEquipoBd Consluta = new clsModificacionEquipoBd();
                dtgConsultaEquipos.DataSource = Consluta.Consultar();
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR EN LOS DATOS");;
            }
            

        }

        private void btnConsultaEspecifica_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                if (txtIdEquipo.Text == "")
                {
                    clsModificacionEquipoBd consulta = new clsModificacionEquipoBd();
                    dtgConsultaEquipos.DataSource=consulta.Consultar();
                }
                else
                {
                    clsModificacionEquipoBd consulta = new clsModificacionEquipoBd();
                    dtgConsultaEquipos.DataSource= consulta.SeleccionarEquipo(Convert.ToInt32(txtIdEquipo.Text));
                }
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR, PRUEBA DE NUEVO EL ID, ASEGURATE QUE SI ESTE REGISTRADO");
            }
            
            
            
        }

        private void panelLateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmEquiposConsulta_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
