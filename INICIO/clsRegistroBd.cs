using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerLineF
{
    class clsRegistroBd
    {
        public int EntrenadorID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string Tipo_usuario { get; set; }

        public clsRegistroBd()
        {

        }

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
