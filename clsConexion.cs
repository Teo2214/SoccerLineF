using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerLineF
{
    class clsConexion
    {
        string cadena = "Server=DESKTOP-6R2QN2C;Initial Catalog=SoccerLineDB;Initial Catalog=SoccerLineDB;Integrated Security=True;";
        public SqlConnection conexion=new SqlConnection();

        public clsConexion()
        {
            conexion.ConnectionString = cadena;
        }

        public void abrirConexion()
        {
            try
            {
                conexion.Open();

            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("ERROR AL ABRIR CONEXION"+ex.Message);
            }
        }

        public void cerrarConexion() 
        { 
            conexion.Close(); 
        }
    }
}
