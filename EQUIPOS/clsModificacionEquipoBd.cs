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
    /// Clase que maneja la modificación de datos de equipos en la base de datos.
    /// </summary>



    class clsModificacionEquipoBd
    {
        /// <summary>
        /// Obtiene o establece el ID del equipo.
        /// Obtiene o establece el nombre del equipo
        /// Obtiene o establece la ubicación del equipo.
        /// Obtiene o establece los colores del equipo.
        ///  Obtiene o establece el ID del técnico del equipo
        /// </summary>
        public int EquipoID { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public string Colores { get; set; }
        public int TecnicoID { get; set; }


        public clsModificacionEquipoBd()
        {


        }
        /// <summary>
        /// Constructor de la clase clsModificacionEquipoBd con parámetros.
        /// </summary>
        /// <param name="EquipoID">ID del equipo.</param>
        /// <param name="Nombre">Nombre del equipo.</param>
        /// <param name="Ubicacion">Ubicación del equipo.</param>
        /// <param name="Colores">Colores del equipo.</param>

        /// <param name="TecnicoID">ID del técnico del equipo.</param>
        public clsModificacionEquipoBd(int EquipoID, string Nombre, string Ubicacion, string Colores, int TecnicoID)
        {
            this.EquipoID = EquipoID;
            this.Nombre = Nombre;
            this.Ubicacion = Ubicacion;
            this.Colores = Colores;
            this.TecnicoID = TecnicoID;
        }
        /// <summary>
        /// Inserta un nuevo equipo en la base de datos.
        /// </summary>
        /// <returns>True si la operación es exitosa; de lo contrario, False.</returns>
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
        /// Consulta todos los equipos en la base de datos.
        /// </summary>
        /// <returns>Un DataTable con los resultados de la consulta.</returns>

        public DataTable Consultar()
        {
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
        /// Elimina un equipo de la base de datos.
        /// </summary>
        /// <param name="EquipoID">ID del equipo a eliminar.</param>
        /// <returns>True si la operación es exitosa; de lo contrario, False.</returns>

        public bool EliminarEquipo(int EquipoID)
        {
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
        /// Modifica la información de un equipo en la base de datos.
        /// </summary>
        /// <returns>True si la operación es exitosa; de lo contrario, False.</returns>
        public bool ModificarEquipo()
        {
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
        /// Selecciona un equipo basado en su ID.
        /// </summary>
        /// <param name="EquipoID">ID del equipo a seleccionar.</param>
        /// <returns>Un DataTable con los resultados de la selección.</returns>

        public DataTable SeleccionarEquipo(int EquipoID)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            this.EquipoID= EquipoID;
            DataTable dt= new DataTable();
            string seleccionar = "select * from Equipos where EquipoID=@EquipoID";
            SqlCommand cmd = new SqlCommand(seleccionar, conexion.conexion);
            cmd.Parameters.AddWithValue("@EquipoID", this.EquipoID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}
