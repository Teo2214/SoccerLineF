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
        // Constructor de la clase frmRegistroCalendario
        public frmRegistroCalendario()
        {
            InitializeComponent();
            
        }
        // Evento al hacer clic en el botón de registrar fecha.
        private void btnRegistrarF_Click(object sender, EventArgs e)
        {

            try
            {
                // Crear una instancia de la clase de conexión a la base de datos.
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();
                // Crear una instancia de la clase clsRegistroCalendario para registrar la fecha.
                clsRegistroCalendario equipo = new clsRegistroCalendario(Convert.ToInt32(txtIdCalendario.Text), dtFechaCalendario.Value.Date, Convert.ToInt32(txtIdPartido.Text));
                // Insertar la fecha en la base de datos.
                equipo.InsertarDato();
                MessageBox.Show("FECHA REGISTRADA");
                // Mostrar los datos actualizados en el DataGridView.
                dtgRegistroCalendario.DataSource = equipo.Consultar();
            }
            catch (Exception)
            {
                // Manejar cualquier excepción y mostrar un mensaje de error.
                MessageBox.Show("HAY UN ERROR EN LOS DATOS INGRESADOS, REVISA QUE EL PARTIDO EXISTA O EL ID SEA UNICO");
            }
                
            
        }
        // Evento al hacer clic en el botón de modificar fecha.
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una instancia de la clase de conexión a la base de datos.
                clsConexion conexion = new clsConexion();
                
                // Crear una instancia de la clase clsRegistroCalendario para modificar la fecha.
                conexion.abrirConexion();
                clsRegistroCalendario modificar = new clsRegistroCalendario(Convert.ToInt32(txtIdCalendario.Text), dtFechaCalendario.Value.Date, Convert.ToInt32(txtIdPartido.Text));
                
                // Modificar la fecha en la base de datos.
                modificar.Modificar();
                MessageBox.Show("DATOS MODIFICADOS");

                // Mostrar los datos actualizados en el DataGridView
                dtgRegistroCalendario.DataSource = modificar.Consultar();
            }
            catch (Exception)
            {
                // Manejar cualquier excepción y mostrar un mensaje de error
                MessageBox.Show("ERROR AL MODIFICAR, POR FAVOR VERIFICA EL ID O EL FORMATO DE LOS DATOS");
            }
        }

        // Evento al hacer clic en el botón de eliminar fecha
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una instancia de la clase de conexión a la base de datos
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                // Crear una instancia de la clase clsRegistroCalendario para eliminar la fecha
                clsRegistroCalendario elimina = new clsRegistroCalendario();


                // Eliminar la fecha de la base de datos
                elimina.Eliminar(Convert.ToInt32(txtIdCalendario.Text));
                MessageBox.Show("FECHA ELIMINADA");

                // Mostrar los datos actualizados en el DataGridView
                dtgRegistroCalendario.DataSource = elimina.Consultar();
            }
            catch (Exception)
            {
                // Manejar cualquier excepción y mostrar un mensaje de error
                MessageBox.Show("ERROR EN LOS DATOS INGRESADOS, REVISA EL ID DE LA FECHA A ELIMINAR");
            }
        }

        // Evento al hacer clic en el botón de consulta general
        private void btnConsultaGeneral_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una instancia de la clase de conexión a la base de datos
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                // Crear una instancia de la clase clsRegistroCalendario para realizar la consulta general
                clsRegistroCalendario Consluta = new clsRegistroCalendario();

                // Asignar el origen de datos al DataGridView con los resultados de la consulta general
                dtgRegistroCalendario.DataSource = Consluta.Consultar();
            }
            catch (Exception)
            {
                // Manejar cualquier excepción y mostrar un mensaje de error
                MessageBox.Show("ERROR EN EL SISTEMA"); ;
            }
        }

        // Evento al hacer clic en una fila del DataGridView
        private void dtgRegistroCalendario_MouseClick(object sender, MouseEventArgs e)
        {
            // Asignar valores de la fila seleccionada a los campos de texto
            txtIdCalendario.Text = dtgRegistroCalendario.SelectedRows[0].Cells[0].Value.ToString();
            dtFechaCalendario.Text = dtgRegistroCalendario.SelectedRows[0].Cells[1].Value.ToString();
            txtIdPartido.Text = dtgRegistroCalendario.SelectedRows[0].Cells[2].Value.ToString();
            
        }
    }
}
