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
    public partial class frmConsultaFecha : Form
    {
        public frmConsultaFecha()
        {
            InitializeComponent();
        }

        private void btnConsultaGeneral_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                clsRegistroCalendario Consluta = new clsRegistroCalendario();
                dtgConsultaFechas.DataSource = Consluta.Consultar();
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR EN EL SISTEMA"); ;
            }
        }

        private void btnConsultaEspecifica_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                if (dtFechaCalendario.Text == "")
                {
                    clsRegistroCalendario consulta = new clsRegistroCalendario();
                    dtgConsultaFechas.DataSource = consulta.Consultar();
                }
                else
                {
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
