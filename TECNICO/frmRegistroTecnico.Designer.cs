namespace SoccerLineF
{
    partial class frmRegistroTecnico
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
            this.dtgRegistroTecnicos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.btnConsultaGeneral = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegistrarT = new System.Windows.Forms.Button();
            this.txtExpediente = new System.Windows.Forms.TextBox();
            this.lblExpediente = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellidoT = new System.Windows.Forms.Label();
            this.txtNombreTecnico = new System.Windows.Forms.TextBox();
            this.lblNombreTecnico = new System.Windows.Forms.Label();
            this.txtIdTecnico = new System.Windows.Forms.TextBox();
            this.lblIdTecnico = new System.Windows.Forms.Label();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRegistroTecnicos)).BeginInit();
            this.panelLateral.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgRegistroTecnicos
            // 
            this.dtgRegistroTecnicos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dtgRegistroTecnicos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgRegistroTecnicos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgRegistroTecnicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgRegistroTecnicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRegistroTecnicos.EnableHeadersVisualStyles = false;
            this.dtgRegistroTecnicos.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgRegistroTecnicos.Location = new System.Drawing.Point(888, 247);
            this.dtgRegistroTecnicos.Name = "dtgRegistroTecnicos";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dtgRegistroTecnicos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgRegistroTecnicos.Size = new System.Drawing.Size(710, 518);
            this.dtgRegistroTecnicos.TabIndex = 9;
            this.dtgRegistroTecnicos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgRegistroTecnicos_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(940, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Estos son los equipos registrados hasta el momento:";
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelLateral.Controls.Add(this.btnConsultaGeneral);
            this.panelLateral.Controls.Add(this.btnEliminar);
            this.panelLateral.Controls.Add(this.btnModificar);
            this.panelLateral.Controls.Add(this.btnRegistrarT);
            this.panelLateral.Controls.Add(this.txtExpediente);
            this.panelLateral.Controls.Add(this.lblExpediente);
            this.panelLateral.Controls.Add(this.txtApellido);
            this.panelLateral.Controls.Add(this.lblApellidoT);
            this.panelLateral.Controls.Add(this.txtNombreTecnico);
            this.panelLateral.Controls.Add(this.lblNombreTecnico);
            this.panelLateral.Controls.Add(this.txtIdTecnico);
            this.panelLateral.Controls.Add(this.lblIdTecnico);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 58);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(632, 815);
            this.panelLateral.TabIndex = 7;
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
            this.btnConsultaGeneral.Text = "CONSULTAR TECNICOS EXISTENTES";
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
            this.btnEliminar.Location = new System.Drawing.Point(413, 498);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(194, 32);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "ELIMINAR TECNICO";
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
            // btnRegistrarT
            // 
            this.btnRegistrarT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnRegistrarT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnRegistrarT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarT.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarT.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarT.Location = new System.Drawing.Point(12, 498);
            this.btnRegistrarT.Name = "btnRegistrarT";
            this.btnRegistrarT.Size = new System.Drawing.Size(194, 32);
            this.btnRegistrarT.TabIndex = 11;
            this.btnRegistrarT.Text = "REGISTRAR TECNICO";
            this.btnRegistrarT.UseVisualStyleBackColor = false;
            this.btnRegistrarT.Click += new System.EventHandler(this.btnRegistrarT_Click);
            // 
            // txtExpediente
            // 
            this.txtExpediente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtExpediente.Location = new System.Drawing.Point(29, 342);
            this.txtExpediente.Name = "txtExpediente";
            this.txtExpediente.Size = new System.Drawing.Size(314, 20);
            this.txtExpediente.TabIndex = 10;
            // 
            // lblExpediente
            // 
            this.lblExpediente.AutoSize = true;
            this.lblExpediente.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpediente.ForeColor = System.Drawing.Color.White;
            this.lblExpediente.Location = new System.Drawing.Point(23, 306);
            this.lblExpediente.Name = "lblExpediente";
            this.lblExpediente.Size = new System.Drawing.Size(421, 33);
            this.lblExpediente.TabIndex = 9;
            this.lblExpediente.Text = "Expediente(maximo 200 letras)";
            // 
            // txtApellido
            // 
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido.Location = new System.Drawing.Point(29, 270);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(314, 20);
            this.txtApellido.TabIndex = 8;
            // 
            // lblApellidoT
            // 
            this.lblApellidoT.AutoSize = true;
            this.lblApellidoT.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoT.ForeColor = System.Drawing.Color.White;
            this.lblApellidoT.Location = new System.Drawing.Point(23, 234);
            this.lblApellidoT.Name = "lblApellidoT";
            this.lblApellidoT.Size = new System.Drawing.Size(125, 33);
            this.lblApellidoT.TabIndex = 7;
            this.lblApellidoT.Text = "Apellido";
            // 
            // txtNombreTecnico
            // 
            this.txtNombreTecnico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreTecnico.Location = new System.Drawing.Point(29, 189);
            this.txtNombreTecnico.Name = "txtNombreTecnico";
            this.txtNombreTecnico.Size = new System.Drawing.Size(314, 20);
            this.txtNombreTecnico.TabIndex = 6;
            // 
            // lblNombreTecnico
            // 
            this.lblNombreTecnico.AutoSize = true;
            this.lblNombreTecnico.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTecnico.ForeColor = System.Drawing.Color.White;
            this.lblNombreTecnico.Location = new System.Drawing.Point(23, 153);
            this.lblNombreTecnico.Name = "lblNombreTecnico";
            this.lblNombreTecnico.Size = new System.Drawing.Size(123, 33);
            this.lblNombreTecnico.TabIndex = 5;
            this.lblNombreTecnico.Text = "Nombre";
            // 
            // txtIdTecnico
            // 
            this.txtIdTecnico.Location = new System.Drawing.Point(29, 106);
            this.txtIdTecnico.Name = "txtIdTecnico";
            this.txtIdTecnico.Size = new System.Drawing.Size(314, 20);
            this.txtIdTecnico.TabIndex = 4;
            // 
            // lblIdTecnico
            // 
            this.lblIdTecnico.AutoSize = true;
            this.lblIdTecnico.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdTecnico.ForeColor = System.Drawing.Color.White;
            this.lblIdTecnico.Location = new System.Drawing.Point(23, 70);
            this.lblIdTecnico.Name = "lblIdTecnico";
            this.lblIdTecnico.Size = new System.Drawing.Size(200, 33);
            this.lblIdTecnico.TabIndex = 3;
            this.lblIdTecnico.Text = "ID del tecnico";
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.RosyBrown;
            this.panelSuperior.Controls.Add(this.lblTitulo);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1824, 58);
            this.panelSuperior.TabIndex = 6;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(456, 36);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Interfaz de registro de tecnicos";
            // 
            // frmRegistroTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1824, 873);
            this.Controls.Add(this.dtgRegistroTecnicos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistroTecnico";
            this.Text = "frmRegistroTecnico";
            ((System.ComponentModel.ISupportInitialize)(this.dtgRegistroTecnicos)).EndInit();
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgRegistroTecnicos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Button btnConsultaGeneral;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRegistrarT;
        private System.Windows.Forms.TextBox txtExpediente;
        private System.Windows.Forms.Label lblExpediente;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellidoT;
        private System.Windows.Forms.TextBox txtNombreTecnico;
        private System.Windows.Forms.Label lblNombreTecnico;
        private System.Windows.Forms.TextBox txtIdTecnico;
        private System.Windows.Forms.Label lblIdTecnico;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblTitulo;
    }
}