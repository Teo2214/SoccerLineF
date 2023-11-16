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
    /// Clase que maneja la información de los técnicos en la base de datos.
    /// </summary>
    class clsTecnicoBd
    {
        /// <summary>
        /// Obtiene o establece el ID del técnico.
        /// Obtiene o establece el nombre del técnico
        /// Obtiene o establece el apellido del técnico.
        /// Obtiene o establece el expediente del técnico.
        /// </summary>
        public int TecnicoID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Expediente { get; set; }

        /// <summary>
        /// Constructor predeterminado de la clase clsTecnicoBd.
        /// </summary>

        public clsTecnicoBd()
        {


        }

        /// <summary>
        /// Constructor de la clase clsTecnicoBd con parámetros.
        /// </summary>
        /// <param name="TecnicoID">ID del técnico.</param>
        /// <param name="Nombre">Nombre del técnico.</param>
        /// <param name="Apellido">Apellido del técnico.</param>
        /// <param name="Expediente">Expediente del técnico.</param>

        public clsTecnicoBd(int TecnicoID, string Nombre, string Apellido, string Expediente)
        {
            this.TecnicoID = TecnicoID;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Expediente = Expediente;
            
        }
        /// <summary>
        /// Inserta un nuevo técnico en la base de datos.
        /// </summary>
        /// <returns>True si la operación es exitosa; de lo contrario, False.</returns>
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
         /// <summary>
         /// Consulta la información de todos los técnicos en la base de datos.
         /// </summary>
         /// <returns>Un DataTable con los resultados de la consulta.</returns>

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
        /// <summary>
        /// Elimina un técnico de la base de datos.
        /// </summary>
        /// <param name="TecnicoID">ID del técnico a eliminar.</param>
        /// <returns>True si la operación es exitosa; de lo contrario, False.</returns>
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
        /// <summary>
        /// Modifica la información de un técnico en la base de datos.
        /// </summary>
        /// <returns>True si la operación es exitosa; de lo contrario, False.</returns>
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
        /// <summary>
        /// Selecciona la información de un técnico basado en su ID.
        /// </summary>
        /// <param name="TecnicoID">ID del técnico a seleccionar.</param>
        /// <returns>Un DataTable con los resultados de la selección.</returns>
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
