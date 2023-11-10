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
    public partial class frmRegistrarPartidos : Form
    {
        

        public frmRegistrarPartidos()
        {
            InitializeComponent();
        }

        private void btnRegistrarP_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();
                clsPartidosBd Partido = new clsPartidosBd(Convert.ToInt32(txtPartidoId.Text), txtLugar.Text, Convert.ToInt32(txtCapacidadLugar.Text), txtEquipoLocal.Text, txtEquipoVisitante.Text);
                Partido.InsertarDato();
                MessageBox.Show("PARTIDO REGISTRADO");
                dtgRegistroPartidos.DataSource = Partido.Consultar();

            }
            catch (Exception)
            {

                MessageBox.Show("ERROR EN LOS DATOS");
            }
            
            
            
        }

        private void btnModificarP_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();
                clsPartidosBd modificar = new clsPartidosBd(Convert.ToInt32(txtPartidoId.Text), txtLugar.Text, Convert.ToInt32(txtCapacidadLugar.Text), txtEquipoLocal.Text, txtEquipoVisitante.Text);
                modificar.ModificarPartido();
                MessageBox.Show("DATOS MODIFICADOS");
                dtgRegistroPartidos.DataSource = modificar.Consultar();
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR EN EL SISTEMA O DATOS");
            }
                
            
                
            
        }

        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();
                clsPartidosBd elimina = new clsPartidosBd();
                elimina.EliminarPartido(Convert.ToInt32(txtPartidoId.Text));
                MessageBox.Show("PARTIDO ELIMINADO");
                dtgRegistroPartidos.DataSource = elimina.Consultar();
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR EN LOS DATOS O DEBES ELIMINAR PRIMERO LOS RESULTADOS O PARTIDOS PROGRAMADOS ASOCIADOS CON ESTE");
            }
               
            
        }

        private void frmRegistrarPartidos_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultaGeneral_Click(object sender, EventArgs e)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();

            clsPartidosBd Consluta = new clsPartidosBd();
            dtgRegistroPartidos.DataSource = Consluta.Consultar();
            
        }

        private void dtgRegistroPartidos_MouseClick(object sender, MouseEventArgs e)
        {
            txtPartidoId.Text = dtgRegistroPartidos.SelectedRows[0].Cells[0].Value.ToString();
            txtLugar.Text = dtgRegistroPartidos.SelectedRows[0].Cells[1].Value.ToString();
            txtCapacidadLugar.Text = dtgRegistroPartidos.SelectedRows[0].Cells[2].Value.ToString();
            txtEquipoLocal.Text = dtgRegistroPartidos.SelectedRows[0].Cells[3].Value.ToString();
            txtEquipoVisitante.Text = dtgRegistroPartidos.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
