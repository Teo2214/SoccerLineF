namespace SoccerLineF
{
    partial class frmConsultaPartido
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
            this.dtgConsultaPartidos = new System.Windows.Forms.DataGridView();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.lblConPartidos = new System.Windows.Forms.Label();
            this.btnConsultaEspecifica = new System.Windows.Forms.Button();
            this.btnConsultaGeneral = new System.Windows.Forms.Button();
            this.txtIdPartido = new System.Windows.Forms.TextBox();
            this.lblIdPartido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaPartidos)).BeginInit();
            this.panelSuperior.SuspendLayout();
            this.panelLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgConsultaPartidos
            // 
            this.dtgConsultaPartidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dtgConsultaPartidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgConsultaPartidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgConsultaPartidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgConsultaPartidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultaPartidos.EnableHeadersVisualStyles = false;
            this.dtgConsultaPartidos.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgConsultaPartidos.Location = new System.Drawing.Point(824, 152);
            this.dtgConsultaPartidos.Name = "dtgConsultaPartidos";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dtgConsultaPartidos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgConsultaPartidos.Size = new System.Drawing.Size(816, 561);
            this.dtgConsultaPartidos.TabIndex = 12;
            this.dtgConsultaPartidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgConsultaPartidos_CellContentClick);
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.RosyBrown;
            this.panelSuperior.Controls.Add(this.lblTitulo);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(632, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1192, 58);
            this.panelSuperior.TabIndex = 11;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(467, 36);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Interfaz de consulta de partidos";
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelLateral.Controls.Add(this.lblConPartidos);
            this.panelLateral.Controls.Add(this.btnConsultaEspecifica);
            this.panelLateral.Controls.Add(this.btnConsultaGeneral);
            this.panelLateral.Controls.Add(this.txtIdPartido);
            this.panelLateral.Controls.Add(this.lblIdPartido);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(632, 873);
            this.panelLateral.TabIndex = 10;
            // 
            // lblConPartidos
            // 
            this.lblConPartidos.AutoSize = true;
            this.lblConPartidos.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConPartidos.ForeColor = System.Drawing.Color.White;
            this.lblConPartidos.Location = new System.Drawing.Point(23, 211);
            this.lblConPartidos.Name = "lblConPartidos";
            this.lblConPartidos.Size = new System.Drawing.Size(511, 33);
            this.lblConPartidos.TabIndex = 14;
            this.lblConPartidos.Text = "Consulta todos los partidos existentes ";
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
            // txtIdPartido
            // 
            this.txtIdPartido.Location = new System.Drawing.Point(29, 472);
            this.txtIdPartido.Name = "txtIdPartido";
            this.txtIdPartido.Size = new System.Drawing.Size(314, 20);
            this.txtIdPartido.TabIndex = 4;
            // 
            // lblIdPartido
            // 
            this.lblIdPartido.AutoSize = true;
            this.lblIdPartido.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPartido.ForeColor = System.Drawing.Color.White;
            this.lblIdPartido.Location = new System.Drawing.Point(23, 425);
            this.lblIdPartido.Name = "lblIdPartido";
            this.lblIdPartido.Size = new System.Drawing.Size(541, 33);
            this.lblIdPartido.TabIndex = 3;
            this.lblIdPartido.Text = "Consulta un partido especifico con su ID";
            // 
            // frmConsultaPartido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1824, 873);
            this.Controls.Add(this.dtgConsultaPartidos);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaPartido";
            this.Text = "frmConsultaPartido";
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaPartidos)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgConsultaPartidos;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Label lblConPartidos;
        private System.Windows.Forms.Button btnConsultaEspecifica;
        private System.Windows.Forms.Button btnConsultaGeneral;
        private System.Windows.Forms.TextBox txtIdPartido;
        private System.Windows.Forms.Label lblIdPartido;
    }
}