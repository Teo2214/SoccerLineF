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

        // Método para registrar un nuevo equipo.
        private void btnRegistrarE_Click(object sender, EventArgs e)
        {
             
            try
            {
                // Se instancia la clase de conexión a la base de datos.
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();
                // Se crea un objeto clsModificacionEquipoBd con los datos proporcionados.
                clsModificacionEquipoBd equipo = new clsModificacionEquipoBd(Convert.ToInt32(txtIdEquipo.Text),txtNombreEquipo.Text, txtUbicacionEquipo.Text, txtColoresEquipo.Text, Convert.ToInt32(txtTecnicoId.Text));

                // Se insertan los datos en la base de datos.
                equipo.InsertarDato();

                // Se muestra un mensaje de éxito y se actualiza el DataGridView con los datos actualizados.
                MessageBox.Show("EQUIPO REGISTRADO");
                dtgRegistroEquipos.DataSource = equipo.Consultar();
            }
            catch (Exception)
            {
                // Se muestra un mensaje de error en caso de problemas con los datos.
                MessageBox.Show("ERROR EN EL LOS DATOS, INGRESA LOS CAMPOS CORRECTAMENTE, RECUERDA QUE EL ID DEL TECNICO DEBE SER VALIDO");;
            }
            
            
        }
        // Método para modificar los datos de un equipo existente
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {

                // Se instancia la clase de conexión a la base de datos
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                // Se crea un objeto clsModificacionEquipoBd con los datos proporcionados
                clsModificacionEquipoBd modificar = new clsModificacionEquipoBd(Convert.ToInt32(txtIdEquipo.Text), txtNombreEquipo.Text, txtUbicacionEquipo.Text, txtColoresEquipo.Text, Convert.ToInt32(txtTecnicoId.Text));

                // Se modifican los datos en la base de datos
                modificar.ModificarEquipo();

                // Se muestra un mensaje de éxito y se actualiza el DataGridView con los datos actualizados
                MessageBox.Show("DATOS MODIFICADOS");
                dtgRegistroEquipos.DataSource = modificar.Consultar();
            }
            catch (Exception)
            {
                // Se muestra un mensaje de error en caso de problemas con los datos
                MessageBox.Show("ERROR DE DATOS, VERIFICA TU ID");
            }
            
        }

        // Método para eliminar un equipo.
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se instancia la clase de conexión a la base de datos
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                // Se crea un objeto clsModificacionEquipoBd
                clsModificacionEquipoBd elimina = new clsModificacionEquipoBd();

                // Se eliminan los datos en la base de datos
                elimina.EliminarEquipo(Convert.ToInt32(txtIdEquipo.Text));

                // Se muestra un mensaje de éxito y se actualiza el DataGridView con los datos actualizados
                MessageBox.Show("EQUIPO ELIMINADO");
                dtgRegistroEquipos.DataSource = elimina.Consultar();
            }
            catch (Exception)
            {


                // Se muestra un mensaje de error en caso de problemas con los datos
                MessageBox.Show("ERROR EN DATOS, RECUERDE QUE SI TIENE UN JUGADOR AFILIADO A ESTE EQUIPO, DEBE ELIMINARLO PRIMERO");
            }
            
        }


        // Método que se ejecuta al hacer clic en una celda del DataGridView, carga los datos en los campos de texto
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


        // Método que se ejecuta al cargar el formulario, actualiza el DataGridView con los datos actuales
        private void btnConsultaGeneral_Click(object sender, EventArgs e)
        {
            try
            {
                // Se instancia la clase de conexión a la base de datos
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();


                // Se crea un objeto clsModificacionEquipoBd para realizar la consulta
                clsModificacionEquipoBd Consluta = new clsModificacionEquipoBd();

                // Se obtienen los datos de la consulta y se actualiza el DataGridView con esos datos
                dtgRegistroEquipos.DataSource = Consluta.Consultar();
            }
            catch (Exception)
            {

                // Se muestra un mensaje de error en caso de problemas con los datos o la conexión

                MessageBox.Show("ERROR EN LOS DATOS"); ;
            }
        }
    }
}
