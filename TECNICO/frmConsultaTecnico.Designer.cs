namespace SoccerLineF
{
    partial class frmConsultaTecnico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgConsultaTecnicos = new System.Windows.Forms.DataGridView();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.lblConsultaT = new System.Windows.Forms.Label();
            this.btnConsultaEspecifica = new System.Windows.Forms.Button();
            this.btnConsultaGeneral = new System.Windows.Forms.Button();
            this.txtIdTecnico = new System.Windows.Forms.TextBox();
            this.lblIdTecnico = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaTecnicos)).BeginInit();
            this.panelSuperior.SuspendLayout();
            this.panelLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgConsultaTecnicos
            // 
            this.dtgConsultaTecnicos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dtgConsultaTecnicos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgConsultaTecnicos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgConsultaTecnicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgConsultaTecnicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultaTecnicos.EnableHeadersVisualStyles = false;
            this.dtgConsultaTecnicos.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgConsultaTecnicos.Location = new System.Drawing.Point(894, 211);
            this.dtgConsultaTecnicos.Name = "dtgConsultaTecnicos";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dtgConsultaTecnicos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgConsultaTecnicos.Size = new System.Drawing.Size(777, 473);
            this.dtgConsultaTecnicos.TabIndex = 9;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.RosyBrown;
            this.panelSuperior.Controls.Add(this.lblTitulo);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(632, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1192, 58);
            this.panelSuperior.TabIndex = 8;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(473, 36);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Interfaz de consulta de tecnicos";
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelLateral.Controls.Add(this.lblConsultaT);
            this.panelLateral.Controls.Add(this.btnConsultaEspecifica);
            this.panelLateral.Controls.Add(this.btnConsultaGeneral);
            this.panelLateral.Controls.Add(this.txtIdTecnico);
            this.panelLateral.Controls.Add(this.lblIdTecnico);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(632, 873);
            this.panelLateral.TabIndex = 7;
            // 
            // lblConsultaT
            // 
            this.lblConsultaT.AutoSize = true;
            this.lblConsultaT.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaT.ForeColor = System.Drawing.Color.White;
            this.lblConsultaT.Location = new System.Drawing.Point(23, 211);
            this.lblConsultaT.Name = "lblConsultaT";
            this.lblConsultaT.Size = new System.Drawing.Size(508, 33);
            this.lblConsultaT.TabIndex = 14;
            this.lblConsultaT.Text = "Consulta todos los equipos existentes ";
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
            // txtIdTecnico
            // 
            this.txtIdTecnico.Location = new System.Drawing.Point(29, 472);
            this.txtIdTecnico.Name = "txtIdTecnico";
            this.txtIdTecnico.Size = new System.Drawing.Size(314, 20);
            this.txtIdTecnico.TabIndex = 4;
            // 
            // lblIdTecnico
            // 
            this.lblIdTecnico.AutoSize = true;
            this.lblIdTecnico.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdTecnico.ForeColor = System.Drawing.Color.White;
            this.lblIdTecnico.Location = new System.Drawing.Point(23, 425);
            this.lblIdTecnico.Name = "lblIdTecnico";
            this.lblIdTecnico.Size = new System.Drawing.Size(538, 33);
            this.lblIdTecnico.TabIndex = 3;
            this.lblIdTecnico.Text = "Consulta un equipo especifico con su ID";
            // 
            // frmConsultaTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1824, 873);
            this.Controls.Add(this.dtgConsultaTecnicos);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaTecnico";
            this.Text = "frmConsultaTecnico";
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaTecnicos)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgConsultaTecnicos;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Label lblConsultaT;
        private System.Windows.Forms.Button btnConsultaEspecifica;
        private System.Windows.Forms.Button btnConsultaGeneral;
        private System.Windows.Forms.TextBox txtIdTecnico;
        private System.Windows.Forms.Label lblIdTecnico;
    }
}