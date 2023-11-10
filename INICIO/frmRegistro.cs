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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                clsRegistroBd p1 = new clsRegistroBd(Convert.ToInt32(txtId.Text), txtNombre.Text, txtApellido.Text, txtEmail.Text, txtContraseña.Text, Convert.ToInt32(txtEdad.Text), txtSexo.Text, txtAficionado.Text);
                p1.InsertarDato();
                MessageBox.Show("Datos Ingresados");
                MessageBox.Show("Por favor vuelva al incio e inicie sesión");
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL REGISTRAR LOS DATOS");
            }
                
           
            
          
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmInicio inicio = new frmInicio();
            inicio.Show();
            this.Close();
        }

       
        
    }
}
