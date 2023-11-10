using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoccerLineF
{
    public partial class frmMenuDirectivo : Form
    {
        public frmMenuDirectivo()
        {
            InitializeComponent();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmEquiposConsulta = this.ActiveMdiChild;
            Form frmJugadorRegistro= this.ActiveMdiChild;
            Form frmRegistrarPartidos = this.ActiveMdiChild;
            Form frmRegistroEquipos = this.ActiveMdiChild;
            Form frmRegistroResultados = this.ActiveMdiChild;
            Form frmConsultaEstadistica= this.ActiveMdiChild;
            Form frmRegistroEstadistica=this.ActiveMdiChild;
            Form frmJugadorConsulta=this.ActiveMdiChild;
            Form frmConsultaPartido= this.ActiveMdiChild;
            Form frmConsultaResultado= this.ActiveMdiChild;
            Form frmRegistroCalendario= this.ActiveMdiChild;
            Form frmConsultaFecha= this.ActiveMdiChild;
            Form frmRegistroTecnico= this.ActiveMdiChild;
            Form frmConsultaTecnico=this.ActiveMdiChild;

            if (frmEquiposConsulta != null)
            {
                frmEquiposConsulta.Close();
            }
            else if (frmJugadorRegistro != null)
            {
                frmJugadorRegistro.Close();
            }
            else if (frmRegistrarPartidos != null)
            {
                frmRegistrarPartidos.Close();
            }
            else if (frmRegistroEquipos != null)
            {
                frmRegistroEquipos.Close();
            }
            else if (frmRegistroResultados != null)
            {
                frmRegistroResultados.Close();
            }
            else if (frmConsultaEstadistica != null)
            {
                frmConsultaEstadistica.Close();
            }
            else if (frmRegistroEstadistica != null)
            {
                frmRegistroEstadistica.Close();
            }
            else if (frmJugadorConsulta != null)
            {
                frmJugadorConsulta.Close();
            }
            else if (frmConsultaPartido != null)
            {
                frmConsultaPartido.Close();
            }
            else if (frmConsultaResultado != null)
            {
                frmConsultaResultado.Close();
            }
            else if (frmRegistroCalendario != null)
            {
                frmRegistroCalendario.Close();
            }
            else if (frmConsultaFecha != null)
            {
                frmConsultaFecha.Close();
            }
            else if (frmRegistroTecnico !=null)
            {
                frmRegistroTecnico.Close();
            }
            else if (frmConsultaTecnico != null)
            {
                frmConsultaTecnico.Close();
            }
        }

        
        frmEquiposConsulta ConsultaEquipos;
        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            frmRegistroEquipos ventana1 = new frmRegistroEquipos();
            ventana1.MdiParent = this; 
            ventana1.Show();
            ventana1.StartPosition = FormStartPosition.Manual;
            ventana1.Location = new Point(50, 50); 
            ventana1.Show();

        }

        private void observarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form form in this.MdiChildren)
            {
                form.Close();
            }

            frmEquiposConsulta ventana2 = new frmEquiposConsulta();
            ventana2.MdiParent = this;
            ventana2.Show();
            ventana2.StartPosition = FormStartPosition.Manual;
            ventana2.Location = new Point(50, 50);
            ventana2.Show();
        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            frmJugadorRegistro ventana3 = new frmJugadorRegistro();
            ventana3.MdiParent = this;
            ventana3.Show();
            ventana3.StartPosition = FormStartPosition.Manual;
            ventana3.Location = new Point(50, 50);
            ventana3.Show();
        }

        private void registrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            frmRegistrarPartidos ventana4 = new frmRegistrarPartidos();
            ventana4.MdiParent = this;
            ventana4.Show();
            ventana4.StartPosition = FormStartPosition.Manual;
            ventana4.Location = new Point(50, 50);
            ventana4.Show();
        }

        private void registrarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            frmRegistroResultados ventana5 = new frmRegistroResultados();
            ventana5.MdiParent = this;
            ventana5.Show();
            ventana5.StartPosition = FormStartPosition.Manual;
            ventana5.Location = new Point(50, 50);
            ventana5.Show();
        }

        private void frmMenuDirectivo_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void observarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            frmJugadorConsulta ventana6 = new frmJugadorConsulta();
            ventana6.MdiParent = this;
            ventana6.Show();
            ventana6.StartPosition = FormStartPosition.Manual;
            ventana6.Location = new Point(50, 50);
            ventana6.Show();
        }

        private void observarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            frmConsultaPartido ventana7 = new frmConsultaPartido();
            ventana7.MdiParent = this;
            ventana7.Show();
            ventana7.StartPosition = FormStartPosition.Manual;
            ventana7.Location = new Point(50, 50);
            ventana7.Show();
        }

        private void observarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            frmConsultaResultado ventana8 = new frmConsultaResultado();
            ventana8.MdiParent = this;
            ventana8.Show();
            ventana8.StartPosition = FormStartPosition.Manual;
            ventana8.Location = new Point(50, 50);
            ventana8.Show();
        }

        private void registrarOModificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            frmRegistroEstadistica ventana9 = new frmRegistroEstadistica();
            ventana9.MdiParent = this;
            ventana9.Show();
            ventana9.StartPosition = FormStartPosition.Manual;
            ventana9.Location = new Point(50, 50);
            ventana9.Show();
        }

        private void observarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            frmConsultaEstadistica ventana10 = new frmConsultaEstadistica();
            ventana10.MdiParent = this;
            ventana10.Show();
            ventana10.StartPosition = FormStartPosition.Manual;
            ventana10.Location = new Point(50, 50);
            ventana10.Show();
        }

        private void registrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            frmRegistroCalendario ventana11 = new frmRegistroCalendario();
            ventana11.MdiParent = this;
            ventana11.Show();
            ventana11.StartPosition = FormStartPosition.Manual;
            ventana11.Location = new Point(50, 50);
            ventana11.Show();
        }

        private void observarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            frmConsultaFecha ventana12 = new frmConsultaFecha();
            ventana12.MdiParent = this;
            ventana12.Show();
            ventana12.StartPosition = FormStartPosition.Manual;
            ventana12.Location = new Point(50, 50);
            ventana12.Show();
        }

        private void volverAlInicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInicio inicio = new frmInicio();
            inicio.Show();
            this.Close();
        }

        private void equiposToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarOModificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            frmRegistroTecnico ventana13 = new frmRegistroTecnico();
            ventana13.MdiParent = this;
            ventana13.Show();
            ventana13.StartPosition = FormStartPosition.Manual;
            ventana13.Location = new Point(50, 50);
            ventana13.Show();
        }

        private void observarToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            frmConsultaTecnico ventana14 = new frmConsultaTecnico();
            ventana14.MdiParent = this;
            ventana14.Show();
            ventana14.StartPosition = FormStartPosition.Manual;
            ventana14.Location = new Point(50, 50);
            ventana14.Show();
        }
    }
}
