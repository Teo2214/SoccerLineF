using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerLineF
{
    /// <summary>
    /// Clase que maneja el registro de entrenadores en la base de datos.
    /// </summary>
    class clsRegistroBd
    {
        /// <summary>
        /// Obtiene o establece el ID del entrenador.
        /// Obtiene o establece el nombre del entrenador.
        /// Obtiene o establece el apellido del entrenador.
        /// Obtiene o establece el correo electrónico del entrenador.
        /// Obtiene o establece la contraseña del entrenador.
        /// Obtiene o establece la edad del entrenador.
        /// Obtiene o establece el sexo del entrenador.
        /// Obtiene o establece el tipo de usuario.
        /// </summary>
        public int EntrenadorID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string Tipo_usuario { get; set; }
       
        /// <summary>
        /// Constructor predeterminado de la clase clsRegistroBd.
        /// </summary>
        public clsRegistroBd()
        {

        }
        /// <summary>
        /// Constructor de la clase clsRegistroBd con parámetros.
        /// </summary>
        /// <param name="EntrenadorID">ID del entrenador.</param>
        /// <param name="Nombre">Nombre del entrenador.</param>
        /// <param name="Apellido">Apellido del entrenador.</param>
        /// <param name="Email">Correo electrónico del entrenador.</param>
        /// <param name="Contraseña">Contraseña del entrenador.</param>
        /// <param name="Edad">Edad del entrenador.</param>
        /// <param name="Sexo">Sexo del entrenador.</param>
        /// <param name="Tipo_usuario">Tipo de usuario.</param>
        public clsRegistroBd(int EntrenadorID, string Nombre, string Apellido, string Email, string Contraseña, int Edad, string Sexo, string Tipo_usuario)
        {
            this.EntrenadorID = EntrenadorID;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Email = Email;
            this.Contraseña = Contraseña;
            this.Edad = Edad;
            this.Sexo = Sexo;
            this.Tipo_usuario = Tipo_usuario;

        }
        /// <summary>
        /// Inserta un nuevo entrenador en la base de datos.
        /// </summary>
        /// <returns>True si la operación es exitosa; de lo contrario, False.</returns>
        public bool InsertarDato()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string insertar = "insert into Usuarios values (@EntrenadorID, @Nombre, @Apellido, @Email, @Contraseña, @Edad, @Sexo, @Tipo_usuario)";
            SqlCommand sql = new SqlCommand(insertar, conexion.conexion);

            sql.Parameters.AddWithValue("@EntrenadorID", this.EntrenadorID);
            sql.Parameters.AddWithValue("@Nombre", this.Nombre);
            sql.Parameters.AddWithValue("@Apellido", this.Apellido);
            sql.Parameters.AddWithValue("@Email", this.Email);
            sql.Parameters.AddWithValue("@Contraseña", this.Contraseña);
            sql.Parameters.AddWithValue("@Edad", this.Edad);
            sql.Parameters.AddWithValue("@Sexo", this.Sexo);
            sql.Parameters.AddWithValue("@Tipo_usuario", this.Tipo_usuario);
            sql.ExecuteNonQuery();

            return true;
        }
    }
}
