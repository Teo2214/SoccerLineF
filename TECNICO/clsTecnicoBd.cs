using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerLineF
{
    class clsTecnicoBd
    {
        public int TecnicoID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Expediente { get; set; }
        


        public clsTecnicoBd()
        {


        }


        public clsTecnicoBd(int TecnicoID, string Nombre, string Apellido, string Expediente)
        {
            this.TecnicoID = TecnicoID;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Expediente = Expediente;
            
        }

        public bool InsertarDato()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string insertar = "insert into Tecnico values (@TecnicoID, @Nombre, @Apellido, @Expediente)";
            SqlCommand comando = new SqlCommand(insertar, conexion.conexion);

            comando.Parameters.AddWithValue("@TecnicoID", this.TecnicoID);
            comando.Parameters.AddWithValue("@Nombre", this.Nombre);
            comando.Parameters.AddWithValue("@Apellido", this.Apellido);
            comando.Parameters.AddWithValue("@Expediente", this.Expediente);
            comando.ExecuteNonQuery();
            return true;
        }


        public DataTable Consultar()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            DataTable dt = new DataTable();
            string consulta = "select * from Tecnico";
            SqlCommand comando = new SqlCommand(consulta, conexion.conexion);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            return dt;
        }

        public bool Eliminar(int TecnicoID)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            this.TecnicoID = TecnicoID;
            string eliminar = "delete Tecnico where TecnicoID=@TecnicoID";
            SqlCommand comando = new SqlCommand(eliminar, conexion.conexion);
            comando.Parameters.AddWithValue("@TecnicoID", this.TecnicoID);
            comando.ExecuteNonQuery();
            return true;
        }

        public bool Modificar()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string modificar = "update Tecnico set TecnicoID=@TecnicoID, Nombre=@Nombre, Apellido=@Apellido, Expediente=@Expediente where TecnicoID=@TecnicoID";
            SqlCommand sql = new SqlCommand(modificar, conexion.conexion);

            sql.Parameters.AddWithValue("@TecnicoID", this.TecnicoID);
            sql.Parameters.AddWithValue("@Nombre", this.Nombre);
            sql.Parameters.AddWithValue("@Apellido", this.Apellido);
            sql.Parameters.AddWithValue("@Expediente", this.Expediente);
            sql.ExecuteNonQuery();
            return true;
        }

        public DataTable Seleccionar(int TecnicoID)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            this.TecnicoID = TecnicoID;
            DataTable dt = new DataTable();
            string seleccionar = "select * from Tecnico where TecnicoID=@TecnicoID";
            SqlCommand cmd = new SqlCommand(seleccionar, conexion.conexion);
            cmd.Parameters.AddWithValue("@TecnicoID", this.TecnicoID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}
