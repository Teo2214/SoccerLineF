using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerLineF
{
    class clsResultadoBd
    {
        public int MarcadorLocal { get; set; }
        public int MarcadorVisitante { get; set; }
        public string EventoDestacado { get; set; }
        public int PartidoID { get; set; }

        public clsResultadoBd()
        {

        }

        public clsResultadoBd(int MarcadorLocal, int MarcadorVisitante, string EventoDestacado, int PartidoID)
        {
            this.MarcadorLocal = MarcadorLocal;
            this.MarcadorVisitante = MarcadorVisitante;
            this.EventoDestacado = EventoDestacado;
            this.PartidoID = PartidoID;


        }

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
