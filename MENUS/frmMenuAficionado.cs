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
    public partial class frmMenuAficionado : Form
    {
        public frmMenuAficionado()
        {
            InitializeComponent();
        }

        private void fberToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void opcionesDeVentanaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void equiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEquiposConsulta equiposAficion = new frmEquiposConsulta();
            equiposAficion.MdiParent = this;
            equiposAficion.Show();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmEquiposConsulta = this.ActiveMdiChild;
            Form frmConsultaEstadistica = this.ActiveMdiChild;
            Form frmJugadorConsulta = this.ActiveMdiChild;
            Form frmConsultaPartido = this.ActiveMdiChild;
            Form frmConsultaResultado = this.ActiveMdiChild;
            Form frmConsultaFecha = this.ActiveMdiChild;
            Form frmConsultaTecnico = this.ActiveMdiChild;

            if (frmEquiposConsulta != null)
            {
                frmEquiposConsulta.Close();
            }
            else if (frmConsultaEstadistica != null)
            {
                frmConsultaEstadistica.Close();
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
            else if (frmConsultaFecha != null)
            {
                frmConsultaFecha.Close();
            }
            else if (frmConsultaTecnico != null)
            {
                frmConsultaTecnico.Close();
            }
        }

        private void equiposToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEquiposConsulta consulta = new frmEquiposConsulta();
            consulta.MdiParent = this;
            consulta.Show();
        }

        private void volverAlInicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInicio incio= new frmInicio();
            incio.Show();
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tecnicoToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void equiposToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
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

        private void informaciónJugadorToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void estadisticaToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void partidosToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void calendarioToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void resultadosToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
