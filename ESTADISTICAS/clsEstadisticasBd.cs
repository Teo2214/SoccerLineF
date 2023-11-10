using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerLineF
{
    class clsEstadisticasBd
    {
        public int EstadisticasID { get; set; }
        public int JugadorID { get; set; }
        public int PartidoID { get; set; }
        public int Puntos { get; set; }
        public int Rebotes { get; set; }
        public int Asistencias { get; set; }

        public clsEstadisticasBd()
        {

        }

        public clsEstadisticasBd(int EstadisticasID, int JugadorID, int PartidoID, int Puntos, int Rebotes, int Asistencias)
        {
            this.EstadisticasID = EstadisticasID;
            this.JugadorID = JugadorID;
            this.PartidoID = PartidoID;
            this.Puntos = Puntos;
            this.Rebotes = Rebotes;
            this.Asistencias = Asistencias;
        }

        public bool InsertarDato()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string insertar = "insert into EstadisticasJugadores values (@EstadisticasID, @JugadorID, @PartidoID, @Puntos, @Rebotes, @Asistencias)";
            SqlCommand comando = new SqlCommand(insertar, conexion.conexion);

            comando.Parameters.AddWithValue("@EstadisticasID", this.EstadisticasID);
            comando.Parameters.AddWithValue("@JugadorID", this.JugadorID);
            comando.Parameters.AddWithValue("@PartidoID", this.PartidoID);
            comando.Parameters.AddWithValue("@Puntos", this.Puntos);
            comando.Parameters.AddWithValue("Rebotes", this.Rebotes);
            comando.Parameters.AddWithValue("Asistencias", this.Asistencias);
            comando.ExecuteNonQuery();
            return true;
        }

        public DataTable Consultar()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            DataTable dt = new DataTable();
            string consulta = "select * from EstadisticasJugadores";
            SqlCommand comando = new SqlCommand(consulta, conexion.conexion);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            return dt;
        }

        public bool Eliminar(int EstadisticasID)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            this.EstadisticasID = EstadisticasID;
            string eliminar = "delete EstadisticasJugadores where EstadisticasID=@EstadisticasID";
            SqlCommand comando = new SqlCommand(eliminar, conexion.conexion);
            comando.Parameters.AddWithValue("@EstadisticasID", this.EstadisticasID);
            comando.ExecuteNonQuery();
            return true;
        }

        public bool Modificar()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string modificar = "update EstadisticasJugadores set EstadisticasID=@EstadisticasID, JugadorID=@JugadorID, PartidoID=@PartidoID, Puntos=@Puntos, Rebotes=@Rebotes, Asistencias=@Asistencias where EstadisticasID=@EstadisticasID";
            SqlCommand sql = new SqlCommand(modificar, conexion.conexion);

            sql.Parameters.AddWithValue("@EstadisticasID", this.EstadisticasID);
            sql.Parameters.AddWithValue("@JugadorID", this.JugadorID);
            sql.Parameters.AddWithValue("@PartidoID", this.PartidoID);
            sql.Parameters.AddWithValue("@Puntos", this.Puntos);
            sql.Parameters.AddWithValue("@Rebotes", this.Rebotes);
            sql.Parameters.AddWithValue("@Asistencias", this.Asistencias);
            sql.ExecuteNonQuery();
            return true;
        }

        public DataTable Seleccionar(int EstadisticasID)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            this.EstadisticasID = EstadisticasID;
            DataTable dt = new DataTable();
            string seleccionar = "select * from EstadisticasJugadores where EstadisticasID=@EstadisticasID";
            SqlCommand cmd = new SqlCommand(seleccionar, conexion.conexion);
            cmd.Parameters.AddWithValue("@EstadisticasID", this.EstadisticasID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}
