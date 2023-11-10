namespace SoccerLineF
{
    partial class frmRegistroEstadistica
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblregistroEJ = new System.Windows.Forms.Label();
            this.dtgRegistroEstadisticaJugadores = new System.Windows.Forms.DataGridView();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.txtPartidoId = new System.Windows.Forms.TextBox();
            this.txtJugadorId = new System.Windows.Forms.TextBox();
            this.lblPartidoId = new System.Windows.Forms.Label();
            this.lblJugadorId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConsultaGenral = new System.Windows.Forms.Button();
            this.btneliminarEstadistica = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btningresar = new System.Windows.Forms.Button();
            this.txtEstadisticaID = new System.Windows.Forms.TextBox();
            this.txtasistencia = new System.Windows.Forms.TextBox();
            this.lblestadisticasID = new System.Windows.Forms.Label();
            this.lblasistencia = new System.Windows.Forms.Label();
            this.txtrebotes = new System.Windows.Forms.TextBox();
            this.lblpuntos = new System.Windows.Forms.Label();
            this.txtpuntos = new System.Windows.Forms.TextBox();
            this.lblrebotes = new System.Windows.Forms.Label();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRegistroEstadisticaJugadores)).BeginInit();
            this.panelLateral.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.RosyBrown;
            this.panelSuperior.Controls.Add(this.lblregistroEJ);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(632, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1192, 78);
            this.panelSuperior.TabIndex = 18;
            // 
            // lblregistroEJ
            // 
            this.lblregistroEJ.AutoSize = true;
            this.lblregistroEJ.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregistroEJ.ForeColor = System.Drawing.Color.White;
            this.lblregistroEJ.Location = new System.Drawing.Point(12, 9);
            this.lblregistroEJ.Name = "lblregistroEJ";
            this.lblregistroEJ.Size = new System.Drawing.Size(558, 36);
            this.lblregistroEJ.TabIndex = 4;
            this.lblregistroEJ.Text = "Interfaz Registro Estadistica Jugadores";
            // 
            // dtgRegistroEstadisticaJugadores
            // 
            this.dtgRegistroEstadisticaJugadores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dtgRegistroEstadisticaJugadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgRegistroEstadisticaJugadores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgRegistroEstadisticaJugadores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgRegistroEstadisticaJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRegistroEstadisticaJugadores.EnableHeadersVisualStyles = false;
            this.dtgRegistroEstadisticaJugadores.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgRegistroEstadisticaJugadores.Location = new System.Drawing.Point(893, 183);
            this.dtgRegistroEstadisticaJugadores.Name = "dtgRegistroEstadisticaJugadores";
            this.dtgRegistroEstadisticaJugadores.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dtgRegistroEstadisticaJugadores.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgRegistroEstadisticaJugadores.Size = new System.Drawing.Size(680, 440);
            this.dtgRegistroEstadisticaJugadores.TabIndex = 17;
            this.dtgRegistroEstadisticaJugadores.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgRegistroEstadisticaJugadores_MouseClick);
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelLateral.Controls.Add(this.txtPartidoId);
            this.panelLateral.Controls.Add(this.txtJugadorId);
            this.panelLateral.Controls.Add(this.lblPartidoId);
            this.panelLateral.Controls.Add(this.lblJugadorId);
            this.panelLateral.Controls.Add(this.panel1);
            this.panelLateral.Controls.Add(this.txtEstadisticaID);
            this.panelLateral.Controls.Add(this.txtasistencia);
            this.panelLateral.Controls.Add(this.lblestadisticasID);
            this.panelLateral.Controls.Add(this.lblasistencia);
            this.panelLateral.Controls.Add(this.txtrebotes);
            this.panelLateral.Controls.Add(this.lblpuntos);
            this.panelLateral.Controls.Add(this.txtpuntos);
            this.panelLateral.Controls.Add(this.lblrebotes);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(632, 873);
            this.panelLateral.TabIndex = 16;
            // 
            // txtPartidoId
            // 
            this.txtPartidoId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPartidoId.Location = new System.Drawing.Point(235, 775);
            this.txtPartidoId.Name = "txtPartidoId";
            this.txtPartidoId.Size = new System.Drawing.Size(221, 20);
            this.txtPartidoId.TabIndex = 24;
            // 
            // txtJugadorId
            // 
            this.txtJugadorId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtJugadorId.Location = new System.Drawing.Point(234, 657);
            this.txtJugadorId.Name = "txtJugadorId";
            this.txtJugadorId.Size = new System.Drawing.Size(221, 20);
            this.txtJugadorId.TabIndex = 23;
            // 
            // lblPartidoId
            // 
            this.lblPartidoId.AutoSize = true;
            this.lblPartidoId.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartidoId.ForeColor = System.Drawing.Color.White;
            this.lblPartidoId.Location = new System.Drawing.Point(229, 729);
            this.lblPartidoId.Name = "lblPartidoId";
            this.lblPartidoId.Size = new System.Drawing.Size(143, 33);
            this.lblPartidoId.TabIndex = 22;
            this.lblPartidoId.Text = "Partido ID";
            // 
            // lblJugadorId
            // 
            this.lblJugadorId.AutoSize = true;
            this.lblJugadorId.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugadorId.ForeColor = System.Drawing.Color.White;
            this.lblJugadorId.Location = new System.Drawing.Point(229, 610);
            this.lblJugadorId.Name = "lblJugadorId";
            this.lblJugadorId.Size = new System.Drawing.Size(158, 33);
            this.lblJugadorId.TabIndex = 21;
            this.lblJugadorId.Text = "Jugador ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.btnConsultaGenral);
            this.panel1.Controls.Add(this.btneliminarEstadistica);
            this.panel1.Controls.Add(this.btnmodificar);
            this.panel1.Controls.Add(this.btningresar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 873);
            this.panel1.TabIndex = 20;
            // 
            // btnConsultaGenral
            // 
            this.btnConsultaGenral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnConsultaGenral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaGenral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnConsultaGenral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaGenral.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaGenral.ForeColor = System.Drawing.Color.White;
            this.btnConsultaGenral.Location = new System.Drawing.Point(3, 775);
            this.btnConsultaGenral.Name = "btnConsultaGenral";
            this.btnConsultaGenral.Size = new System.Drawing.Size(194, 56);
            this.btnConsultaGenral.TabIndex = 17;
            this.btnConsultaGenral.Text = "CONSULTAR ESTADISTICA EXISTENTE\r\n";
            this.btnConsultaGenral.UseVisualStyleBackColor = false;
            this.btnConsultaGenral.Click += new System.EventHandler(this.btnConsultaGenral_Click);
            // 
            // btneliminarEstadistica
            // 
            this.btneliminarEstadistica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btneliminarEstadistica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminarEstadistica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btneliminarEstadistica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminarEstadistica.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminarEstadistica.ForeColor = System.Drawing.Color.White;
            this.btneliminarEstadistica.Location = new System.Drawing.Point(3, 575);
            this.btneliminarEstadistica.Name = "btneliminarEstadistica";
            this.btneliminarEstadistica.Size = new System.Drawing.Size(194, 32);
            this.btneliminarEstadistica.TabIndex = 16;
            this.btneliminarEstadistica.Text = "ELIMINAR ESTADISTICA";
            this.btneliminarEstadistica.UseVisualStyleBackColor = false;
            this.btneliminarEstadistica.Click += new System.EventHandler(this.btneliminarEstadistica_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnmodificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmodificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodificar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.ForeColor = System.Drawing.Color.White;
            this.btnmodificar.Location = new System.Drawing.Point(3, 512);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(194, 32);
            this.btnmodificar.TabIndex = 15;
            this.btnmodificar.Text = "MODIFICAR";
            this.btnmodificar.UseVisualStyleBackColor = false;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btningresar
            // 
            this.btningresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btningresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btningresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btningresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btningresar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btningresar.ForeColor = System.Drawing.Color.White;
            this.btningresar.Location = new System.Drawing.Point(3, 454);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(194, 32);
            this.btningresar.TabIndex = 14;
            this.btningresar.Text = "INGRESAR";
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // txtEstadisticaID
            // 
            this.txtEstadisticaID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstadisticaID.Location = new System.Drawing.Point(234, 567);
            this.txtEstadisticaID.Name = "txtEstadisticaID";
            this.txtEstadisticaID.Size = new System.Drawing.Size(221, 20);
            this.txtEstadisticaID.TabIndex = 19;
            // 
            // txtasistencia
            // 
            this.txtasistencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtasistencia.Location = new System.Drawing.Point(234, 477);
            this.txtasistencia.Name = "txtasistencia";
            this.txtasistencia.Size = new System.Drawing.Size(221, 20);
            this.txtasistencia.TabIndex = 18;
            // 
            // lblestadisticasID
            // 
            this.lblestadisticasID.AutoSize = true;
            this.lblestadisticasID.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestadisticasID.ForeColor = System.Drawing.Color.White;
            this.lblestadisticasID.Location = new System.Drawing.Point(229, 522);
            this.lblestadisticasID.Name = "lblestadisticasID";
            this.lblestadisticasID.Size = new System.Drawing.Size(186, 33);
            this.lblestadisticasID.TabIndex = 17;
            this.lblestadisticasID.Text = "Estadistica ID";
            // 
            // lblasistencia
            // 
            this.lblasistencia.AutoSize = true;
            this.lblasistencia.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblasistencia.ForeColor = System.Drawing.Color.White;
            this.lblasistencia.Location = new System.Drawing.Point(229, 432);
            this.lblasistencia.Name = "lblasistencia";
            this.lblasistencia.Size = new System.Drawing.Size(145, 33);
            this.lblasistencia.TabIndex = 16;
            this.lblasistencia.Text = "Asistencia";
            // 
            // txtrebotes
            // 
            this.txtrebotes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtrebotes.Location = new System.Drawing.Point(234, 401);
            this.txtrebotes.Name = "txtrebotes";
            this.txtrebotes.Size = new System.Drawing.Size(221, 20);
            this.txtrebotes.TabIndex = 15;
            // 
            // lblpuntos
            // 
            this.lblpuntos.AutoSize = true;
            this.lblpuntos.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpuntos.ForeColor = System.Drawing.Color.White;
            this.lblpuntos.Location = new System.Drawing.Point(229, 281);
            this.lblpuntos.Name = "lblpuntos";
            this.lblpuntos.Size = new System.Drawing.Size(101, 33);
            this.lblpuntos.TabIndex = 14;
            this.lblpuntos.Text = "Puntos";
            // 
            // txtpuntos
            // 
            this.txtpuntos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpuntos.Location = new System.Drawing.Point(234, 324);
            this.txtpuntos.Name = "txtpuntos";
            this.txtpuntos.Size = new System.Drawing.Size(221, 20);
            this.txtpuntos.TabIndex = 4;
            // 
            // lblrebotes
            // 
            this.lblrebotes.AutoSize = true;
            this.lblrebotes.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrebotes.ForeColor = System.Drawing.Color.White;
            this.lblrebotes.Location = new System.Drawing.Point(229, 353);
            this.lblrebotes.Name = "lblrebotes";
            this.lblrebotes.Size = new System.Drawing.Size(123, 33);
            this.lblrebotes.TabIndex = 3;
            this.lblrebotes.Text = "Rebotes";
            // 
            // frmRegistroEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1824, 873);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.dtgRegistroEstadisticaJugadores);
            this.Controls.Add(this.panelLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistroEstadistica";
            this.Text = "frmRegistroEstadistica";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRegistroEstadisticaJugadores)).EndInit();
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblregistroEJ;
        private System.Windows.Forms.DataGridView dtgRegistroEstadisticaJugadores;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btneliminarEstadistica;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.TextBox txtEstadisticaID;
        private System.Windows.Forms.TextBox txtasistencia;
        private System.Windows.Forms.Label lblestadisticasID;
        private System.Windows.Forms.Label lblasistencia;
        private System.Windows.Forms.TextBox txtrebotes;
        private System.Windows.Forms.Label lblpuntos;
        private System.Windows.Forms.TextBox txtpuntos;
        private System.Windows.Forms.Label lblrebotes;
        private System.Windows.Forms.TextBox txtPartidoId;
        private System.Windows.Forms.TextBox txtJugadorId;
        private System.Windows.Forms.Label lblPartidoId;
        private System.Windows.Forms.Label lblJugadorId;
        private System.Windows.Forms.Button btnConsultaGenral;
    }
}