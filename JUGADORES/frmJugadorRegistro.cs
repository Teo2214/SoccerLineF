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
    public partial class frmJugadorRegistro : Form
    {
        private static frmJugadorRegistro insConsultaE;
        public static frmJugadorRegistro ventanaEC()
        {
            if (insConsultaE == null)
            {
                insConsultaE = new frmJugadorRegistro();
                return insConsultaE;
            }
            return insConsultaE;
        }
        public frmJugadorRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistrarJ_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();
                clsJugadoresBd jugadores= new clsJugadoresBd(Convert.ToInt32(txtIdJugador.Text), txtNombreJugador.Text, txtApellidoJugador.Text, Convert.ToInt32(txtEdadJugador.Text), txtPosicionJugador.Text, Convert.ToInt32(txtIdEquipoJ.Text));
                jugadores.InsertarDato();
                MessageBox.Show("JUGADOR REGISTRADO");
                dtgRegistroJugador.DataSource = jugadores.Consultar();
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR EN LOS DATOS, VERIFICA EL ID DEL EQUIPO O EL CAMPO DE TUS DATOS"); ;
            }

        }

        private void btnModificarJ_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();
                clsJugadoresBd modificar = new clsJugadoresBd(Convert.ToInt32(txtIdJugador.Text), txtNombreJugador.Text, txtApellidoJugador.Text, Convert.ToInt32(txtEdadJugador.Text), txtPosicionJugador.Text, Convert.ToInt32(txtIdEquipoJ.Text));
                modificar.ModificarJugador();
                MessageBox.Show("DATOS MODIFICADOS");
                dtgRegistroJugador.DataSource = modificar.Consultar();
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR EN EL SISTEMA O EN LOS DATOS");
            }
        }

        private void btnEliminarJ_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();
                clsJugadoresBd elimina = new clsJugadoresBd();
                elimina.EliminarJugador(Convert.ToInt32(txtIdJugador.Text));
                MessageBox.Show("JUGADOR ELIMINADO");
                dtgRegistroJugador.DataSource = elimina.Consultar();
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR EN DATOS, RECUERDE QUE SI TIENE ESTADISTICAS DE ESTE JUGADOR, DEBE ELIMINARLAS PRIMERO");
            }
        }

        private void dtgRegistroJugador_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdJugador.Text = dtgRegistroJugador.SelectedRows[0].Cells[0].Value.ToString();
            txtNombreJugador.Text = dtgRegistroJugador.SelectedRows[0].Cells[1].Value.ToString();
            txtApellidoJugador.Text = dtgRegistroJugador.SelectedRows[0].Cells[2].Value.ToString();
            txtEdadJugador.Text = dtgRegistroJugador.SelectedRows[0].Cells[3].Value.ToString();
            txtPosicionJugador.Text = dtgRegistroJugador.SelectedRows[0].Cells[4].Value.ToString();
            txtIdEquipoJ.Text = dtgRegistroJugador.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void frmJugadorRegistro_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultaGeneral_Click(object sender, EventArgs e)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();

            clsJugadoresBd Consluta = new clsJugadoresBd();
            dtgRegistroJugador.DataSource = Consluta.Consultar();
        }
    }
}
