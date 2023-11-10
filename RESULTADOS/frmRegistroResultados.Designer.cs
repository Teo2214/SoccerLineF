namespace SoccerLineF
{
    partial class frmRegistroResultados
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
            this.dtgRegistroResultado = new System.Windows.Forms.DataGridView();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.btnConsultaGeneral = new System.Windows.Forms.Button();
            this.txtpartidoID = new System.Windows.Forms.TextBox();
            this.txteventoDestacado = new System.Windows.Forms.TextBox();
            this.lblpartidoID = new System.Windows.Forms.Label();
            this.lbleventoDestacado = new System.Windows.Forms.Label();
            this.txtmarcadorVisitante = new System.Windows.Forms.TextBox();
            this.lblmarcadorLocal = new System.Windows.Forms.Label();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.txtmarcadorLocal = new System.Windows.Forms.TextBox();
            this.lblmarcadorVisitante = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRegistroResultado)).BeginInit();
            this.panelSuperior.SuspendLayout();
            this.panelLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgRegistroResultado
            // 
            this.dtgRegistroResultado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dtgRegistroResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgRegistroResultado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgRegistroResultado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgRegistroResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRegistroResultado.EnableHeadersVisualStyles = false;
            this.dtgRegistroResultado.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgRegistroResultado.Location = new System.Drawing.Point(831, 182);
            this.dtgRegistroResultado.Name = "dtgRegistroResultado";
            this.dtgRegistroResultado.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dtgRegistroResultado.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgRegistroResultado.Size = new System.Drawing.Size(853, 488);
            this.dtgRegistroResultado.TabIndex = 12;
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
            this.lblTitulo.Size = new System.Drawing.Size(419, 36);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Interfaz registro de resultado";
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelLateral.Controls.Add(this.btnConsultaGeneral);
            this.panelLateral.Controls.Add(this.txtpartidoID);
            this.panelLateral.Controls.Add(this.txteventoDestacado);
            this.panelLateral.Controls.Add(this.lblpartidoID);
            this.panelLateral.Controls.Add(this.lbleventoDestacado);
            this.panelLateral.Controls.Add(this.txtmarcadorVisitante);
            this.panelLateral.Controls.Add(this.lblmarcadorLocal);
            this.panelLateral.Controls.Add(this.btnregistrar);
            this.panelLateral.Controls.Add(this.btneliminar);
            this.panelLateral.Controls.Add(this.txtmarcadorLocal);
            this.panelLateral.Controls.Add(this.lblmarcadorVisitante);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(632, 873);
            this.panelLateral.TabIndex = 10;
            // 
            // btnConsultaGeneral
            // 
            this.btnConsultaGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnConsultaGeneral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaGeneral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnConsultaGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaGeneral.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaGeneral.ForeColor = System.Drawing.Color.White;
            this.btnConsultaGeneral.Location = new System.Drawing.Point(192, 614);
            this.btnConsultaGeneral.Name = "btnConsultaGeneral";
            this.btnConsultaGeneral.Size = new System.Drawing.Size(194, 32);
            this.btnConsultaGeneral.TabIndex = 20;
            this.btnConsultaGeneral.Text = "CONSULTAR";
            this.btnConsultaGeneral.UseVisualStyleBackColor = false;
            this.btnConsultaGeneral.Click += new System.EventHandler(this.btnConsultaGeneral_Click);
            // 
            // txtpartidoID
            // 
            this.txtpartidoID.Location = new System.Drawing.Point(341, 370);
            this.txtpartidoID.Name = "txtpartidoID";
            this.txtpartidoID.Size = new System.Drawing.Size(221, 20);
            this.txtpartidoID.TabIndex = 19;
            // 
            // txteventoDestacado
            // 
            this.txteventoDestacado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txteventoDestacado.Location = new System.Drawing.Point(38, 370);
            this.txteventoDestacado.Name = "txteventoDestacado";
            this.txteventoDestacado.Size = new System.Drawing.Size(221, 20);
            this.txteventoDestacado.TabIndex = 18;
            // 
            // lblpartidoID
            // 
            this.lblpartidoID.AutoSize = true;
            this.lblpartidoID.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpartidoID.ForeColor = System.Drawing.Color.White;
            this.lblpartidoID.Location = new System.Drawing.Point(336, 291);
            this.lblpartidoID.Name = "lblpartidoID";
            this.lblpartidoID.Size = new System.Drawing.Size(143, 33);
            this.lblpartidoID.TabIndex = 17;
            this.lblpartidoID.Text = "Partido ID";
            // 
            // lbleventoDestacado
            // 
            this.lbleventoDestacado.AutoSize = true;
            this.lbleventoDestacado.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleventoDestacado.ForeColor = System.Drawing.Color.White;
            this.lbleventoDestacado.Location = new System.Drawing.Point(33, 291);
            this.lbleventoDestacado.Name = "lbleventoDestacado";
            this.lbleventoDestacado.Size = new System.Drawing.Size(263, 33);
            this.lbleventoDestacado.TabIndex = 16;
            this.lbleventoDestacado.Text = "Evento Destacado";
            // 
            // txtmarcadorVisitante
            // 
            this.txtmarcadorVisitante.Location = new System.Drawing.Point(341, 182);
            this.txtmarcadorVisitante.Name = "txtmarcadorVisitante";
            this.txtmarcadorVisitante.Size = new System.Drawing.Size(221, 20);
            this.txtmarcadorVisitante.TabIndex = 15;
            // 
            // lblmarcadorLocal
            // 
            this.lblmarcadorLocal.AutoSize = true;
            this.lblmarcadorLocal.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmarcadorLocal.ForeColor = System.Drawing.Color.White;
            this.lblmarcadorLocal.Location = new System.Drawing.Point(49, 110);
            this.lblmarcadorLocal.Name = "lblmarcadorLocal";
            this.lblmarcadorLocal.Size = new System.Drawing.Size(224, 33);
            this.lblmarcadorLocal.TabIndex = 14;
            this.lblmarcadorLocal.Text = "Marcador Local";
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnregistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregistrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar.ForeColor = System.Drawing.Color.White;
            this.btnregistrar.Location = new System.Drawing.Point(38, 512);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(194, 32);
            this.btnregistrar.TabIndex = 12;
            this.btnregistrar.Text = "REGISTRAR";
            this.btnregistrar.UseVisualStyleBackColor = false;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.Location = new System.Drawing.Point(341, 512);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(194, 32);
            this.btneliminar.TabIndex = 11;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // txtmarcadorLocal
            // 
            this.txtmarcadorLocal.Location = new System.Drawing.Point(38, 182);
            this.txtmarcadorLocal.Name = "txtmarcadorLocal";
            this.txtmarcadorLocal.Size = new System.Drawing.Size(221, 20);
            this.txtmarcadorLocal.TabIndex = 4;
            // 
            // lblmarcadorVisitante
            // 
            this.lblmarcadorVisitante.AutoSize = true;
            this.lblmarcadorVisitante.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmarcadorVisitante.ForeColor = System.Drawing.Color.White;
            this.lblmarcadorVisitante.Location = new System.Drawing.Point(327, 110);
            this.lblmarcadorVisitante.Name = "lblmarcadorVisitante";
            this.lblmarcadorVisitante.Size = new System.Drawing.Size(266, 33);
            this.lblmarcadorVisitante.TabIndex = 3;
            this.lblmarcadorVisitante.Text = "Marcador Visitante";
            // 
            // frmRegistroResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1824, 873);
            this.Controls.Add(this.dtgRegistroResultado);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistroResultados";
            this.Text = "frmRegistroResultados";
            this.Load += new System.EventHandler(this.frmRegistroResultados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRegistroResultado)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgRegistroResultado;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.TextBox txtpartidoID;
        private System.Windows.Forms.TextBox txteventoDestacado;
        private System.Windows.Forms.Label lblpartidoID;
        private System.Windows.Forms.Label lbleventoDestacado;
        private System.Windows.Forms.TextBox txtmarcadorVisitante;
        private System.Windows.Forms.Label lblmarcadorLocal;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.TextBox txtmarcadorLocal;
        private System.Windows.Forms.Label lblmarcadorVisitante;
        private System.Windows.Forms.Button btnConsultaGeneral;
    }
}