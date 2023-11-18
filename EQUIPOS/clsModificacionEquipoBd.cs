using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerLineF
{

    /// <summary>
    /// Clase para la manipulación de datos de equipos en la base de datos.
    /// </summary>
    class clsModificacionEquipoBd
    {

        // Propiedades de la clase
        public int EquipoID { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public string Colores { get; set; }
        public int TecnicoID { get; set; }


        public clsModificacionEquipoBd()
        {


        }

        /// <summary>
        /// Constructor con parámetros para inicializar propiedades de la clase.
        /// </summary>
        public clsModificacionEquipoBd(int EquipoID, string Nombre, string Ubicacion, string Colores, int TecnicoID)
        {
            this.EquipoID = EquipoID;
            this.Nombre = Nombre;
            this.Ubicacion = Ubicacion;
            this.Colores = Colores;
            this.TecnicoID = TecnicoID;
        }
        /// <summary>
        /// Método para insertar un nuevo equipo en la base de datos.
        /// </summary>
        public bool InsertarDato()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string insertar = "insert into Equipos values (@EquipoID, @Nombre, @Ubicacion, @Colores, @TecnicoID)";
            SqlCommand comando = new SqlCommand(insertar, conexion.conexion);

            comando.Parameters.AddWithValue("@EquipoID", this.EquipoID);
            comando.Parameters.AddWithValue("@Nombre", this.Nombre);
            comando.Parameters.AddWithValue("@Ubicacion", this.Ubicacion);
            comando.Parameters.AddWithValue("@Colores", this.Colores);
            comando.Parameters.AddWithValue("TecnicoID", this.TecnicoID);
            comando.ExecuteNonQuery();
            return true;
        }

        /// <summary>
        /// Método para consultar todos los equipos en la base de datos.
        /// </summary>
        public DataTable Consultar()
        {
            // Establecer conexión a la base de datos
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            DataTable dt = new DataTable();
            string consulta = "select * from Equipos";
            SqlCommand comando = new SqlCommand(consulta, conexion.conexion);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// Método para eliminar un equipo de la base de datos por su ID.
        /// </summary>
        public bool EliminarEquipo(int EquipoID)
        {
            // Establecer conexión a la base de datos
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            this.EquipoID = EquipoID;
            string eliminar = "delete Equipos where EquipoID=@EquipoID";
            SqlCommand comando=new SqlCommand(eliminar, conexion.conexion);
            comando.Parameters.AddWithValue("@EquipoID", this.EquipoID);
            comando.ExecuteNonQuery();
            return true;
        }
        /// <summary>
        /// Método para modificar la información de un equipo en la base de datos.
        /// </summary>
        public bool ModificarEquipo()
        {
            // Establecer conexión a la base de datos
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string modificar = "update Equipos set EquipoID=@EquipoID, Nombre=@Nombre, Ubicacion=@Ubicacion, Colores=@Colores, TecnicoID=@TecnicoID where EquipoID=@EquipoID";
            SqlCommand sql = new SqlCommand(modificar, conexion.conexion);

            sql.Parameters.AddWithValue("@EquipoID",this.EquipoID);
            sql.Parameters.AddWithValue("@Nombre", this.Nombre);
            sql.Parameters.AddWithValue("@Ubicacion", this.Ubicacion);
            sql.Parameters.AddWithValue("@Colores", this.Colores);
            sql.Parameters.AddWithValue("TecnicoID", this.TecnicoID);
            sql.ExecuteNonQuery();
            return true;
        }
        /// <summary>
        /// Método para seleccionar un equipo de la base de datos por su ID.
        /// </summary>
        public DataTable SeleccionarEquipo(int EquipoID)
        {
           // Establecer conexión a la base de datos
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();

            // Asignar el ID del equipo a la propiedad de la clase
            this.EquipoID= EquipoID;
            // Crear un DataTable para almacenar los resultados de la consulta
            DataTable dt = new DataTable();
            // Definir la consulta SQL para seleccionar el equipo por su ID
            string seleccionar = "select * from Equipos where EquipoID=@EquipoID";
            SqlCommand cmd = new SqlCommand(seleccionar, conexion.conexion);
            cmd.Parameters.AddWithValue("@EquipoID", this.EquipoID);
            // Crear un SqlDataAdapter para ejecutar el comando y llenar el DataTable
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}
