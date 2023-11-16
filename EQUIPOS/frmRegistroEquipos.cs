using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoccerLineF
{
    public partial class frmRegistroEquipos : Form
    {
        
        public frmRegistroEquipos()
        {
            InitializeComponent();
        }

        private void btnRegistrarE_Click(object sender, EventArgs e)
        {
             
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();
                clsModificacionEquipoBd equipo = new clsModificacionEquipoBd(Convert.ToInt32(txtIdEquipo.Text),txtNombreEquipo.Text, txtUbicacionEquipo.Text, txtColoresEquipo.Text, Convert.ToInt32(txtTecnicoId.Text));
                equipo.InsertarDato();
                MessageBox.Show("EQUIPO REGISTRADO");
                dtgRegistroEquipos.DataSource = equipo.Consultar();
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR EN EL LOS DATOS, INGRESA LOS CAMPOS CORRECTAMENTE, RECUERDA QUE EL ID DEL TECNICO DEBE SER VALIDO");;
            }
            
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();
                clsModificacionEquipoBd modificar = new clsModificacionEquipoBd(Convert.ToInt32(txtIdEquipo.Text), txtNombreEquipo.Text, txtUbicacionEquipo.Text, txtColoresEquipo.Text, Convert.ToInt32(txtTecnicoId.Text));
                modificar.ModificarEquipo();
                MessageBox.Show("DATOS MODIFICADOS");
                dtgRegistroEquipos.DataSource = modificar.Consultar();
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR DE DATOS, VERIFICA TU ID");
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();
                clsModificacionEquipoBd elimina = new clsModificacionEquipoBd();
                elimina.EliminarEquipo(Convert.ToInt32(txtIdEquipo.Text));
                MessageBox.Show("EQUIPO ELIMINADO");
                dtgRegistroEquipos.DataSource = elimina.Consultar();
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR EN DATOS, RECUERDE QUE SI TIENE UN JUGADOR AFILIADO A ESTE EQUIPO, DEBE ELIMINARLO PRIMERO");
            }
            
        }

        private void dtgRegistroEquipos_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdEquipo.Text = dtgRegistroEquipos.SelectedRows[0].Cells[0].Value.ToString();
            txtNombreEquipo.Text = dtgRegistroEquipos.SelectedRows[0].Cells[1].Value.ToString();
            txtUbicacionEquipo.Text = dtgRegistroEquipos.SelectedRows[0].Cells[2].Value.ToString();
            txtColoresEquipo.Text = dtgRegistroEquipos.SelectedRows[0].Cells[3].Value.ToString();
            txtTecnicoId.Text = dtgRegistroEquipos.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void dtgRegistroEquipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmRegistroEquipos_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultaGeneral_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                clsModificacionEquipoBd Consluta = new clsModificacionEquipoBd();
                dtgRegistroEquipos.DataSource = Consluta.Consultar();
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR EN LOS DATOS"); ;
            }
        }
    }
}
