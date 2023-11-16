using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerLineF
{
    class clsJugadoresBd
    {
        public int JugadorID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Posicion { get; set; }
        public int EquipoID { get; set; }



        public clsJugadoresBd()
        {


        }


        public clsJugadoresBd(int JugadorID, string Nombre, string Apellido, int Edad, string Posicion, int EquipoID)
        {
            this.JugadorID = JugadorID;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Edad = Edad;
            this.Posicion = Posicion;
            this.EquipoID = EquipoID;

        }

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
