namespace SoccerLineF
{
    partial class frmEquiposConsulta
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultaEspecifica = new System.Windows.Forms.Button();
            this.btnConsultaGeneral = new System.Windows.Forms.Button();
            this.txtIdEquipo = new System.Windows.Forms.TextBox();
            this.lblIdEquipo = new System.Windows.Forms.Label();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dtgConsultaEquipos = new System.Windows.Forms.DataGridView();
            this.panelLateral.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelLateral.Controls.Add(this.label1);
            this.panelLateral.Controls.Add(this.btnConsultaEspecifica);
            this.panelLateral.Controls.Add(this.btnConsultaGeneral);
            this.panelLateral.Controls.Add(this.txtIdEquipo);
            this.panelLateral.Controls.Add(this.lblIdEquipo);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(632, 873);
            this.panelLateral.TabIndex = 3;
            this.panelLateral.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLateral_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 33);
            this.label1.TabIndex = 14;
            this.label1.Text = "Consulta todos los equipos existentes ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnConsultaEspecifica
            // 
            this.btnConsultaEspecifica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnConsultaEspecifica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaEspecifica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnConsultaEspecifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaEspecifica.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaEspecifica.ForeColor = System.Drawing.Color.White;
            this.btnConsultaEspecifica.Location = new System.Drawing.Point(29, 512);
            this.btnConsultaEspecifica.Name = "btnConsultaEspecifica";
            this.btnConsultaEspecifica.Size = new System.Drawing.Size(194, 32);
            this.btnConsultaEspecifica.TabIndex = 12;
            this.btnConsultaEspecifica.Text = "CONSULTAR";
            this.btnConsultaEspecifica.UseVisualStyleBackColor = false;
            this.btnConsultaEspecifica.Click += new System.EventHandler(this.btnConsultaEspecifica_Click);
            // 
            // btnConsultaGeneral
            // 
            this.btnConsultaGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnConsultaGeneral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaGeneral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnConsultaGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaGeneral.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaGeneral.ForeColor = System.Drawing.Color.White;
            this.btnConsultaGeneral.Location = new System.Drawing.Point(29, 261);
            this.btnConsultaGeneral.Name = "btnConsultaGeneral";
            this.btnConsultaGeneral.Size = new System.Drawing.Size(194, 32);
            this.btnConsultaGeneral.TabIndex = 11;
            this.btnConsultaGeneral.Text = "CONSULTAR";
            this.btnConsultaGeneral.UseVisualStyleBackColor = false;
            this.btnConsultaGeneral.Click += new System.EventHandler(this.btnConsultaGeneral_Click);
            // 
            // txtIdEquipo
            // 
            this.txtIdEquipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdEquipo.Location = new System.Drawing.Point(29, 472);
            this.txtIdEquipo.Name = "txtIdEquipo";
            this.txtIdEquipo.Size = new System.Drawing.Size(314, 20);
            this.txtIdEquipo.TabIndex = 4;
            // 
            // lblIdEquipo
            // 
            this.lblIdEquipo.AutoSize = true;
            this.lblIdEquipo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEquipo.ForeColor = System.Drawing.Color.White;
            this.lblIdEquipo.Location = new System.Drawing.Point(23, 425);
            this.lblIdEquipo.Name = "lblIdEquipo";
            this.lblIdEquipo.Size = new System.Drawing.Size(538, 33);
            this.lblIdEquipo.TabIndex = 3;
            this.lblIdEquipo.Text = "Consulta un equipo especifico con su ID";
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.RosyBrown;
            this.panelSuperior.Controls.Add(this.lblTitulo);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(632, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1192, 58);
            this.panelSuperior.TabIndex = 4;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(465, 36);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Interfaz de consulta de equipos";
            // 
            // dtgConsultaEquipos
            // 
            this.dtgConsultaEquipos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dtgConsultaEquipos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgConsultaEquipos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgConsultaEquipos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgConsultaEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultaEquipos.EnableHeadersVisualStyles = false;
            this.dtgConsultaEquipos.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgConsultaEquipos.Location = new System.Drawing.Point(894, 211);
            this.dtgConsultaEquipos.Name = "dtgConsultaEquipos";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dtgConsultaEquipos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgConsultaEquipos.Size = new System.Drawing.Size(777, 473);
            this.dtgConsultaEquipos.TabIndex = 6;
            // 
            // frmEquiposConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1824, 873);
            this.Controls.Add(this.dtgConsultaEquipos);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEquiposConsulta";
            this.Text = "frmEquiposAfiicion";
            this.Load += new System.EventHandler(this.frmEquiposConsulta_Load);
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaEquipos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Button btnConsultaEspecifica;
        private System.Windows.Forms.Button btnConsultaGeneral;
        private System.Windows.Forms.TextBox txtIdEquipo;
        private System.Windows.Forms.Label lblIdEquipo;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgConsultaEquipos;
    }
}