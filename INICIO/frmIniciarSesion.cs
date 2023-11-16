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
    public partial class frmIniciarSesion : Form
    {

        public frmIniciarSesion()
        {
            InitializeComponent();
        }


        // Método que se ejecuta al hacer clic en el botón "Volver"
        private void btnVolver_Click(object sender, EventArgs e)
        {
            // Se crea una instancia del formulario de inicio y se muestra, cerrando el formulario actual
            frmInicio inicio = new frmInicio();
            inicio.Show();
            this.Close();
        }

        // Método que se ejecuta al hacer clic en el botón "Iniciar Sesión"
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se obtienen los valores de ID, contraseña y tipo de usuario desde los controles del formulario
                int EntrenadorId;
                EntrenadorId = Convert.ToInt32(txtId.Text);

                string Contraseña;
                Contraseña = txtContraseña.Text;

                string TipoUsuario;
                TipoUsuario = cboTipoUsuario.Text;

                // Se instancia la clase de conexión a la base de datos
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                // Se prepara la consulta SQL para verificar las credenciales del usuario
                SqlCommand comando = new SqlCommand("SELECT EntrenadorID, Contraseña, Tipo_usuario FROM Usuarios WHERE EntrenadorID = @EntrenadorID AND Contraseña = @Contraseña AND Tipo_usuario = @Tipo_usuario", conexion.conexion);
                comando.Parameters.AddWithValue("@EntrenadorID", EntrenadorId);
                comando.Parameters.AddWithValue("@Contraseña", Contraseña);
                comando.Parameters.AddWithValue("@Tipo_usuario", TipoUsuario);

                // Se ejecuta la consulta y se lee el resultado
                SqlDataReader reader = comando.ExecuteReader();

     // Si se encuentra un usuario con las credenciales proporcionadas

                if (reader.Read())
                {
                    conexion.cerrarConexion();
                    MessageBox.Show("Bienvenido al software de SoccerLine");


                    // Se redirige a diferentes formularios según el tipo de usuario
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
                    // Si las credenciales son incorrectas, se muestra un mensaje de error
                    conexion.cerrarConexion();
                    MessageBox.Show("Usuario, contraseña o tipo de usuario incorrectos");
                }

            }
            catch (Exception)
            {
                // En caso de excepción, se muestra un mensaje de error general
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
