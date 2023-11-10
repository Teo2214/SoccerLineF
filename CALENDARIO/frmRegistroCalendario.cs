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
    public partial class frmRegistroCalendario : Form
    {
        public frmRegistroCalendario()
        {
            InitializeComponent();
            
        }

        private void btnRegistrarF_Click(object sender, EventArgs e)
        {

            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();
                clsRegistroCalendario equipo = new clsRegistroCalendario(Convert.ToInt32(txtIdCalendario.Text), dtFechaCalendario.Value.Date, Convert.ToInt32(txtIdPartido.Text));
                equipo.InsertarDato();
                MessageBox.Show("FECHA REGISTRADA");
                dtgRegistroCalendario.DataSource = equipo.Consultar();
            }
            catch (Exception)
            {

                MessageBox.Show("HAY UN ERROR EN LOS DATOS INGRESADOS, REVISA QUE EL PARTIDO EXISTA O EL ID SEA UNICO");
            }
                
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();
                clsRegistroCalendario modificar = new clsRegistroCalendario(Convert.ToInt32(txtIdCalendario.Text), dtFechaCalendario.Value.Date, Convert.ToInt32(txtIdPartido.Text));
                modificar.Modificar();
                MessageBox.Show("DATOS MODIFICADOS");
                dtgRegistroCalendario.DataSource = modificar.Consultar();
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL MODIFICAR, POR FAVOR VERIFICA EL ID O EL FORMATO DE LOS DATOS");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();
                clsRegistroCalendario elimina = new clsRegistroCalendario();
                elimina.Eliminar(Convert.ToInt32(txtIdCalendario.Text));
                MessageBox.Show("FECHA ELIMINADA");
                dtgRegistroCalendario.DataSource = elimina.Consultar();
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR EN LOS DATOS INGRESADOS, REVISA EL ID DE LA FECHA A ELIMINAR");
            }
        }

        private void btnConsultaGeneral_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                clsRegistroCalendario Consluta = new clsRegistroCalendario();
                dtgRegistroCalendario.DataSource = Consluta.Consultar();
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR EN EL SISTEMA"); ;
            }
        }

        private void dtgRegistroCalendario_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdCalendario.Text = dtgRegistroCalendario.SelectedRows[0].Cells[0].Value.ToString();
            dtFechaCalendario.Text = dtgRegistroCalendario.SelectedRows[0].Cells[1].Value.ToString();
            txtIdPartido.Text = dtgRegistroCalendario.SelectedRows[0].Cells[2].Value.ToString();
            
        }
    }
}
