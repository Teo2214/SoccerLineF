namespace SoccerLineF
{
    partial class frmConsultaFecha
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
            this.lblConsultaF = new System.Windows.Forms.Label();
            this.btnConsultaGeneral = new System.Windows.Forms.Button();
            this.dtFechaCalendario = new System.Windows.Forms.DateTimePicker();
            this.btnConsultaEspecifica = new System.Windows.Forms.Button();
            this.lblConsultaPorF = new System.Windows.Forms.Label();
            this.dtgConsultaFechas = new System.Windows.Forms.DataGridView();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaFechas)).BeginInit();
            this.panelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblConsultaF
            // 
            this.lblConsultaF.AutoSize = true;
            this.lblConsultaF.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaF.ForeColor = System.Drawing.Color.White;
            this.lblConsultaF.Location = new System.Drawing.Point(58, 190);
            this.lblConsultaF.Name = "lblConsultaF";
            this.lblConsultaF.Size = new System.Drawing.Size(491, 33);
            this.lblConsultaF.TabIndex = 16;
            this.lblConsultaF.Text = "Consulta todos las fechas existentes ";
            // 
            // btnConsultaGeneral
            // 
            this.btnConsultaGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnConsultaGeneral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaGeneral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnConsultaGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaGeneral.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaGeneral.ForeColor = System.Drawing.Color.White;
            this.btnConsultaGeneral.Location = new System.Drawing.Point(64, 240);
            this.btnConsultaGeneral.Name = "btnConsultaGeneral";
            this.btnConsultaGeneral.Size = new System.Drawing.Size(194, 32);
            this.btnConsultaGeneral.TabIndex = 15;
            this.btnConsultaGeneral.Text = "CONSULTAR";
            this.btnConsultaGeneral.UseVisualStyleBackColor = false;
            this.btnConsultaGeneral.Click += new System.EventHandler(this.btnConsultaGeneral_Click);
            // 
            // dtFechaCalendario
            // 
            this.dtFechaCalendario.Location = new System.Drawing.Point(64, 529);
            this.dtFechaCalendario.Name = "dtFechaCalendario";
            this.dtFechaCalendario.Size = new System.Drawing.Size(406, 20);
            this.dtFechaCalendario.TabIndex = 26;
            // 
            // btnConsultaEspecifica
            // 
            this.btnConsultaEspecifica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnConsultaEspecifica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaEspecifica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnConsultaEspecifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaEspecifica.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaEspecifica.ForeColor = System.Drawing.Color.White;
            this.btnConsultaEspecifica.Location = new System.Drawing.Point(64, 567);
            this.btnConsultaEspecifica.Name = "btnConsultaEspecifica";
            this.btnConsultaEspecifica.Size = new System.Drawing.Size(194, 32);
            this.btnConsultaEspecifica.TabIndex = 27;
            this.btnConsultaEspecifica.Text = "CONSULTAR";
            this.btnConsultaEspecifica.UseVisualStyleBackColor = false;
            this.btnConsultaEspecifica.Click += new System.EventHandler(this.btnConsultaEspecifica_Click);
            // 
            // lblConsultaPorF
            // 
            this.lblConsultaPorF.AutoSize = true;
            this.lblConsultaPorF.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaPorF.ForeColor = System.Drawing.Color.White;
            this.lblConsultaPorF.Location = new System.Drawing.Point(58, 477);
            this.lblConsultaPorF.Name = "lblConsultaPorF";
            this.lblConsultaPorF.Size = new System.Drawing.Size(273, 33);
            this.lblConsultaPorF.TabIndex = 28;
            this.lblConsultaPorF.Text = "Consulta por fecha ";
            // 
            // dtgConsultaFechas
            // 
            this.dtgConsultaFechas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dtgConsultaFechas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgConsultaFechas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgConsultaFechas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgConsultaFechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultaFechas.EnableHeadersVisualStyles = false;
            this.dtgConsultaFechas.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgConsultaFechas.Location = new System.Drawing.Point(887, 190);
            this.dtgConsultaFechas.Name = "dtgConsultaFechas";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dtgConsultaFechas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgConsultaFechas.Size = new System.Drawing.Size(777, 473);
            this.dtgConsultaFechas.TabIndex = 29;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.RosyBrown;
            this.panelSuperior.Controls.Add(this.lblTitulo);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1824, 58);
            this.panelSuperior.TabIndex = 30;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(447, 36);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Interfaz de consulta de fechas";
            // 
            // frmConsultaFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1824, 873);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.dtgConsultaFechas);
            this.Controls.Add(this.lblConsultaPorF);
            this.Controls.Add(this.btnConsultaEspecifica);
            this.Controls.Add(this.dtFechaCalendario);
            this.Controls.Add(this.lblConsultaF);
            this.Controls.Add(this.btnConsultaGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaFecha";
            this.Text = "frmConsultaFecha";
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaFechas)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsultaF;
        private System.Windows.Forms.Button btnConsultaGeneral;
        private System.Windows.Forms.DateTimePicker dtFechaCalendario;
        private System.Windows.Forms.Button btnConsultaEspecifica;
        private System.Windows.Forms.Label lblConsultaPorF;
        private System.Windows.Forms.DataGridView dtgConsultaFechas;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblTitulo;
    }
}