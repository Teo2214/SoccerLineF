namespace SoccerLineF
{
    partial class frmJugadorRegistro
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
            this.panelLateral = new System.Windows.Forms.Panel();
            this.btnConsultaGeneral = new System.Windows.Forms.Button();
            this.btnEliminarJ = new System.Windows.Forms.Button();
            this.btnModificarJ = new System.Windows.Forms.Button();
            this.btnRegistrarJ = new System.Windows.Forms.Button();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dtgRegistroJugador = new System.Windows.Forms.DataGridView();
            this.txtEdadJugador = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtApellidoJugador = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombreJugador = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtIdJugador = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtPosicionJugador = new System.Windows.Forms.TextBox();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.txtIdEquipoJ = new System.Windows.Forms.TextBox();
            this.lblIdEquipo = new System.Windows.Forms.Label();
            this.panelLateral.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRegistroJugador)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.RosyBrown;
            this.panelLateral.Controls.Add(this.btnConsultaGeneral);
            this.panelLateral.Controls.Add(this.btnEliminarJ);
            this.panelLateral.Controls.Add(this.btnModificarJ);
            this.panelLateral.Controls.Add(this.btnRegistrarJ);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(200, 873);
            this.panelLateral.TabIndex = 0;
            // 
            // btnConsultaGeneral
            // 
            this.btnConsultaGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnConsultaGeneral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaGeneral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnConsultaGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaGeneral.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaGeneral.ForeColor = System.Drawing.Color.White;
            this.btnConsultaGeneral.Location = new System.Drawing.Point(3, 745);
            this.btnConsultaGeneral.Name = "btnConsultaGeneral";
            this.btnConsultaGeneral.Size = new System.Drawing.Size(194, 55);
            this.btnConsultaGeneral.TabIndex = 17;
            this.btnConsultaGeneral.Text = "CONSULTAR JUGADOR EXISTENTE";
            this.btnConsultaGeneral.UseVisualStyleBackColor = false;
            this.btnConsultaGeneral.Click += new System.EventHandler(this.btnConsultaGeneral_Click);
            // 
            // btnEliminarJ
            // 
            this.btnEliminarJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEliminarJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarJ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnEliminarJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarJ.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarJ.ForeColor = System.Drawing.Color.White;
            this.btnEliminarJ.Location = new System.Drawing.Point(3, 415);
            this.btnEliminarJ.Name = "btnEliminarJ";
            this.btnEliminarJ.Size = new System.Drawing.Size(194, 32);
            this.btnEliminarJ.TabIndex = 16;
            this.btnEliminarJ.Text = "ELIMINAR JUGADOR";
            this.btnEliminarJ.UseVisualStyleBackColor = false;
            this.btnEliminarJ.Click += new System.EventHandler(this.btnEliminarJ_Click);
            // 
            // btnModificarJ
            // 
            this.btnModificarJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnModificarJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarJ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnModificarJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarJ.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarJ.ForeColor = System.Drawing.Color.White;
            this.btnModificarJ.Location = new System.Drawing.Point(3, 273);
            this.btnModificarJ.Name = "btnModificarJ";
            this.btnModificarJ.Size = new System.Drawing.Size(194, 32);
            this.btnModificarJ.TabIndex = 15;
            this.btnModificarJ.Text = "MODIFICAR";
            this.btnModificarJ.UseVisualStyleBackColor = false;
            this.btnModificarJ.Click += new System.EventHandler(this.btnModificarJ_Click);
            // 
            // btnRegistrarJ
            // 
            this.btnRegistrarJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnRegistrarJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarJ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnRegistrarJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarJ.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarJ.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarJ.Location = new System.Drawing.Point(3, 139);
            this.btnRegistrarJ.Name = "btnRegistrarJ";
            this.btnRegistrarJ.Size = new System.Drawing.Size(194, 32);
            this.btnRegistrarJ.TabIndex = 14;
            this.btnRegistrarJ.Text = "REGISTRAR JUGADOR";
            this.btnRegistrarJ.UseVisualStyleBackColor = false;
            this.btnRegistrarJ.Click += new System.EventHandler(this.btnRegistrarJ_Click);
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelSuperior.Controls.Add(this.lblTitulo);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(200, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1624, 100);
            this.panelSuperior.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(308, 32);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(477, 36);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Interfaz de registro de jugadores";
            // 
            // dtgRegistroJugador
            // 
            this.dtgRegistroJugador.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dtgRegistroJugador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgRegistroJugador.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgRegistroJugador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgRegistroJugador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRegistroJugador.EnableHeadersVisualStyles = false;
            this.dtgRegistroJugador.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgRegistroJugador.Location = new System.Drawing.Point(935, 175);
            this.dtgRegistroJugador.Name = "dtgRegistroJugador";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dtgRegistroJugador.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgRegistroJugador.Size = new System.Drawing.Size(790, 432);
            this.dtgRegistroJugador.TabIndex = 6;
            this.dtgRegistroJugador.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgRegistroJugador_MouseClick);
            // 
            // txtEdadJugador
            // 
            this.txtEdadJugador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEdadJugador.Location = new System.Drawing.Point(284, 368);
            this.txtEdadJugador.Name = "txtEdadJugador";
            this.txtEdadJugador.Size = new System.Drawing.Size(314, 20);
            this.txtEdadJugador.TabIndex = 18;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.ForeColor = System.Drawing.Color.White;
            this.lblEdad.Location = new System.Drawing.Point(283, 332);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(85, 33);
            this.lblEdad.TabIndex = 17;
            this.lblEdad.Text = "Edad";
            // 
            // txtApellidoJugador
            // 
            this.txtApellidoJugador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoJugador.Location = new System.Drawing.Point(284, 309);
            this.txtApellidoJugador.Name = "txtApellidoJugador";
            this.txtApellidoJugador.Size = new System.Drawing.Size(314, 20);
            this.txtApellidoJugador.TabIndex = 16;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(283, 273);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(125, 33);
            this.lblApellido.TabIndex = 15;
            this.lblApellido.Text = "Apellido";
            // 
            // txtNombreJugador
            // 
            this.txtNombreJugador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreJugador.Location = new System.Drawing.Point(284, 246);
            this.txtNombreJugador.Name = "txtNombreJugador";
            this.txtNombreJugador.Size = new System.Drawing.Size(314, 20);
            this.txtNombreJugador.TabIndex = 14;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(278, 210);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(130, 33);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre ";
            // 
            // txtIdJugador
            // 
            this.txtIdJugador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdJugador.Location = new System.Drawing.Point(284, 175);
            this.txtIdJugador.Name = "txtIdJugador";
            this.txtIdJugador.Size = new System.Drawing.Size(314, 20);
            this.txtIdJugador.TabIndex = 12;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(278, 139);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(208, 33);
            this.lblId.TabIndex = 11;
            this.lblId.Text = "ID del Jugador";
            // 
            // txtPosicionJugador
            // 
            this.txtPosicionJugador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPosicionJugador.Location = new System.Drawing.Point(284, 427);
            this.txtPosicionJugador.Name = "txtPosicionJugador";
            this.txtPosicionJugador.Size = new System.Drawing.Size(314, 20);
            this.txtPosicionJugador.TabIndex = 20;
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicion.ForeColor = System.Drawing.Color.White;
            this.lblPosicion.Location = new System.Drawing.Point(283, 391);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(122, 33);
            this.lblPosicion.TabIndex = 19;
            this.lblPosicion.Text = "Posición";
            // 
            // txtIdEquipoJ
            // 
            this.txtIdEquipoJ.Location = new System.Drawing.Point(284, 557);
            this.txtIdEquipoJ.Name = "txtIdEquipoJ";
            this.txtIdEquipoJ.Size = new System.Drawing.Size(84, 20);
            this.txtIdEquipoJ.TabIndex = 22;
            // 
            // lblIdEquipo
            // 
            this.lblIdEquipo.AutoSize = true;
            this.lblIdEquipo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEquipo.ForeColor = System.Drawing.Color.White;
            this.lblIdEquipo.Location = new System.Drawing.Point(278, 521);
            this.lblIdEquipo.Name = "lblIdEquipo";
            this.lblIdEquipo.Size = new System.Drawing.Size(437, 33);
            this.lblIdEquipo.TabIndex = 21;
            this.lblIdEquipo.Text = "ID del equipo al que pertenece ";
            // 
            // frmJugadorRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1824, 873);
            this.Controls.Add(this.txtIdEquipoJ);
            this.Controls.Add(this.lblIdEquipo);
            this.Controls.Add(this.txtPosicionJugador);
            this.Controls.Add(this.lblPosicion);
            this.Controls.Add(this.txtEdadJugador);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.txtApellidoJugador);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombreJugador);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtIdJugador);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dtgRegistroJugador);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmJugadorRegistro";
            this.Text = "frmJugadorRegistro";
            this.Load += new System.EventHandler(this.frmJugadorRegistro_Load);
            this.panelLateral.ResumeLayout(false);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRegistroJugador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Button btnEliminarJ;
        private System.Windows.Forms.Button btnModificarJ;
        private System.Windows.Forms.Button btnRegistrarJ;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dtgRegistroJugador;
        private System.Windows.Forms.TextBox txtEdadJugador;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtApellidoJugador;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombreJugador;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtIdJugador;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtPosicionJugador;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.TextBox txtIdEquipoJ;
        private System.Windows.Forms.Label lblIdEquipo;
        private System.Windows.Forms.Button btnConsultaGeneral;
    }
}