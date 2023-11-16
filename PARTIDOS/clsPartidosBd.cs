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
    /// Clase que maneja la información de los partidos en la base de datos.
    /// </summary>
    class clsPartidosBd
    {
        /// <summary>
        /// Obtiene o establece el ID del partido.
        /// Obtiene o establece el lugar donde se llevará a cabo el partido.
        /// Obtiene o establece la capacidad del lugar donde se llevará a cabo el partido.
        /// Obtiene o establece el nombre del equipo local.
        /// Obtiene o establece el nombre del equipo Visitante.
        ///  Constructor predeterminado de la clase clsPartidosBd
        /// </summary>
        public int PartidoID { get; set; }
        public string Lugar { get; set; }
        public int CapacidadLugar { get; set; }
        public string EquipoLocal { get; set; }
        public string EquipoVisitante { get; set; }

        /// <summary>
        /// Constructor predeterminado de la clase clsPartidosBd.
        /// </summary>

        public clsPartidosBd()
        {

        }
        /// <summary>
        /// Constructor de la clase clsPartidosBd con parámetros.
        /// </summary>
        /// <param name="PartidoID">ID del partido.</param>
        /// <param name="Lugar">Lugar donde se llevará a cabo el partido.</param>
        /// <param name="CapacidadLugar">Capacidad del lugar donde se llevará a cabo el partido.</param>
        /// <param name="EquipoLocal">Nombre del equipo local.</param>
        /// <param name="EquipoVisitante">Nombre del equipo visitante.</param>
        public clsPartidosBd(int PartidoID, string Lugar, int CapacidadLugar, string EquipoLocal, string EquipoVisitante)
        {
            this.PartidoID = PartidoID;
            this.Lugar = Lugar;
            this.CapacidadLugar = CapacidadLugar;
            this.EquipoLocal = EquipoLocal;
            this.EquipoVisitante = EquipoVisitante;
        }
        /// <summary>
        /// Inserta un nuevo partido en la base de datos.
        /// </summary>
        /// <returns>True si la operación es exitosa; de lo contrario, False.</returns>
        public bool InsertarDato()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string insertar = "insert into Partidos values (@PartidoID, @Lugar, @CapacidadLugar, @EquipoLocal, @EquipoVisitante)";
            SqlCommand comando = new SqlCommand(insertar, conexion.conexion);

            comando.Parameters.AddWithValue("@PartidoID", this.PartidoID);
            comando.Parameters.AddWithValue("@Lugar", this.Lugar);
            comando.Parameters.AddWithValue("@CapacidadLugar", this.CapacidadLugar);
            comando.Parameters.AddWithValue("@EquipoLocal", this.EquipoLocal);
            comando.Parameters.AddWithValue("@EquipoVisitante", this.EquipoVisitante);
            comando.ExecuteNonQuery();
            return true;
        }
        /// <summary>
        /// Consulta la información de todos los partidos en la base de datos.
        /// </summary>
        /// <returns>Un DataTable con los resultados de la consulta.</returns>
        public DataTable Consultar()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            DataTable dt = new DataTable();
            string consulta = "select * from Partidos";
            SqlCommand comando = new SqlCommand(consulta, conexion.conexion);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            return dt;

        }
        /// <summary>
        /// Elimina un partido de la base de datos.
        /// </summary>
        /// <param name="PartidoID">ID del partido a eliminar.</param>
        /// <returns>True si la operación es exitosa; de lo contrario, False.</returns>
        public bool EliminarPartido(int PartidoID)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            this.PartidoID = PartidoID;
            string eliminar = "delete Partidos where PartidoID=@PartidoID";
            SqlCommand comando = new SqlCommand(eliminar, conexion.conexion);
            comando.Parameters.AddWithValue("@PartidoID", this.PartidoID);
            comando.ExecuteNonQuery();
            return true;
        }
        /// <summary>
        /// Modifica la información de un partido en la base de datos.
        /// </summary>
        /// <returns>True si la operación es exitosa; de lo contrario, False.</returns>
        public bool ModificarPartido()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string modificar = "update Partidos set PartidoID=@PartidoID, Lugar=@Lugar, CapacidadLugar=@CapacidadLugar, EquipoLocal=@EquipoLocal, EquipoVisitante=@EquipoVisitante where PartidoID=@PartidoID";
            SqlCommand sql = new SqlCommand(modificar, conexion.conexion);

            sql.Parameters.AddWithValue("@PartidoID", this.PartidoID);
            sql.Parameters.AddWithValue("@Lugar", this.Lugar);
            sql.Parameters.AddWithValue("@CapacidadLugar", this.CapacidadLugar);
            sql.Parameters.AddWithValue("@EquipoLocal", this.EquipoLocal);
            sql.Parameters.AddWithValue("@EquipoVisitante", this.EquipoVisitante);
            sql.ExecuteNonQuery();
            return true;
        }
        /// <summary>
        /// Selecciona la información de un partido basado en su ID.
        /// </summary>
        /// <param name="PartidoID">ID del partido a seleccionar.</param>
        /// <returns>Un DataTable con los resultados de la selección.</returns>
        public DataTable SeleccionarPartido(int PartidoID)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            this.PartidoID = PartidoID;
            DataTable dt = new DataTable();
            string seleccionar = "select * from Partidos where PartidoID=@PartidoID";
            SqlCommand cmd = new SqlCommand(seleccionar, conexion.conexion);
            cmd.Parameters.AddWithValue("@PartidoID", this.PartidoID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

    }
}
