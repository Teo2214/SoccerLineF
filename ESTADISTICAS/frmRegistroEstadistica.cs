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
    public partial class frmRegistroEstadistica : Form
    {
        public frmRegistroEstadistica()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();
                clsEstadisticasBd ingresar = new clsEstadisticasBd(Convert.ToInt32(txtEstadisticaID.Text), Convert.ToInt32(txtJugadorId.Text), Convert.ToInt32(txtPartidoId.Text), Convert.ToInt32(txtpuntos.Text), Convert.ToInt32(txtrebotes.Text), Convert.ToInt32(txtasistencia.Text));
                ingresar.InsertarDato();
                MessageBox.Show("ESTADISTICA REGISTRADA");
                dtgRegistroEstadisticaJugadores.DataSource = ingresar.Consultar();
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR EN EL SISTEMA O EN LOS DATOS"); ;
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();
                clsEstadisticasBd modificar = new clsEstadisticasBd(Convert.ToInt32(txtEstadisticaID.Text), Convert.ToInt32(txtJugadorId.Text), Convert.ToInt32(txtPartidoId.Text), Convert.ToInt32(txtpuntos.Text), Convert.ToInt32(txtrebotes.Text), Convert.ToInt32(txtasistencia.Text));
                modificar.Modificar();
                MessageBox.Show("DATOS MODIFICADOS");
                dtgRegistroEstadisticaJugadores.DataSource = modificar.Consultar();
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL MODIFICAR");
            }
               
            
        }

        private void btneliminarEstadistica_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();
                clsEstadisticasBd elimina = new clsEstadisticasBd();
                elimina.Eliminar(Convert.ToInt32(txtEstadisticaID.Text));
                MessageBox.Show("ESTADISTICA ELIMINADA");
                dtgRegistroEstadisticaJugadores.DataSource = elimina.Consultar();
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR EN EL SISTEMA O EN LOS DATOS");
            }
        }

        private void btnConsultaGenral_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                clsEstadisticasBd Consluta = new clsEstadisticasBd();
                dtgRegistroEstadisticaJugadores.DataSource = Consluta.Consultar();
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR EN LOS DATOS"); ;
            }
        }

        private void dtgRegistroEstadisticaJugadores_MouseClick(object sender, MouseEventArgs e)
        {
            txtEstadisticaID.Text = dtgRegistroEstadisticaJugadores.SelectedRows[0].Cells[0].Value.ToString();
            txtJugadorId.Text = dtgRegistroEstadisticaJugadores.SelectedRows[0].Cells[1].Value.ToString();
            txtPartidoId.Text = dtgRegistroEstadisticaJugadores.SelectedRows[0].Cells[2].Value.ToString();
            txtpuntos.Text = dtgRegistroEstadisticaJugadores.SelectedRows[0].Cells[3].Value.ToString();
            txtrebotes.Text = dtgRegistroEstadisticaJugadores.SelectedRows[0].Cells[4].Value.ToString();
            txtasistencia.Text = dtgRegistroEstadisticaJugadores.SelectedRows[0].Cells[5].Value.ToString();
        }
    }
}
