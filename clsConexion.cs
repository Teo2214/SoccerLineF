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
        string cadena = "Data Source=soccerline.cxjhy1d4snyo.us-east-2.rds.amazonaws.com;Initial Catalog=SoccerLineDB;User ID=admin;Password=Ma20042214";
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
