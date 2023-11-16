using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerLineF
{

 /// <summary>
 /// Clase que gestiona las conexiones a la base de datos.
/// </summary>
    class clsConexion
    {

        // Cadena de conexión para la base de datos
        string cadena = "Data Source=soccerline.cxjhy1d4snyo.us-east-2.rds.amazonaws.com;Initial Catalog=SoccerLineDB;User ID=admin;Password=Ma20042214";

        // Objeto SqlConnection para gestionar la conexión a la base de datos
        public SqlConnection conexion=new SqlConnection();
        


        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="clsConexion"/> con la cadena de conexión predeterminada.
        /// </summary>
        public clsConexion()
        {
            // Configura la cadena de conexión en el objeto SqlConnection al inicializar la clase
            conexion.ConnectionString = cadena;
        }


        /// <summary>
        /// Abre una conexión a la base de datos.
        /// </summary>
        /// <remarks>
        ///  Este método intenta abrir la conexión a la base de datos. Si ocurre un error, se muestra un mensaje de error.
        /// </remarks>
        public void abrirConexion()
        {
            try
            {
                // Intenta abrir la conexión a la base de datos
                conexion.Open();

            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error si la apertura de la conexión falla.
                System.Windows.Forms.MessageBox.Show("ERROR AL ABRIR CONEXION"+ex.Message);
            }
        }

        public void cerrarConexion() 
        { 
            conexion.Close(); 
        }
    }
}
