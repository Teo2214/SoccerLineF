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
    /// Clase que maneja la información de los jugadores en la base de datos.
    /// </summary>
    class clsJugadoresBd
    {
        /// <summary>
        /// Obtiene o establece el ID del jugador.
        /// Obtiene o establece el nombre del jugador.
        /// Obtiene o establece el apellido del jugador.
        /// Obtiene o establece la edad del jugador.
        /// Obtiene o establece la posición del jugador.
        /// Obtiene o establece el ID del equipo al que pertenece el jugador.
        /// </summary>
        public int JugadorID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Posicion { get; set; }
        public int EquipoID { get; set; }

        /// <summary>
        /// Constructor predeterminado de la clase clsJugadoresBd.
        /// </summary>

        public clsJugadoresBd()
        {


        }

        /// <summary>
        /// Constructor de la clase clsJugadoresBd con parámetros.
        /// </summary>
        /// <param name="JugadorID">ID del jugador.</param>
        /// <param name="Nombre">Nombre del jugador.</param>
        /// <param name="Apellido">Apellido del jugador.</param>
        /// <param name="Edad">Edad del jugador.</param>
        /// <param name="Posicion">Posición del jugador.</param>
        /// <param name="EquipoID">ID del equipo al que pertenece el jugador.</param>
        public clsJugadoresBd(int JugadorID, string Nombre, string Apellido, int Edad, string Posicion, int EquipoID)
        {
            this.JugadorID = JugadorID;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Edad = Edad;
            this.Posicion = Posicion;
            this.EquipoID = EquipoID;

        }
        /// <summary>
        /// Inserta un nuevo jugador en la base de datos.
        /// </summary>
        /// <returns>True si la operación es exitosa; de lo contrario, False.</returns>
        public bool InsertarDato()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string insertar = "insert into Jugadores values (@JugadorID, @Nombre, @Apellido, @Edad, @Posicion, @EquipoID)";
            SqlCommand comando = new SqlCommand(insertar, conexion.conexion);

            comando.Parameters.AddWithValue("@JugadorID", this.JugadorID);
            comando.Parameters.AddWithValue("@Nombre", this.Nombre);
            comando.Parameters.AddWithValue("@Apellido", this.Apellido);
            comando.Parameters.AddWithValue("@Edad", this.Edad);
            comando.Parameters.AddWithValue("@Posicion", this.Posicion);
            comando.Parameters.AddWithValue("@EquipoID", this.EquipoID);
            comando.ExecuteNonQuery();
            return true;
        }

        /// <summary>
        /// Consulta la información de todos los jugadores en la base de datos.
        /// </summary>
        /// <returns>Un DataTable con los resultados de la consulta.</returns>
        public DataTable Consultar()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            DataTable dt = new DataTable();
            string consulta = "select * from Jugadores";
            SqlCommand comando = new SqlCommand(consulta, conexion.conexion);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            return dt;
        }
        // <summary>
        /// Elimina un jugador de la base de datos.
        /// </summary>
        /// <param name="JugadorID">ID del jugador a eliminar.</param>
        /// <returns>True si la operación es exitosa; de lo contrario, False.</returns>
        public bool EliminarJugador(int JugadorID)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            this.JugadorID = JugadorID;
            string eliminar = "delete Jugadores where JugadorID=@JugadorID";
            SqlCommand comando = new SqlCommand(eliminar, conexion.conexion);
            comando.Parameters.AddWithValue("@JugadorID", this.JugadorID);
            comando.ExecuteNonQuery();
            return true;
        }
        /// <summary>
        /// Modifica la información de un jugador en la base de datos.
        /// </summary>
        /// <returns>True si la operación es exitosa; de lo contrario, False.</returns>
        public bool ModificarJugador()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string modificar = "update Jugadores set JugadorID=@JugadorID, Nombre=@Nombre, Apellido=@Apellido, Edad=@Edad, Posicion=@Posicion, EquipoID=@EquipoID where JugadorID=@JugadorID";
            SqlCommand sql = new SqlCommand(modificar, conexion.conexion);

            sql.Parameters.AddWithValue("@JugadorID", this.JugadorID);
            sql.Parameters.AddWithValue("@Nombre", this.Nombre);
            sql.Parameters.AddWithValue("@Apellido", this.Apellido);
            sql.Parameters.AddWithValue("@Edad", this.Edad);
            sql.Parameters.AddWithValue("@Posicion", this.Posicion);
            sql.Parameters.AddWithValue("@EquipoID", this.EquipoID);
            sql.ExecuteNonQuery();
            return true;
        }
        /// <summary>
        /// Selecciona la información de un jugador basado en su ID.
        /// </summary>
        /// <param name="JugadorID">ID del jugador a seleccionar.</param>
        /// <returns>Un DataTable con los resultados de la selección.</returns>
        public DataTable SeleccionarJugador(int JugadorID)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            this.JugadorID = JugadorID;
            DataTable dt = new DataTable();
            string seleccionar = "select * from Jugadores where JugadorID=@JugadorID";
            SqlCommand cmd = new SqlCommand(seleccionar, conexion.conexion);
            cmd.Parameters.AddWithValue("@JugadorID", this.JugadorID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}
