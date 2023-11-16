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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmInicio inicio = new frmInicio();
            inicio.Show();
            this.Close();
        }

        
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                int EntrenadorId;
                EntrenadorId = Convert.ToInt32(txtId.Text);

                string Contraseña;
                Contraseña = txtContraseña.Text;

                string TipoUsuario;
                TipoUsuario = cboTipoUsuario.Text;


                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();
                SqlCommand comando = new SqlCommand("SELECT EntrenadorID, Contraseña, Tipo_usuario FROM Usuarios WHERE EntrenadorID = @EntrenadorID AND Contraseña = @Contraseña AND Tipo_usuario = @Tipo_usuario", conexion.conexion);
                comando.Parameters.AddWithValue("@EntrenadorID", EntrenadorId);
                comando.Parameters.AddWithValue("@Contraseña", Contraseña);
                comando.Parameters.AddWithValue("@Tipo_usuario", TipoUsuario);

                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    conexion.cerrarConexion();
                    MessageBox.Show("Bienvenido al software de SoccerLine");

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
