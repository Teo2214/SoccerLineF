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
    /// Clase que maneja la información de los resultados de los partidos en la base de datos.
    /// </summary>
    class clsResultadoBd
    {
        /// <summary>
        /// Obtiene o establece el marcador local del partido.
        /// Obtiene o establece el marcador visitante del partido.
        /// Obtiene o establece el evento destacado del partido.
        /// Obtiene o establece el ID del partido asociado al resultado.
        /// </summary>
        public int MarcadorLocal { get; set; }
        public int MarcadorVisitante { get; set; }
        public string EventoDestacado { get; set; }
        public int PartidoID { get; set; }
        
        /// <summary>
        /// Constructor predeterminado de la clase clsResultadoBd.
        /// </summary>
        public clsResultadoBd()
        {

        }
        /// <summary>
        /// Constructor de la clase clsResultadoBd con parámetros.
        /// </summary>
        /// <param name="MarcadorLocal">Marcador local del partido.</param>
        /// <param name="MarcadorVisitante">Marcador visitante del partido.</param>
        /// <param name="EventoDestacado">Evento destacado del partido.</param>
        /// <param name="PartidoID">ID del partido asociado al resultado.</param>
        public clsResultadoBd(int MarcadorLocal, int MarcadorVisitante, string EventoDestacado, int PartidoID)
        {
            this.MarcadorLocal = MarcadorLocal;
            this.MarcadorVisitante = MarcadorVisitante;
            this.EventoDestacado = EventoDestacado;
            this.PartidoID = PartidoID;


        }
        /// <summary>
        /// Inserta un nuevo resultado de partido en la base de datos.
        /// </summary>
        /// <returns>True si la operación es exitosa; de lo contrario, False.</returns>

        public bool InsertarDato()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string insertar = "insert into Resultados values (@MarcadorLocal, @MarcadorVisitante, @EventoDestacado, @PartidoID)";
            SqlCommand comando = new SqlCommand(insertar, conexion.conexion);

            comando.Parameters.AddWithValue("@MarcadorLocal", this.MarcadorLocal);
            comando.Parameters.AddWithValue("@MarcadorVisitante", this.MarcadorVisitante);
            comando.Parameters.AddWithValue("@EventoDestacado", this.EventoDestacado);
            comando.Parameters.AddWithValue("@PartidoID", this.PartidoID);
            comando.ExecuteNonQuery();
            return true;
        }
        /// <summary>
        /// Consulta la información de todos los resultados de partidos en la base de datos.
        /// </summary>
        /// <returns>Un DataTable con los resultados de la consulta.</returns>

        public DataTable Consultar()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            DataTable dt = new DataTable();
            string consulta = "select * from Resultados";
            SqlCommand comando = new SqlCommand(consulta, conexion.conexion);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// Elimina un resultado de partido de la base de datos.
        /// </summary>
        /// <param name="PartidoID">ID del partido asociado al resultado a eliminar.</param>
        /// <returns>True si la operación es exitosa; de lo contrario, False.</returns>
        public bool EliminarResultado(int PartidoID)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            this.PartidoID = PartidoID;
            string eliminar = "delete Resultados where PartidoID=@PartidoID";
            SqlCommand comando = new SqlCommand(eliminar, conexion.conexion);
            comando.Parameters.AddWithValue("@PartidoID", this.PartidoID);
            comando.ExecuteNonQuery();
            return true;

        }
        /// <summary>
        /// Selecciona la información de un resultado de partido basado en el ID del partido asociado.
        /// </summary>
        /// <param name="PartidoID">ID del partido asociado al resultado a seleccionar.</param>
        /// <returns>Un DataTable con los resultados de la selección.</returns>
        public DataTable SeleccionarResultado(int JugadorID)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            this.PartidoID = PartidoID;
            DataTable dt = new DataTable();
            string seleccionar = "select * from Resultados where PartidoID=@PartidoID";
            SqlCommand cmd = new SqlCommand(seleccionar, conexion.conexion);
            cmd.Parameters.AddWithValue("@PartidoID", this.PartidoID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;

        }
    }
}
