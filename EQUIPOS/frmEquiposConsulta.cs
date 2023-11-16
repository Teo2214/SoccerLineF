using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoccerLineF
{

    public partial class frmEquiposConsulta : Form
    {
        // Variable estática para almacenar la única instancia de la clase
        private static frmEquiposConsulta insConsultaE;

        // Método para obtener la única instancia de la clase (implementación del patrón Singleton)


     /// <summary>
     /// public static frmEquiposConsulta ventanaEC(): Este es un método estático
     /// que devuelve una instancia de la clase frmEquiposConsulta.
     /// Es estático porque se accede directamente a través de la clase y no a través de una instancia de la clase.
     ///if (insConsultaE == null): VerinsConsultaEes nula.Si es nula, significa que no se ha creado un
     ///insConsultaE = new frmEquiposConsulta();: Si insConsultaEes nula, sfrmEquiposConsultay se asigna a insConsultaE.
     ///return insConsultaE;: Devuelve la instancia de `frfrmEquiposConsulta.Si ya existe una instancia,
     ///Este método asegura que solo haya unafrmEquiposConsultaen el programa
     /// </summary>
     /// <returns></returns>
        public static frmEquiposConsulta ventanaEC()
        {
            if (insConsultaE==null)
            {
                insConsultaE = new frmEquiposConsulta();
                return insConsultaE;
            }
            return insConsultaE;
        }

        // Constructor de la clase frmEquiposConsulta
        public frmEquiposConsulta()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
        // Evento al hacer clic en el botón de consulta general
        private void btnConsultaGeneral_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una instancia de la clase de conexión a la base de datos
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();


                // Crear una instancia de la clase clsModificacionEquipoBd para realizar la consulta general
                clsModificacionEquipoBd Consluta = new clsModificacionEquipoBd();

                // Asignar el origen de datos al DataGridView con los resultados de la consulta general
                dtgConsultaEquipos.DataSource = Consluta.Consultar();
            }
            catch (Exception)
            {
                // Manejar cualquier excepción y mostrar un mensaje de error
                MessageBox.Show("ERROR EN LOS DATOS");;
            }
            

        }

        // Evento al hacer clic en el botón de consulta específica
        private void btnConsultaEspecifica_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una instancia de la clase de conexión a la base de datos
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();


                // Verificar si el campo de texto de IdEquipo está vacío
                if (txtIdEquipo.Text == "")
                {

                    // Si está vacío, realizar una consulta general de todos los equipos
                    clsModificacionEquipoBd consulta = new clsModificacionEquipoBd();
                    dtgConsultaEquipos.DataSource=consulta.Consultar();
                }
                else
                {
                    // Si hay un IdEquipo especificado, realizar una consulta específica
                    clsModificacionEquipoBd consulta = new clsModificacionEquipoBd();
                    dtgConsultaEquipos.DataSource= consulta.SeleccionarEquipo(Convert.ToInt32(txtIdEquipo.Text));
                }
            }
            catch (Exception)
            {
                // Manejar cualquier excepción y mostrar un mensaje de error
                MessageBox.Show("ERROR, PRUEBA DE NUEVO EL ID, ASEGURATE QUE SI ESTE REGISTRADO");
            }
            
            
            
        }

        private void panelLateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmEquiposConsulta_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
