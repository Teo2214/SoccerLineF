namespace SoccerLineF
{
    partial class frmRegistroCalendario
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
            this.btnConsultaGeneral = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegistrarF = new System.Windows.Forms.Button();
            this.dtgRegistroCalendario = new System.Windows.Forms.DataGridView();
            this.txtIdPartido = new System.Windows.Forms.TextBox();
            this.lblIdPartido = new System.Windows.Forms.Label();
            this.dtFechaCalendario = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtIdCalendario = new System.Windows.Forms.TextBox();
            this.lblIdCalendario = new System.Windows.Forms.Label();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRegistroCalendario)).BeginInit();
            this.panelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConsultaGeneral
            // 
            this.btnConsultaGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnConsultaGeneral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaGeneral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnConsultaGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaGeneral.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaGeneral.ForeColor = System.Drawing.Color.White;
            this.btnConsultaGeneral.Location = new System.Drawing.Point(1399, 590);
            this.btnConsultaGeneral.Name = "btnConsultaGeneral";
            this.btnConsultaGeneral.Size = new System.Drawing.Size(194, 56);
            this.btnConsultaGeneral.TabIndex = 34;
            this.btnConsultaGeneral.Text = "CONSULTAR FECHAS EXISTENTES";
            this.btnConsultaGeneral.UseVisualStyleBackColor = false;
            this.btnConsultaGeneral.Click += new System.EventHandler(this.btnConsultaGeneral_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(1599, 371);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(194, 32);
            this.btnEliminar.TabIndex = 33;
            this.btnEliminar.Text = "ELIMINAR FECHA";
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
            this.btnModificar.Location = new System.Drawing.Point(1399, 371);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(194, 32);
            this.btnModificar.TabIndex = 32;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRegistrarF
            // 
            this.btnRegistrarF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnRegistrarF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnRegistrarF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarF.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarF.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarF.Location = new System.Drawing.Point(1198, 371);
            this.btnRegistrarF.Name = "btnRegistrarF";
            this.btnRegistrarF.Size = new System.Drawing.Size(194, 32);
            this.btnRegistrarF.TabIndex = 31;
            this.btnRegistrarF.Text = "REGISTRAR FECHA";
            this.btnRegistrarF.UseVisualStyleBackColor = false;
            this.btnRegistrarF.Click += new System.EventHandler(this.btnRegistrarF_Click);
            // 
            // dtgRegistroCalendario
            // 
            this.dtgRegistroCalendario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dtgRegistroCalendario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgRegistroCalendario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgRegistroCalendario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgRegistroCalendario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRegistroCalendario.EnableHeadersVisualStyles = false;
            this.dtgRegistroCalendario.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgRegistroCalendario.Location = new System.Drawing.Point(446, 278);
            this.dtgRegistroCalendario.Name = "dtgRegistroCalendario";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dtgRegistroCalendario.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgRegistroCalendario.Size = new System.Drawing.Size(710, 518);
            this.dtgRegistroCalendario.TabIndex = 30;
            this.dtgRegistroCalendario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgRegistroCalendario_MouseClick);
            // 
            // txtIdPartido
            // 
            this.txtIdPartido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdPartido.Location = new System.Drawing.Point(18, 462);
            this.txtIdPartido.Name = "txtIdPartido";
            this.txtIdPartido.Size = new System.Drawing.Size(220, 20);
            this.txtIdPartido.TabIndex = 29;
            // 
            // lblIdPartido
            // 
            this.lblIdPartido.AutoSize = true;
            this.lblIdPartido.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPartido.ForeColor = System.Drawing.Color.White;
            this.lblIdPartido.Location = new System.Drawing.Point(12, 410);
            this.lblIdPartido.Name = "lblIdPartido";
            this.lblIdPartido.Size = new System.Drawing.Size(202, 33);
            this.lblIdPartido.TabIndex = 28;
            this.lblIdPartido.Text = "ID del partido ";
            // 
            // dtFechaCalendario
            // 
            this.dtFechaCalendario.Location = new System.Drawing.Point(579, 210);
            this.dtFechaCalendario.Name = "dtFechaCalendario";
            this.dtFechaCalendario.Size = new System.Drawing.Size(406, 20);
            this.dtFechaCalendario.TabIndex = 25;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(565, 174);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(420, 33);
            this.lblFecha.TabIndex = 24;
            this.lblFecha.Text = "Seleccione la fecha a registrar ";
            // 
            // txtIdCalendario
            // 
            this.txtIdCalendario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdCalendario.Location = new System.Drawing.Point(18, 219);
            this.txtIdCalendario.Name = "txtIdCalendario";
            this.txtIdCalendario.Size = new System.Drawing.Size(165, 20);
            this.txtIdCalendario.TabIndex = 23;
            // 
            // lblIdCalendario
            // 
            this.lblIdCalendario.AutoSize = true;
            this.lblIdCalendario.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCalendario.ForeColor = System.Drawing.Color.White;
            this.lblIdCalendario.Location = new System.Drawing.Point(12, 174);
            this.lblIdCalendario.Name = "lblIdCalendario";
            this.lblIdCalendario.Size = new System.Drawing.Size(336, 33);
            this.lblIdCalendario.TabIndex = 22;
            this.lblIdCalendario.Text = "ID de la fecha a registrar";
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.RosyBrown;
            this.panelSuperior.Controls.Add(this.lblTitulo);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1824, 58);
            this.panelSuperior.TabIndex = 21;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(620, 36);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Interfaz de registro Calendario de partidos";
            // 
            // frmRegistroCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1824, 873);
            this.Controls.Add(this.btnConsultaGeneral);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrarF);
            this.Controls.Add(this.dtgRegistroCalendario);
            this.Controls.Add(this.txtIdPartido);
            this.Controls.Add(this.lblIdPartido);
            this.Controls.Add(this.dtFechaCalendario);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtIdCalendario);
            this.Controls.Add(this.lblIdCalendario);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistroCalendario";
            this.Text = "frmRegistroCalendario";
            ((System.ComponentModel.ISupportInitialize)(this.dtgRegistroCalendario)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultaGeneral;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRegistrarF;
        private System.Windows.Forms.DataGridView dtgRegistroCalendario;
        private System.Windows.Forms.TextBox txtIdPartido;
        private System.Windows.Forms.Label lblIdPartido;
        private System.Windows.Forms.DateTimePicker dtFechaCalendario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtIdCalendario;
        private System.Windows.Forms.Label lblIdCalendario;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblTitulo;
    }
}