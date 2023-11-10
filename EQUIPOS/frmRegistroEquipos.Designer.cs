namespace SoccerLineF
{
    partial class frmRegistroEquipos
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.btnConsultaGeneral = new System.Windows.Forms.Button();
            this.txtTecnicoId = new System.Windows.Forms.TextBox();
            this.lblTecnicoId = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegistrarE = new System.Windows.Forms.Button();
            this.txtColoresEquipo = new System.Windows.Forms.TextBox();
            this.lblColores = new System.Windows.Forms.Label();
            this.txtUbicacionEquipo = new System.Windows.Forms.TextBox();
            this.lblUbicacionEquipo = new System.Windows.Forms.Label();
            this.txtNombreEquipo = new System.Windows.Forms.TextBox();
            this.lblNombreEquipo = new System.Windows.Forms.Label();
            this.txtIdEquipo = new System.Windows.Forms.TextBox();
            this.lblIdEquipo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgRegistroEquipos = new System.Windows.Forms.DataGridView();
            this.panelSuperior.SuspendLayout();
            this.panelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRegistroEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.RosyBrown;
            this.panelSuperior.Controls.Add(this.lblTitulo);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1824, 58);
            this.panelSuperior.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(448, 36);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Interfaz de registro de equipos";
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelLateral.Controls.Add(this.btnConsultaGeneral);
            this.panelLateral.Controls.Add(this.txtTecnicoId);
            this.panelLateral.Controls.Add(this.lblTecnicoId);
            this.panelLateral.Controls.Add(this.btnEliminar);
            this.panelLateral.Controls.Add(this.btnModificar);
            this.panelLateral.Controls.Add(this.btnRegistrarE);
            this.panelLateral.Controls.Add(this.txtColoresEquipo);
            this.panelLateral.Controls.Add(this.lblColores);
            this.panelLateral.Controls.Add(this.txtUbicacionEquipo);
            this.panelLateral.Controls.Add(this.lblUbicacionEquipo);
            this.panelLateral.Controls.Add(this.txtNombreEquipo);
            this.panelLateral.Controls.Add(this.lblNombreEquipo);
            this.panelLateral.Controls.Add(this.txtIdEquipo);
            this.panelLateral.Controls.Add(this.lblIdEquipo);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 58);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(632, 815);
            this.panelLateral.TabIndex = 2;
            // 
            // btnConsultaGeneral
            // 
            this.btnConsultaGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnConsultaGeneral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaGeneral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnConsultaGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaGeneral.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaGeneral.ForeColor = System.Drawing.Color.White;
            this.btnConsultaGeneral.Location = new System.Drawing.Point(213, 717);
            this.btnConsultaGeneral.Name = "btnConsultaGeneral";
            this.btnConsultaGeneral.Size = new System.Drawing.Size(194, 56);
            this.btnConsultaGeneral.TabIndex = 16;
            this.btnConsultaGeneral.Text = "CONSULTAR EQUIPOS EXISTENTES";
            this.btnConsultaGeneral.UseVisualStyleBackColor = false;
            this.btnConsultaGeneral.Click += new System.EventHandler(this.btnConsultaGeneral_Click);
            // 
            // txtTecnicoId
            // 
            this.txtTecnicoId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTecnicoId.Location = new System.Drawing.Point(29, 415);
            this.txtTecnicoId.Name = "txtTecnicoId";
            this.txtTecnicoId.Size = new System.Drawing.Size(177, 20);
            this.txtTecnicoId.TabIndex = 15;
            // 
            // lblTecnicoId
            // 
            this.lblTecnicoId.AutoSize = true;
            this.lblTecnicoId.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTecnicoId.ForeColor = System.Drawing.Color.White;
            this.lblTecnicoId.Location = new System.Drawing.Point(23, 379);
            this.lblTecnicoId.Name = "lblTecnicoId";
            this.lblTecnicoId.Size = new System.Drawing.Size(200, 33);
            this.lblTecnicoId.TabIndex = 14;
            this.lblTecnicoId.Text = "ID del tecnico";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(413, 498);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(194, 32);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "ELIMINAR EQUIPO";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(213, 498);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(194, 32);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRegistrarE
            // 
            this.btnRegistrarE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnRegistrarE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnRegistrarE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarE.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarE.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarE.Location = new System.Drawing.Point(12, 498);
            this.btnRegistrarE.Name = "btnRegistrarE";
            this.btnRegistrarE.Size = new System.Drawing.Size(194, 32);
            this.btnRegistrarE.TabIndex = 11;
            this.btnRegistrarE.Text = "REGISTRAR EQUIPO";
            this.btnRegistrarE.UseVisualStyleBackColor = false;
            this.btnRegistrarE.Click += new System.EventHandler(this.btnRegistrarE_Click);
            // 
            // txtColoresEquipo
            // 
            this.txtColoresEquipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtColoresEquipo.Location = new System.Drawing.Point(29, 342);
            this.txtColoresEquipo.Name = "txtColoresEquipo";
            this.txtColoresEquipo.Size = new System.Drawing.Size(314, 20);
            this.txtColoresEquipo.TabIndex = 10;
            // 
            // lblColores
            // 
            this.lblColores.AutoSize = true;
            this.lblColores.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColores.ForeColor = System.Drawing.Color.White;
            this.lblColores.Location = new System.Drawing.Point(23, 306);
            this.lblColores.Name = "lblColores";
            this.lblColores.Size = new System.Drawing.Size(266, 33);
            this.lblColores.TabIndex = 9;
            this.lblColores.Text = "Colores del equipo";
            // 
            // txtUbicacionEquipo
            // 
            this.txtUbicacionEquipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUbicacionEquipo.Location = new System.Drawing.Point(29, 270);
            this.txtUbicacionEquipo.Name = "txtUbicacionEquipo";
            this.txtUbicacionEquipo.Size = new System.Drawing.Size(314, 20);
            this.txtUbicacionEquipo.TabIndex = 8;
            // 
            // lblUbicacionEquipo
            // 
            this.lblUbicacionEquipo.AutoSize = true;
            this.lblUbicacionEquipo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacionEquipo.ForeColor = System.Drawing.Color.White;
            this.lblUbicacionEquipo.Location = new System.Drawing.Point(23, 234);
            this.lblUbicacionEquipo.Name = "lblUbicacionEquipo";
            this.lblUbicacionEquipo.Size = new System.Drawing.Size(306, 33);
            this.lblUbicacionEquipo.TabIndex = 7;
            this.lblUbicacionEquipo.Text = "Ubicación del equipo ";
            // 
            // txtNombreEquipo
            // 
            this.txtNombreEquipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreEquipo.Location = new System.Drawing.Point(29, 189);
            this.txtNombreEquipo.Name = "txtNombreEquipo";
            this.txtNombreEquipo.Size = new System.Drawing.Size(314, 20);
            this.txtNombreEquipo.TabIndex = 6;
            // 
            // lblNombreEquipo
            // 
            this.lblNombreEquipo.AutoSize = true;
            this.lblNombreEquipo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEquipo.ForeColor = System.Drawing.Color.White;
            this.lblNombreEquipo.Location = new System.Drawing.Point(23, 153);
            this.lblNombreEquipo.Name = "lblNombreEquipo";
            this.lblNombreEquipo.Size = new System.Drawing.Size(274, 33);
            this.lblNombreEquipo.TabIndex = 5;
            this.lblNombreEquipo.Text = "Nombre del equipo";
            // 
            // txtIdEquipo
            // 
            this.txtIdEquipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdEquipo.Location = new System.Drawing.Point(29, 106);
            this.txtIdEquipo.Name = "txtIdEquipo";
            this.txtIdEquipo.Size = new System.Drawing.Size(314, 20);
            this.txtIdEquipo.TabIndex = 4;
            // 
            // lblIdEquipo
            // 
            this.lblIdEquipo.AutoSize = true;
            this.lblIdEquipo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEquipo.ForeColor = System.Drawing.Color.White;
            this.lblIdEquipo.Location = new System.Drawing.Point(23, 70);
            this.lblIdEquipo.Name = "lblIdEquipo";
            this.lblIdEquipo.Size = new System.Drawing.Size(192, 33);
            this.lblIdEquipo.TabIndex = 3;
            this.lblIdEquipo.Text = "ID del equipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(940, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Estos son los equipos registrados hasta el momento:";
            // 
            // dtgRegistroEquipos
            // 
            this.dtgRegistroEquipos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dtgRegistroEquipos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgRegistroEquipos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgRegistroEquipos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgRegistroEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRegistroEquipos.EnableHeadersVisualStyles = false;
            this.dtgRegistroEquipos.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgRegistroEquipos.Location = new System.Drawing.Point(944, 247);
            this.dtgRegistroEquipos.Name = "dtgRegistroEquipos";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dtgRegistroEquipos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgRegistroEquipos.Size = new System.Drawing.Size(710, 518);
            this.dtgRegistroEquipos.TabIndex = 5;
            this.dtgRegistroEquipos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgRegistroEquipos_CellContentClick);
            this.dtgRegistroEquipos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgRegistroEquipos_MouseClick);
            // 
            // frmRegistroEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1824, 873);
            this.Controls.Add(this.dtgRegistroEquipos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.panelSuperior);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistroEquipos";
            this.Text = "frmRegistroEquipos";
            this.Load += new System.EventHandler(this.frmRegistroEquipos_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRegistroEquipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgRegistroEquipos;
        private System.Windows.Forms.Button btnRegistrarE;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtColoresEquipo;
        private System.Windows.Forms.Label lblColores;
        private System.Windows.Forms.TextBox txtUbicacionEquipo;
        private System.Windows.Forms.Label lblUbicacionEquipo;
        private System.Windows.Forms.TextBox txtNombreEquipo;
        private System.Windows.Forms.Label lblNombreEquipo;
        private System.Windows.Forms.TextBox txtIdEquipo;
        private System.Windows.Forms.Label lblIdEquipo;
        private System.Windows.Forms.TextBox txtTecnicoId;
        private System.Windows.Forms.Label lblTecnicoId;
        private System.Windows.Forms.Button btnConsultaGeneral;
    }
}