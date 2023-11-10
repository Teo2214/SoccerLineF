namespace SoccerLineF
{
    partial class frmMenuAficionado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnustripAficionado = new System.Windows.Forms.MenuStrip();
            this.fberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesDeVentanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverAlInicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jugadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tecnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónJugadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnustripAficionado.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnustripAficionado
            // 
            this.mnustripAficionado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.mnustripAficionado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fberToolStripMenuItem,
            this.opcionesDeVentanaToolStripMenuItem});
            this.mnustripAficionado.Location = new System.Drawing.Point(0, 0);
            this.mnustripAficionado.Name = "mnustripAficionado";
            this.mnustripAficionado.Size = new System.Drawing.Size(1285, 24);
            this.mnustripAficionado.TabIndex = 1;
            this.mnustripAficionado.Text = "MenuAficionado";
            // 
            // fberToolStripMenuItem
            // 
            this.fberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tecnicoToolStripMenuItem,
            this.equiposToolStripMenuItem,
            this.jugadorToolStripMenuItem,
            this.partidosToolStripMenuItem,
            this.resultadosToolStripMenuItem,
            this.calendarioToolStripMenuItem});
            this.fberToolStripMenuItem.Name = "fberToolStripMenuItem";
            this.fberToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.fberToolStripMenuItem.Text = "Opciones de Ingreso ";
            this.fberToolStripMenuItem.Click += new System.EventHandler(this.fberToolStripMenuItem_Click);
            // 
            // partidosToolStripMenuItem
            // 
            this.partidosToolStripMenuItem.Name = "partidosToolStripMenuItem";
            this.partidosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.partidosToolStripMenuItem.Text = "Partidos ";
            this.partidosToolStripMenuItem.Click += new System.EventHandler(this.partidosToolStripMenuItem_Click);
            // 
            // resultadosToolStripMenuItem
            // 
            this.resultadosToolStripMenuItem.Name = "resultadosToolStripMenuItem";
            this.resultadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resultadosToolStripMenuItem.Text = "Resultados ";
            this.resultadosToolStripMenuItem.Click += new System.EventHandler(this.resultadosToolStripMenuItem_Click);
            // 
            // calendarioToolStripMenuItem
            // 
            this.calendarioToolStripMenuItem.Name = "calendarioToolStripMenuItem";
            this.calendarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calendarioToolStripMenuItem.Text = "Calendario";
            this.calendarioToolStripMenuItem.Click += new System.EventHandler(this.calendarioToolStripMenuItem_Click);
            // 
            // opcionesDeVentanaToolStripMenuItem
            // 
            this.opcionesDeVentanaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverAlInicioToolStripMenuItem,
            this.cerrarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.opcionesDeVentanaToolStripMenuItem.Name = "opcionesDeVentanaToolStripMenuItem";
            this.opcionesDeVentanaToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.opcionesDeVentanaToolStripMenuItem.Text = "Opciones de Ventana";
            // 
            // volverAlInicioToolStripMenuItem
            // 
            this.volverAlInicioToolStripMenuItem.Name = "volverAlInicioToolStripMenuItem";
            this.volverAlInicioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F11)));
            this.volverAlInicioToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.volverAlInicioToolStripMenuItem.Text = "Volver al Inicio ";
            this.volverAlInicioToolStripMenuItem.Click += new System.EventHandler(this.volverAlInicioToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar Ventana";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // equiposToolStripMenuItem
            // 
            this.equiposToolStripMenuItem.Name = "equiposToolStripMenuItem";
            this.equiposToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.equiposToolStripMenuItem.Text = "Equipos";
            this.equiposToolStripMenuItem.Click += new System.EventHandler(this.equiposToolStripMenuItem_Click_1);
            // 
            // jugadorToolStripMenuItem
            // 
            this.jugadorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaciónJugadorToolStripMenuItem,
            this.estadisticaToolStripMenuItem});
            this.jugadorToolStripMenuItem.Name = "jugadorToolStripMenuItem";
            this.jugadorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jugadorToolStripMenuItem.Text = "Jugador";
            // 
            // tecnicoToolStripMenuItem
            // 
            this.tecnicoToolStripMenuItem.Name = "tecnicoToolStripMenuItem";
            this.tecnicoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tecnicoToolStripMenuItem.Text = "Tecnico";
            this.tecnicoToolStripMenuItem.Click += new System.EventHandler(this.tecnicoToolStripMenuItem_Click);
            // 
            // informaciónJugadorToolStripMenuItem
            // 
            this.informaciónJugadorToolStripMenuItem.Name = "informaciónJugadorToolStripMenuItem";
            this.informaciónJugadorToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.informaciónJugadorToolStripMenuItem.Text = "Información Jugador";
            this.informaciónJugadorToolStripMenuItem.Click += new System.EventHandler(this.informaciónJugadorToolStripMenuItem_Click);
            // 
            // estadisticaToolStripMenuItem
            // 
            this.estadisticaToolStripMenuItem.Name = "estadisticaToolStripMenuItem";
            this.estadisticaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.estadisticaToolStripMenuItem.Text = "Estadistica";
            this.estadisticaToolStripMenuItem.Click += new System.EventHandler(this.estadisticaToolStripMenuItem_Click);
            // 
            // frmMenuAficionado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1285, 706);
            this.Controls.Add(this.mnustripAficionado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnustripAficionado;
            this.Name = "frmMenuAficionado";
            this.Text = "Menú";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnustripAficionado.ResumeLayout(false);
            this.mnustripAficionado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnustripAficionado;
        private System.Windows.Forms.ToolStripMenuItem fberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesDeVentanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverAlInicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tecnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jugadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaciónJugadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticaToolStripMenuItem;
    }
}