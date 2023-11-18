using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerLineF
{

    /// <summary>
    /// Clase que gestiona la conexión a la base de datos.
    /// </summary>

    class clsConexion
    {

        // Cadena de conexión a la base de datos.
        string cadena = "Server=DESKTOP-6R2QN2C;Initial Catalog=SoccerLineDB;Initial Catalog=SoccerLineDB;Integrated Security=True;";
        
        // Objeto de conexión a la base de datos.
        public SqlConnection conexion=new SqlConnection();


        /// <summary>
        /// Constructor de la clase. Establece la cadena de conexión al objeto de conexión.
        /// </summary>
        public clsConexion()
        {
            conexion.ConnectionString = cadena;
        }

        // <summary>
        /// Abre la conexión a la base de datos.
        /// </summary>

        public void abrirConexion()
        {
            try
            {
                conexion.Open();

            }
            catch (Exception ex)
            {

                // Muestra un mensaje de error en caso de fallo al abrir la conexión.
                System.Windows.Forms.MessageBox.Show("ERROR AL ABRIR CONEXION"+ex.Message);
            }
        }


        /// <summary>
        /// Cierra la conexión a la base de datos.
        /// </summary>
        public void cerrarConexion() 
        { 
            conexion.Close(); 
        }
    }
}
