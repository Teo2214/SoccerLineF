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
    public partial class frmRegistroTecnico : Form
    {
        public frmRegistroTecnico()
        {
            InitializeComponent();
        }

        private void btnRegistrarT_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();
                clsTecnicoBd tecnico = new clsTecnicoBd(Convert.ToInt32(txtIdTecnico.Text), txtNombreTecnico.Text, txtApellido.Text, txtExpediente.Text);
                tecnico.InsertarDato();
                MessageBox.Show("TECNICO REGISTRADO");
                dtgRegistroTecnicos.DataSource = tecnico.Consultar();
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR EN EL SISTEMA O EN LOS DATOS"); ;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();
                clsTecnicoBd modificar = new clsTecnicoBd(Convert.ToInt32(txtIdTecnico.Text), txtNombreTecnico.Text, txtApellido.Text, txtExpediente.Text);
                modificar.Modificar();
                MessageBox.Show("DATOS MODIFICADOS");
                dtgRegistroTecnicos.DataSource = modificar.Consultar();
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR EN EL SISTEMA O EN LOS DATOS");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();
                clsTecnicoBd elimina = new clsTecnicoBd();
                elimina.Eliminar(Convert.ToInt32(txtIdTecnico.Text));
                MessageBox.Show("TECNICO ELIMINADO");
                dtgRegistroTecnicos.DataSource = elimina.Consultar();
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR EN DATOS, RECUERDE QUE SI TIENE UN EQUIPO AFILIADO A ESTE TECNICO DEBE ELIMINARLO PRIMERO");
            }
        }

        private void btnConsultaGeneral_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                clsTecnicoBd Consluta = new clsTecnicoBd();
                dtgRegistroTecnicos.DataSource = Consluta.Consultar();
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR EN LOS DATOS"); ;
            }
        }

        private void dtgRegistroTecnicos_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdTecnico.Text = dtgRegistroTecnicos.SelectedRows[0].Cells[0].Value.ToString();
            txtNombreTecnico.Text = dtgRegistroTecnicos.SelectedRows[0].Cells[1].Value.ToString();
            txtApellido.Text = dtgRegistroTecnicos.SelectedRows[0].Cells[2].Value.ToString();
            txtExpediente.Text = dtgRegistroTecnicos.SelectedRows[0].Cells[3].Value.ToString();
            
        }
    }
}
