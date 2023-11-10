namespace SoccerLineF
{
    partial class frmConsultaEstadistica
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
            this.lblConsultaEJ = new System.Windows.Forms.Label();
            this.dtgConsultarEstadisticaJugador = new System.Windows.Forms.DataGridView();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.btnConsultaGneral = new System.Windows.Forms.Button();
            this.btnConsultaEspecifica = new System.Windows.Forms.Button();
            this.txtconsultarID = new System.Windows.Forms.TextBox();
            this.lblconsultarEstadisticasE = new System.Windows.Forms.Label();
            this.lblConsultarEstadisticasID = new System.Windows.Forms.Label();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultarEstadisticaJugador)).BeginInit();
            this.panelLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.RosyBrown;
            this.panelSuperior.Controls.Add(this.lblConsultaEJ);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(632, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1192, 58);
            this.panelSuperior.TabIndex = 21;
            // 
            // lblConsultaEJ
            // 
            this.lblConsultaEJ.AutoSize = true;
            this.lblConsultaEJ.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaEJ.ForeColor = System.Drawing.Color.White;
            this.lblConsultaEJ.Location = new System.Drawing.Point(12, 9);
            this.lblConsultaEJ.Name = "lblConsultaEJ";
            this.lblConsultaEJ.Size = new System.Drawing.Size(541, 36);
            this.lblConsultaEJ.TabIndex = 4;
            this.lblConsultaEJ.Text = "Interfaz Consulta Estadistica Jugador";
            // 
            // dtgConsultarEstadisticaJugador
            // 
            this.dtgConsultarEstadisticaJugador.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dtgConsultarEstadisticaJugador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgConsultarEstadisticaJugador.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgConsultarEstadisticaJugador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgConsultarEstadisticaJugador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultarEstadisticaJugador.EnableHeadersVisualStyles = false;
            this.dtgConsultarEstadisticaJugador.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgConsultarEstadisticaJugador.Location = new System.Drawing.Point(983, 222);
            this.dtgConsultarEstadisticaJugador.Name = "dtgConsultarEstadisticaJugador";
            this.dtgConsultarEstadisticaJugador.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dtgConsultarEstadisticaJugador.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgConsultarEstadisticaJugador.Size = new System.Drawing.Size(549, 391);
            this.dtgConsultarEstadisticaJugador.TabIndex = 20;
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelLateral.Controls.Add(this.btnConsultaGneral);
            this.panelLateral.Controls.Add(this.btnConsultaEspecifica);
            this.panelLateral.Controls.Add(this.txtconsultarID);
            this.panelLateral.Controls.Add(this.lblconsultarEstadisticasE);
            this.panelLateral.Controls.Add(this.lblConsultarEstadisticasID);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(632, 873);
            this.panelLateral.TabIndex = 19;
            // 
            // btnConsultaGneral
            // 
            this.btnConsultaGneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnConsultaGneral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaGneral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnConsultaGneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaGneral.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaGneral.ForeColor = System.Drawing.Color.White;
            this.btnConsultaGneral.Location = new System.Drawing.Point(207, 288);
            this.btnConsultaGneral.Name = "btnConsultaGneral";
            this.btnConsultaGneral.Size = new System.Drawing.Size(194, 32);
            this.btnConsultaGneral.TabIndex = 15;
            this.btnConsultaGneral.Text = "CONSULTAR";
            this.btnConsultaGneral.UseVisualStyleBackColor = false;
            this.btnConsultaGneral.Click += new System.EventHandler(this.btnConsultaGneral_Click);
            // 
            // btnConsultaEspecifica
            // 
            this.btnConsultaEspecifica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnConsultaEspecifica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaEspecifica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnConsultaEspecifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaEspecifica.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaEspecifica.ForeColor = System.Drawing.Color.White;
            this.btnConsultaEspecifica.Location = new System.Drawing.Point(345, 628);
            this.btnConsultaEspecifica.Name = "btnConsultaEspecifica";
            this.btnConsultaEspecifica.Size = new System.Drawing.Size(194, 32);
            this.btnConsultaEspecifica.TabIndex = 14;
            this.btnConsultaEspecifica.Text = "CONSULTAR\r\n";
            this.btnConsultaEspecifica.UseVisualStyleBackColor = false;
            this.btnConsultaEspecifica.Click += new System.EventHandler(this.btnConsultaEspecifica_Click);
            // 
            // txtconsultarID
            // 
            this.txtconsultarID.Location = new System.Drawing.Point(40, 636);
            this.txtconsultarID.Name = "txtconsultarID";
            this.txtconsultarID.Size = new System.Drawing.Size(261, 20);
            this.txtconsultarID.TabIndex = 15;
            // 
            // lblconsultarEstadisticasE
            // 
            this.lblconsultarEstadisticasE.AutoSize = true;
            this.lblconsultarEstadisticasE.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconsultarEstadisticasE.ForeColor = System.Drawing.Color.White;
            this.lblconsultarEstadisticasE.Location = new System.Drawing.Point(43, 240);
            this.lblconsultarEstadisticasE.Name = "lblconsultarEstadisticasE";
            this.lblconsultarEstadisticasE.Size = new System.Drawing.Size(556, 33);
            this.lblconsultarEstadisticasE.TabIndex = 14;
            this.lblconsultarEstadisticasE.Text = "Consultar Todas Las Estadisticas Existentes";
            // 
            // lblConsultarEstadisticasID
            // 
            this.lblConsultarEstadisticasID.AutoSize = true;
            this.lblConsultarEstadisticasID.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultarEstadisticasID.ForeColor = System.Drawing.Color.White;
            this.lblConsultarEstadisticasID.Location = new System.Drawing.Point(12, 580);
            this.lblConsultarEstadisticasID.Name = "lblConsultarEstadisticasID";
            this.lblConsultarEstadisticasID.Size = new System.Drawing.Size(541, 33);
            this.lblConsultarEstadisticasID.TabIndex = 3;
            this.lblConsultarEstadisticasID.Text = "Consultar Estadistica Especifica segun ID";
            // 
            // frmConsultaEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1824, 873);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.dtgConsultarEstadisticaJugador);
            this.Controls.Add(this.panelLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaEstadistica";
            this.Text = "frmConsultaEstadistica";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultarEstadisticaJugador)).EndInit();
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblConsultaEJ;
        private System.Windows.Forms.DataGridView dtgConsultarEstadisticaJugador;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Button btnConsultaGneral;
        private System.Windows.Forms.Button btnConsultaEspecifica;
        private System.Windows.Forms.TextBox txtconsultarID;
        private System.Windows.Forms.Label lblconsultarEstadisticasE;
        private System.Windows.Forms.Label lblConsultarEstadisticasID;
    }
}