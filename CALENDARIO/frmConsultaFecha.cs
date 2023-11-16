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
    // Constructor de la clase frmConsultaFecha
    public partial class frmConsultaFecha : Form
    {
        public frmConsultaFecha()
        {
            InitializeComponent();
        }
        // Evento al hacer clic en el botón de consulta general
        private void btnConsultaGeneral_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una instancia de la clase de conexión a la base de datos
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();
                // Crear una instancia de la clase clsRegistroCalendario para realizar la consulta
                clsRegistroCalendario Consluta = new clsRegistroCalendario();
               // Asignar el origen de datos al DataGridView con los resultados de la consulta general
                dtgConsultaFechas.DataSource = Consluta.Consultar();
            }
            catch (Exception)
            {
                // Manejar cualquier excepción y mostrar un mensaje de error
                MessageBox.Show("ERROR EN EL SISTEMA"); ;
            }
        }
        // Evento al hacer clic en el botón de consulta específica
        private void btnConsultaEspecifica_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una instancia de la clase de conexión a la base de datos.
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();
                
                // Verificar si se ha seleccionado una fecha específica

                if (dtFechaCalendario.Text == "")
                {
                    // Si no se ha seleccionado una fecha, realizar una consulta general
                    clsRegistroCalendario consulta = new clsRegistroCalendario();
                    dtgConsultaFechas.DataSource = consulta.Consultar();
                }
                else
                {
                    // Si se ha seleccionado una fecha, realizar una consulta específica
                    clsRegistroCalendario consulta = new clsRegistroCalendario();
                    dtgConsultaFechas.DataSource = consulta.Seleccionar(dtFechaCalendario.Value.Date);
                }
            }
            catch (Exception)
            {
                // Manejar cualquier excepción y mostrar un mensaje de error
                MessageBox.Show("ERROR PRUEBA DE NUEVO EL ID, ASEGURATE QUE SI ESTE REGISTRADO");
            }
        }
    }
}
