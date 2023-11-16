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

        // Método que se ejecuta al hacer clic en el botón "Ingresar"
        private void btningresar_Click(object sender, EventArgs e)
        {
            try
            {

                // Se instancia la clase de conexión a la base de datos
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                // Se crea un objeto clsEstadisticasBd para insertar los datos de la estadística
                clsEstadisticasBd ingresar = new clsEstadisticasBd(Convert.ToInt32(txtEstadisticaID.Text), Convert.ToInt32(txtJugadorId.Text), Convert.ToInt32(txtPartidoId.Text), Convert.ToInt32(txtpuntos.Text), Convert.ToInt32(txtrebotes.Text), Convert.ToInt32(txtasistencia.Text));
                ingresar.InsertarDato();

                // Se insertan los datos y se muestra un mensaje de éxito
                MessageBox.Show("ESTADISTICA REGISTRADA");

                // Se actualiza el DataGridView con los nuevos datos
                dtgRegistroEstadisticaJugadores.DataSource = ingresar.Consultar();
            }
            catch (Exception)
            {
                // Se muestra un mensaje de error en caso de problemas con los datos o la conexión
                MessageBox.Show("ERROR EN EL SISTEMA O EN LOS DATOS"); ;
            }
        }

        // Método que se ejecuta al hacer clic en el botón "Modificar"
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se instancia la clase de conexión a la base de datos
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                // Se crea un objeto clsEstadisticasBd para modificar los datos de la estadística
                clsEstadisticasBd modificar = new clsEstadisticasBd(Convert.ToInt32(txtEstadisticaID.Text), Convert.ToInt32(txtJugadorId.Text), Convert.ToInt32(txtPartidoId.Text), Convert.ToInt32(txtpuntos.Text), Convert.ToInt32(txtrebotes.Text), Convert.ToInt32(txtasistencia.Text));
                modificar.Modificar();

                // Se modifican los datos y se muestra un mensaje de éxito
                MessageBox.Show("DATOS MODIFICADOS");

                // Se actualiza el DataGridView con los datos modificados
                dtgRegistroEstadisticaJugadores.DataSource = modificar.Consultar();
            }
            catch (Exception)
            {
                // Se muestra un mensaje de error en caso de problemas con los datos o la conexión
                MessageBox.Show("ERROR AL MODIFICAR");
            }
               
            
        }

        // Método que se ejecuta al hacer clic en el botón "Eliminar Estadistica"
        private void btneliminarEstadistica_Click(object sender, EventArgs e)
        {
            try
            {
                // Se instancia la clase de conexión a la base de datos
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                // Se crea un objeto clsEstadisticasBd para eliminar la estadística por ID
                clsEstadisticasBd elimina = new clsEstadisticasBd();

                // Se elimina la estadística y se muestra un mensaje de éxito
                elimina.Eliminar(Convert.ToInt32(txtEstadisticaID.Text));
                MessageBox.Show("ESTADISTICA ELIMINADA");

                // Se actualiza el DataGridView después de eliminar la estadística
                dtgRegistroEstadisticaJugadores.DataSource = elimina.Consultar();
            }
            catch (Exception)
            {
                // Se muestra un mensaje de error en caso de problemas con los datos o la conexión
                MessageBox.Show("ERROR EN EL SISTEMA O EN LOS DATOS");
            }
        }

        // Método que se ejecuta al hacer clic en el botón "Consulta General"
        private void btnConsultaGenral_Click(object sender, EventArgs e)
        {
            try
            {
                // Se instancia la clase de conexión a la base de datos
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                // Se crea un objeto clsEstadisticasBd para realizar una consulta general
                clsEstadisticasBd Consluta = new clsEstadisticasBd();

                // Se obtienen los datos de la consulta y se actualiza el DataGridView con esos datos
                dtgRegistroEstadisticaJugadores.DataSource = Consluta.Consultar();
            }
            catch (Exception)
            {
                // Se muestra un mensaje de error en caso de problemas con los datos o la conexión
                MessageBox.Show("ERROR EN LOS DATOS"); ;
            }
        }

        // Método que se ejecuta al hacer clic en una fila del DataGridView
        private void dtgRegistroEstadisticaJugadores_MouseClick(object sender, MouseEventArgs e)
        {
            // Se llenan los campos de texto con los valores de la fila seleccionada
            txtEstadisticaID.Text = dtgRegistroEstadisticaJugadores.SelectedRows[0].Cells[0].Value.ToString();
            txtJugadorId.Text = dtgRegistroEstadisticaJugadores.SelectedRows[0].Cells[1].Value.ToString();
            txtPartidoId.Text = dtgRegistroEstadisticaJugadores.SelectedRows[0].Cells[2].Value.ToString();
            txtpuntos.Text = dtgRegistroEstadisticaJugadores.SelectedRows[0].Cells[3].Value.ToString();
            txtrebotes.Text = dtgRegistroEstadisticaJugadores.SelectedRows[0].Cells[4].Value.ToString();
            txtasistencia.Text = dtgRegistroEstadisticaJugadores.SelectedRows[0].Cells[5].Value.ToString();
        }
    }
}
