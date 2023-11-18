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

    /// <summary>
    /// Formulario para el registro, modificación, eliminación y consulta de fechas en el software SoccerLine.
    /// </summary>
    public partial class frmRegistroCalendario : Form
    {

        /// <summary>
        /// Constructor del formulario.
        /// </summary>
        public frmRegistroCalendario()
        {
            InitializeComponent();
            
        }


        /// <summary>
        /// Maneja el evento de hacer clic en el botón "Registrar Fecha".
        /// </summary>
        private void btnRegistrarF_Click(object sender, EventArgs e)
        {

            try
            {
                // Establecer conexión a la base de datos
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                // Crear una instancia de la clase clsRegistroCalendario para insertar una nueva fecha
                clsRegistroCalendario equipo = new clsRegistroCalendario(Convert.ToInt32(txtIdCalendario.Text), dtFechaCalendario.Value.Date, Convert.ToInt32(txtIdPartido.Text));
                equipo.InsertarDato();
                MessageBox.Show("FECHA REGISTRADA");
                // Actualizar la grilla con la información actualizada
                dtgRegistroCalendario.DataSource = equipo.Consultar();
            }
            catch (Exception)
            {

                MessageBox.Show("HAY UN ERROR EN LOS DATOS INGRESADOS, REVISA QUE EL PARTIDO EXISTA O EL ID SEA UNICO");
            }
                
            
        }

        /// <summary>
        /// Maneja el evento de hacer clic en el botón "Modificar".
        /// </summary>

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {

                // Establecer conexión a la base de datos
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();
                // Crear una instancia de la clase clsRegistroCalendario para modificar una fecha existente
                clsRegistroCalendario modificar = new clsRegistroCalendario(Convert.ToInt32(txtIdCalendario.Text), dtFechaCalendario.Value.Date, Convert.ToInt32(txtIdPartido.Text));
                modificar.Modificar();
                MessageBox.Show("DATOS MODIFICADOS");
                // Actualizar la grilla con la información actualizada
                dtgRegistroCalendario.DataSource = modificar.Consultar();
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL MODIFICAR, POR FAVOR VERIFICA EL ID O EL FORMATO DE LOS DATOS");
            }
        }

        /// <summary>
        /// Maneja el evento de hacer clic en el botón "Eliminar".
        /// </summary>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Establecer conexión a la base de datos
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();
                // Crear una instancia de la clase clsRegistroCalendario para eliminar una fecha
                clsRegistroCalendario elimina = new clsRegistroCalendario();
                elimina.Eliminar(Convert.ToInt32(txtIdCalendario.Text));
               
                MessageBox.Show("FECHA ELIMINADA");
                // Actualizar la grilla con la información actualizada
                dtgRegistroCalendario.DataSource = elimina.Consultar();
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR EN LOS DATOS INGRESADOS, REVISA EL ID DE LA FECHA A ELIMINAR");
            }
        }

        /// <summary>
        /// Maneja el evento de hacer clic en el botón "Consulta General".
        /// </summary>
        private void btnConsultaGeneral_Click(object sender, EventArgs e)
        {
            try
            {
                // Establecer conexión a la base de datos
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                // Crear una instancia de la clase clsRegistroCalendario para realizar una consulta general
                clsRegistroCalendario Consluta = new clsRegistroCalendario();
                dtgRegistroCalendario.DataSource = Consluta.Consultar();
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR EN EL SISTEMA"); ;
            }
        }

        /// <summary>
        /// Maneja el evento MouseClick en la grilla de fechas para cargar la información en los campos de texto.
        /// </summary>
        private void dtgRegistroCalendario_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdCalendario.Text = dtgRegistroCalendario.SelectedRows[0].Cells[0].Value.ToString();
            dtFechaCalendario.Text = dtgRegistroCalendario.SelectedRows[0].Cells[1].Value.ToString();
            txtIdPartido.Text = dtgRegistroCalendario.SelectedRows[0].Cells[2].Value.ToString();
            
        }
    }
}
