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
    /// <summary>
    /// Formulario de inicio de sesión para usuarios del software SoccerLine.
    /// </summary>
    public partial class frmIniciarSesion : Form
    {
        /// <summary>
        /// Constructor del formulario.
        /// </summary>
        public frmIniciarSesion()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Maneja el evento de hacer clic en el botón "Volver".
        /// </summary>
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmInicio inicio = new frmInicio();
            inicio.Show();
            this.Close();
        }

        /// <summary>
        /// Maneja el evento de hacer clic en el botón "Iniciar Sesión".
        /// </summary>
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener datos de la interfaz de usuario
                int EntrenadorId;
                EntrenadorId = Convert.ToInt32(txtId.Text);

                string Contraseña;
                Contraseña = txtContraseña.Text;

                string TipoUsuario;
                TipoUsuario = cboTipoUsuario.Text;

                // Conectar a la base de datos
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();
                // Consultar la base de datos para el usuario
                SqlCommand comando = new SqlCommand("SELECT EntrenadorID, Contraseña, Tipo_usuario FROM Usuarios WHERE EntrenadorID = @EntrenadorID AND Contraseña = @Contraseña AND Tipo_usuario = @Tipo_usuario", conexion.conexion);
                comando.Parameters.AddWithValue("@EntrenadorID", EntrenadorId);
                comando.Parameters.AddWithValue("@Contraseña", Contraseña);
                comando.Parameters.AddWithValue("@Tipo_usuario", TipoUsuario);

                SqlDataReader reader = comando.ExecuteReader();

                // Verificar si las credenciales son correctas
                if (reader.Read())
                {
                    conexion.cerrarConexion();
                    MessageBox.Show("Bienvenido al software de SoccerLine");

                    // Abrir el formulario correspondiente según el tipo de usuario
                    if (TipoUsuario == "AFICIONADO")
                    {
                        frmMenuAficionado aficionado = new frmMenuAficionado();
                        aficionado.Show();
                        this.Close();
                    }

                    else if (TipoUsuario == "DIRECTIVO")
                    {
                        frmMenuDirectivo directivo = new frmMenuDirectivo();
                        directivo.Show();
                        this.Close();
                    }
                }

                else
                {
                    conexion.cerrarConexion();
                    MessageBox.Show("Usuario, contraseña o tipo de usuario incorrectos");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("ERROR EN DATOS O SISTEMA");
            }
            
        }

        private void frmIniciarSesion_Load(object sender, EventArgs e)
        {
          
        }

        private void cmbTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
