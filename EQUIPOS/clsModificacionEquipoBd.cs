using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerLineF
{
    class clsModificacionEquipoBd
    {
        public int EquipoID { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public string Colores { get; set; }
        public int TecnicoID { get; set; }


        public clsModificacionEquipoBd()
        {


        }


        public clsModificacionEquipoBd(int EquipoID, string Nombre, string Ubicacion, string Colores, int TecnicoID)
        {
            this.EquipoID = EquipoID;
            this.Nombre = Nombre;
            this.Ubicacion = Ubicacion;
            this.Colores = Colores;
            this.TecnicoID = TecnicoID;
        }

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
