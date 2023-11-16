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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
           frmRegistro registro = new frmRegistro();
            registro.Show();
            this.Hide();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            frmIniciarSesion iniciarSesion = new frmIniciarSesion();
            iniciarSesion.Show();
            this.Hide();
        }

        private void panelCentral_Paint(object sender, PaintEventArgs e)
        {
            timerInicio.Enabled = true;
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void timerInicio_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btnTerminosCondiciones_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Términos y Condiciones de Uso para la Aplicación de Gestión Deportiva SoccerLine: Bienvenido/a a nuestra aplicación de gestión deportiva simulada. Antes de utilizar nuestra aplicación, por favor, lee detenidamente los siguientes términos y condiciones. Al acceder y utilizar nuestra aplicación, aceptas cumplir con estos términos"+
                ". Si no estás de acuerdo con alguno de los términos a continuación, por favor, no utilices nuestra aplicación. 1. Uso Aceptable:La aplicación está destinada únicamente para fines de simulación de gestión deportiva. Cualquier otro uso no autorizado está prohibido. 2. Datos Personales:Al utilizar la aplicación, puedes proporcionar datos personales."+
                " Nos comprometemos a proteger tu privacidad de acuerdo con nuestra Política de Privacidad. 3.Responsabilidad:No nos hacemos responsables de la precisión de los datos simulados o de las decisiones tomadas en la aplicación. La aplicación es solo para fines de entretenimiento y simulación. 4.Propiedad Intelectual:Todos los derechos de propiedad intelectual relacionados con la aplicación y su contenido son propiedad exclusiva nuestra."+
                " No tienes derecho a reproducir, distribuir o modificar la aplicación sin nuestro permiso. 5.Actualizaciones y Cambios:Nos reservamos el derecho de realizar cambios en la aplicación, incluyendo actualizaciones y modificaciones en los términos y condiciones, en cualquier momento sin previo aviso."+
                " 6.Enlaces a Terceros:La aplicación puede contener enlaces a sitios web de terceros. No somos responsables de la disponibilidad o contenido de dichos sitios web. 7.Terminación:Nos reservamos el derecho de terminar tu acceso a la aplicación en caso de violación de estos términos y condiciones."+
                " 8.Ley Aplicable:Estos términos y condiciones están sujetos a las leyes del lugar donde operamos. 9.Contacto:Para preguntas o inquietudes sobre estos términos y condiciones, contáctanos a través del correo electrónico echeverrimateo2004@gmail.com." +
                "Gracias por utilizar nuestra aplicación de gestión deportiva simulada. ¡Disfruta de tu experiencia!");
        }
    }
}
