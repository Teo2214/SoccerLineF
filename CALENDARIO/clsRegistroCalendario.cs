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
    /// Clase que representa la gestión de registros en la tabla CalendarioPartidos.
    /// </summary>
    class clsRegistroCalendario
    {

        

        /// <summary>
        /// Obtiene o establece el identificador del calendario.
        /// Obtiene o establece la fecha del partido.
        /// Obtiene o establece el identificador del partido.
        /// </summary>
        public int CalendarioID { get; set; }
        public DateTime FechaPartido { get; set; }
        public int PartidoID { get; set; }


        /// <summary>
        /// Constructor por defecto de la clase clsRegistroCalendario.
        /// </summary>

        public clsRegistroCalendario()
        {


        }

        /// <summary>
        /// Constructor que inicializa las propiedades de la clase clsRegistroCalendario.
        /// </summary>
        /// <param name="CalendarioID">Identificador del calendario.</param>
        /// <param name="FechaPartido">Fecha del partido.</param>
        /// <param name="PartidoID">Identificador del partido.</param>
        public clsRegistroCalendario(int CalendarioID, DateTime FechaPartido, int PartidoID)
        {
            this.CalendarioID = CalendarioID;
            this.FechaPartido = FechaPartido;
            this.PartidoID = PartidoID;

        }
        /// <summary>
        /// Inserta un nuevo registro en la tabla CalendarioPartidos.
        /// </summary>
        /// <returns>Devuelve true si la operación se realiza con éxito.</returns>
        public bool InsertarDato()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string insertar = "insert into CalendarioPartidos values (@CalendarioID, @FechaPartido, @PartidoID)";
            SqlCommand comando = new SqlCommand(insertar, conexion.conexion);

            comando.Parameters.AddWithValue("@CalendarioID", this.CalendarioID);
            comando.Parameters.AddWithValue("@FechaPartido", SqlDbType.Date).Value = this.FechaPartido;
            comando.Parameters.AddWithValue("@PartidoID", this.PartidoID);
            comando.ExecuteNonQuery();
            return true;
        }

        /// <summary>
        /// Consulta todos los registros de la tabla CalendarioPartidos.
        /// </summary>
        /// <returns>Devuelve un DataTable con los resultados de la consulta.</returns>
        public DataTable Consultar()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            DataTable dt = new DataTable();
            string consulta = "select * from CalendarioPartidos";
            SqlCommand comando = new SqlCommand(consulta, conexion.conexion);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// Elimina un registro de la tabla CalendarioPartidos según su identificador.
        /// </summary>
        /// <param name="CalendarioID">Identificador del calendario a eliminar.</param>
        /// <returns>Devuelve true si la operación se realiza con éxito.</returns>
        public bool Eliminar(int CalendarioID)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            this.CalendarioID = CalendarioID;
            string eliminar = "delete CalendarioPartidos where CalendarioID=@CalendarioID";
            SqlCommand comando = new SqlCommand(eliminar, conexion.conexion);
            comando.Parameters.AddWithValue("@CalendarioID", this.CalendarioID);
            comando.ExecuteNonQuery();
            return true;
        }
        /// <summary>
        /// Modifica un registro de la tabla CalendarioPartidos.
        /// </summary>
        /// <returns>Devuelve true si la operación se realiza con éxito.</returns>
        public bool Modificar()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string modificar = "update CalendarioPartidos set CalendarioID=@CalendarioID, FechaPartido=@FechaPartido, PartidoID=@PartidoID where CalendarioID=@CalendarioID";
            SqlCommand sql = new SqlCommand(modificar, conexion.conexion);

            sql.Parameters.AddWithValue("@CalendarioID", this.CalendarioID);
            sql.Parameters.AddWithValue("@FechaPartido", SqlDbType.Date).Value = this.FechaPartido;
            sql.Parameters.AddWithValue("@PartidoID", this.PartidoID);
            sql.ExecuteNonQuery();
            return true;
        }
        /// <summary>
        /// Consulta registros de la tabla CalendarioPartidos según la fecha del partido.
        /// </summary>
        /// <param name="FechaPartido">Fecha del partido para la consulta.</param>
        /// <returns>Devuelve un DataTable con los resultados de la consulta.</returns>
        public DataTable Seleccionar(DateTime FechaPartido)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            this.FechaPartido = FechaPartido;
            DataTable dt = new DataTable();
            string seleccionar = "select * from CalendarioPartidos where FechaPartido=@FechaPartido";
            SqlCommand cmd = new SqlCommand(seleccionar, conexion.conexion);
            cmd.Parameters.AddWithValue("@FechaPartido", SqlDbType.Date).Value = this.FechaPartido;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}
