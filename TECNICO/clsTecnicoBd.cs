using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerLineF
{

    /// <summary>
    /// Clase que representa la entidad "Tecnico" en la base de datos y proporciona métodos para interactuar con ella.
    /// </summary>
    class clsTecnicoBd
    {

        // Propiedades de la entidad "Tecnico"
        public int TecnicoID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Expediente { get; set; }
        


        public clsTecnicoBd()
        {


        }
        /// <summary>
        /// Constructor que inicializa las propiedades de la entidad "Tecnico".
        /// </summary>

        public clsTecnicoBd(int TecnicoID, string Nombre, string Apellido, string Expediente)
        {
            this.TecnicoID = TecnicoID;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Expediente = Expediente;
            
        }

        /// <summary>
        /// Inserta un nuevo registro de "Tecnico" en la base de datos.
        /// </summary>
        /// <returns>Devuelve true si la inserción fue exitosa.</returns>

        public bool InsertarDato()
        {

            // Crea una instancia de la clase de conexión.
            clsConexion conexion = new clsConexion();
            // Abre la conexión a la base de datos.
            conexion.abrirConexion();
            // Define la consulta SQL para la inserción.
            string insertar = "insert into Tecnico values (@TecnicoID, @Nombre, @Apellido, @Expediente)";
            SqlCommand comando = new SqlCommand(insertar, conexion.conexion);


            // Asigna los parámetros de la consulta con los valores de las propiedades de la entidad.
            comando.Parameters.AddWithValue("@TecnicoID", this.TecnicoID);
            comando.Parameters.AddWithValue("@Nombre", this.Nombre);
            comando.Parameters.AddWithValue("@Apellido", this.Apellido);
            comando.Parameters.AddWithValue("@Expediente", this.Expediente);
            
            // Ejecuta la consulta de inserción.
            comando.ExecuteNonQuery();
            return true;
        }

        /// <summary>
        /// Consulta todos los registros de la tabla "Tecnico" y devuelve un DataTable.
        /// </summary>
        /// <returns>DataTable con los datos de la consulta.</returns>
        public DataTable Consultar()
        {

            // Crea una instancia de la clase de conexión.
            clsConexion conexion = new clsConexion();
            // Abre la conexión a la base de datos.
            conexion.abrirConexion();

            // Crea un DataTable para almacenar los resultados de la consulta.
            DataTable dt = new DataTable();
            // Define la consulta SQL para la selección de todos los registros de "Tecnico".
            string consulta = "select * from Tecnico";
            SqlCommand comando = new SqlCommand(consulta, conexion.conexion);
            // Crea un SqlDataAdapter para llenar el DataTable con los resultados de la consulta.
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            return dt;
        }


        /// <summary>
        /// Elimina un registro de "Tecnico" en la base de datos.
        /// </summary>
        /// <param name="TecnicoID">Identificador del técnico a eliminar.</param>
        /// <returns>Devuelve true si la eliminación fue exitosa.</returns>
        public bool Eliminar(int TecnicoID)
        {

            // Crea una instancia de la clase de conexión
            clsConexion conexion = new clsConexion();
            // Abre la conexión a la base de datos.
            conexion.abrirConexion();

            // Asigna el parámetro de la consulta con el valor proporcionado.
            this.TecnicoID = TecnicoID;
            // Define la consulta SQL para la eliminación de un registro de "Tecnico".
            string eliminar = "delete Tecnico where TecnicoID=@TecnicoID";
            SqlCommand comando = new SqlCommand(eliminar, conexion.conexion);
            // Asigna el parámetro de la consulta con el valor de la propiedad "TecnicoID".
            comando.Parameters.AddWithValue("@TecnicoID", this.TecnicoID);
            // Ejecuta la consulta de eliminación
            comando.ExecuteNonQuery();
            return true;
        }


        /// <summary>
        /// Modifica un registro de "Tecnico" en la base de datos.
        /// </summary>
        /// <returns>Devuelve true si la modificación fue exitosa.</returns>
        public bool Modificar()
        {
            // Crea una instancia de la clase de conexión
            clsConexion conexion = new clsConexion();
            // Abre la conexión a la base de datos.
            conexion.abrirConexion();
            // Define la consulta SQL para la modificación de un registro de "Tecnico".
            string modificar = "update Tecnico set TecnicoID=@TecnicoID, Nombre=@Nombre, Apellido=@Apellido, Expediente=@Expediente where TecnicoID=@TecnicoID";
            SqlCommand sql = new SqlCommand(modificar, conexion.conexion);
            // Asigna los parámetros de la consulta con los valores de las propiedades de la entidad.
            sql.Parameters.AddWithValue("@TecnicoID", this.TecnicoID);
            sql.Parameters.AddWithValue("@Nombre", this.Nombre);
            sql.Parameters.AddWithValue("@Apellido", this.Apellido);
            sql.Parameters.AddWithValue("@Expediente", this.Expediente);
            // Ejecuta la consulta de modificación.
            sql.ExecuteNonQuery();
            return true;
        }


        /// <summary>
        /// Selecciona un registro de "Tecnico" por su identificador y devuelve un DataTable con los resultados.
        /// </summary>
        /// <param name="TecnicoID">Identificador del técnico a seleccionar.</param>
        /// <returns>DataTable con los datos del técnico seleccionado.</returns>
        public DataTable Seleccionar(int TecnicoID)
        {

            // Crea una instancia de la clase de conexión.
            clsConexion conexion = new clsConexion();
            // Abre la conexión a la base de datos.
            conexion.abrirConexion();
            // Asigna el parámetro de la consulta con el valor proporcionado.
            this.TecnicoID = TecnicoID;
            // Crea un DataTable para almacenar los resultados de la consulta.
            DataTable dt = new DataTable();
            // Define la consulta SQL para la selección de un registro de "Tecnico" por su identificador.
            string seleccionar = "select * from Tecnico where TecnicoID=@TecnicoID";
            SqlCommand cmd = new SqlCommand(seleccionar, conexion.conexion);
            // Asigna el parámetro de la consulta con el valor de la propiedad "TecnicoID".
            cmd.Parameters.AddWithValue("@TecnicoID", this.TecnicoID);
            // Crea un SqlDataAdapter para llenar el DataTable con los resultados de la consulta.
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}
