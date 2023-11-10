namespace SoccerLineF
{
    partial class frmRegistrarPartidos
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dtgRegistroPartidos = new System.Windows.Forms.DataGridView();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.btnConsultaGeneral = new System.Windows.Forms.Button();
            this.txtCapacidadLugar = new System.Windows.Forms.TextBox();
            this.lblCpacidadEstadio = new System.Windows.Forms.Label();
            this.btnEliminarP = new System.Windows.Forms.Button();
            this.btnModificarP = new System.Windows.Forms.Button();
            this.btnRegistrarP = new System.Windows.Forms.Button();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.lblEstadio = new System.Windows.Forms.Label();
            this.txtPartidoId = new System.Windows.Forms.TextBox();
            this.lblIdPartido = new System.Windows.Forms.Label();
            this.lblEquiLocal = new System.Windows.Forms.Label();
            this.txtEquipoLocal = new System.Windows.Forms.TextBox();
            this.txtEquipoVisitante = new System.Windows.Forms.TextBox();
            this.lblEquiVisitante = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRegistroPartidos)).BeginInit();
            this.panelInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(687, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(450, 36);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Interfaz de registro de partidos";
            // 
            // dtgRegistroPartidos
            // 
            this.dtgRegistroPartidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dtgRegistroPartidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgRegistroPartidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgRegistroPartidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgRegistroPartidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRegistroPartidos.EnableHeadersVisualStyles = false;
            this.dtgRegistroPartidos.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgRegistroPartidos.Location = new System.Drawing.Point(583, 75);
            this.dtgRegistroPartidos.Name = "dtgRegistroPartidos";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dtgRegistroPartidos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgRegistroPartidos.Size = new System.Drawing.Size(740, 507);
            this.dtgRegistroPartidos.TabIndex = 9;
            this.dtgRegistroPartidos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgRegistroPartidos_MouseClick);
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelInferior.Controls.Add(this.btnConsultaGeneral);
            this.panelInferior.Controls.Add(this.txtCapacidadLugar);
            this.panelInferior.Controls.Add(this.lblCpacidadEstadio);
            this.panelInferior.Controls.Add(this.btnEliminarP);
            this.panelInferior.Controls.Add(this.btnModificarP);
            this.panelInferior.Controls.Add(this.btnRegistrarP);
            this.panelInferior.Controls.Add(this.txtLugar);
            this.panelInferior.Controls.Add(this.lblEstadio);
            this.panelInferior.Controls.Add(this.txtPartidoId);
            this.panelInferior.Controls.Add(this.lblIdPartido);
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 693);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(1824, 180);
            this.panelInferior.TabIndex = 8;
            // 
            // btnConsultaGeneral
            // 
            this.btnConsultaGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnConsultaGeneral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaGeneral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnConsultaGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaGeneral.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaGeneral.ForeColor = System.Drawing.Color.White;
            this.btnConsultaGeneral.Location = new System.Drawing.Point(1605, 76);
            this.btnConsultaGeneral.Name = "btnConsultaGeneral";
            this.btnConsultaGeneral.Size = new System.Drawing.Size(194, 32);
            this.btnConsultaGeneral.TabIndex = 19;
            this.btnConsultaGeneral.Text = "CONSULTAR";
            this.btnConsultaGeneral.UseVisualStyleBackColor = false;
            this.btnConsultaGeneral.Click += new System.EventHandler(this.btnConsultaGeneral_Click);
            // 
            // txtCapacidadLugar
            // 
            this.txtCapacidadLugar.Location = new System.Drawing.Point(611, 144);
            this.txtCapacidadLugar.Name = "txtCapacidadLugar";
            this.txtCapacidadLugar.Size = new System.Drawing.Size(233, 20);
            this.txtCapacidadLugar.TabIndex = 18;
            // 
            // lblCpacidadEstadio
            // 
            this.lblCpacidadEstadio.AutoSize = true;
            this.lblCpacidadEstadio.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpacidadEstadio.ForeColor = System.Drawing.Color.White;
            this.lblCpacidadEstadio.Location = new System.Drawing.Point(577, 108);
            this.lblCpacidadEstadio.Name = "lblCpacidadEstadio";
            this.lblCpacidadEstadio.Size = new System.Drawing.Size(329, 33);
            this.lblCpacidadEstadio.TabIndex = 17;
            this.lblCpacidadEstadio.Text = "Capacidad del Estadio ";
            // 
            // btnEliminarP
            // 
            this.btnEliminarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEliminarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnEliminarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarP.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarP.ForeColor = System.Drawing.Color.White;
            this.btnEliminarP.Location = new System.Drawing.Point(1043, 136);
            this.btnEliminarP.Name = "btnEliminarP";
            this.btnEliminarP.Size = new System.Drawing.Size(194, 32);
            this.btnEliminarP.TabIndex = 16;
            this.btnEliminarP.Text = "ELIMINAR PARTIDO";
            this.btnEliminarP.UseVisualStyleBackColor = false;
            this.btnEliminarP.Click += new System.EventHandler(this.btnEliminarP_Click);
            // 
            // btnModificarP
            // 
            this.btnModificarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnModificarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnModificarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarP.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarP.ForeColor = System.Drawing.Color.White;
            this.btnModificarP.Location = new System.Drawing.Point(1043, 76);
            this.btnModificarP.Name = "btnModificarP";
            this.btnModificarP.Size = new System.Drawing.Size(194, 32);
            this.btnModificarP.TabIndex = 15;
            this.btnModificarP.Text = "MODIFICAR";
            this.btnModificarP.UseVisualStyleBackColor = false;
            this.btnModificarP.Click += new System.EventHandler(this.btnModificarP_Click);
            // 
            // btnRegistrarP
            // 
            this.btnRegistrarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnRegistrarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnRegistrarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarP.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarP.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarP.Location = new System.Drawing.Point(1043, 27);
            this.btnRegistrarP.Name = "btnRegistrarP";
            this.btnRegistrarP.Size = new System.Drawing.Size(194, 32);
            this.btnRegistrarP.TabIndex = 14;
            this.btnRegistrarP.Text = "REGISTRAR PARTIDO";
            this.btnRegistrarP.UseVisualStyleBackColor = false;
            this.btnRegistrarP.Click += new System.EventHandler(this.btnRegistrarP_Click);
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(611, 62);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(233, 20);
            this.txtLugar.TabIndex = 11;
            // 
            // lblEstadio
            // 
            this.lblEstadio.AutoSize = true;
            this.lblEstadio.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadio.ForeColor = System.Drawing.Color.White;
            this.lblEstadio.Location = new System.Drawing.Point(672, 26);
            this.lblEstadio.Name = "lblEstadio";
            this.lblEstadio.Size = new System.Drawing.Size(110, 33);
            this.lblEstadio.TabIndex = 10;
            this.lblEstadio.Text = "Estadio";
            // 
            // txtPartidoId
            // 
            this.txtPartidoId.Location = new System.Drawing.Point(32, 76);
            this.txtPartidoId.Name = "txtPartidoId";
            this.txtPartidoId.Size = new System.Drawing.Size(137, 20);
            this.txtPartidoId.TabIndex = 7;
            // 
            // lblIdPartido
            // 
            this.lblIdPartido.AutoSize = true;
            this.lblIdPartido.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPartido.ForeColor = System.Drawing.Color.White;
            this.lblIdPartido.Location = new System.Drawing.Point(26, 29);
            this.lblIdPartido.Name = "lblIdPartido";
            this.lblIdPartido.Size = new System.Drawing.Size(143, 33);
            this.lblIdPartido.TabIndex = 6;
            this.lblIdPartido.Text = "Partido ID";
            // 
            // lblEquiLocal
            // 
            this.lblEquiLocal.AutoSize = true;
            this.lblEquiLocal.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquiLocal.ForeColor = System.Drawing.Color.White;
            this.lblEquiLocal.Location = new System.Drawing.Point(1526, 185);
            this.lblEquiLocal.Name = "lblEquiLocal";
            this.lblEquiLocal.Size = new System.Drawing.Size(190, 33);
            this.lblEquiLocal.TabIndex = 11;
            this.lblEquiLocal.Text = "Equipo Local ";
            // 
            // txtEquipoLocal
            // 
            this.txtEquipoLocal.Location = new System.Drawing.Point(1490, 232);
            this.txtEquipoLocal.Name = "txtEquipoLocal";
            this.txtEquipoLocal.Size = new System.Drawing.Size(277, 20);
            this.txtEquipoLocal.TabIndex = 12;
            // 
            // txtEquipoVisitante
            // 
            this.txtEquipoVisitante.Location = new System.Drawing.Point(1490, 346);
            this.txtEquipoVisitante.Name = "txtEquipoVisitante";
            this.txtEquipoVisitante.Size = new System.Drawing.Size(277, 20);
            this.txtEquipoVisitante.TabIndex = 14;
            // 
            // lblEquiVisitante
            // 
            this.lblEquiVisitante.AutoSize = true;
            this.lblEquiVisitante.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquiVisitante.ForeColor = System.Drawing.Color.White;
            this.lblEquiVisitante.Location = new System.Drawing.Point(1526, 299);
            this.lblEquiVisitante.Name = "lblEquiVisitante";
            this.lblEquiVisitante.Size = new System.Drawing.Size(225, 33);
            this.lblEquiVisitante.TabIndex = 13;
            this.lblEquiVisitante.Text = "Equipo Visitante";
            // 
            // frmRegistrarPartidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1824, 873);
            this.Controls.Add(this.txtEquipoVisitante);
            this.Controls.Add(this.lblEquiVisitante);
            this.Controls.Add(this.txtEquipoLocal);
            this.Controls.Add(this.lblEquiLocal);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dtgRegistroPartidos);
            this.Controls.Add(this.panelInferior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistrarPartidos";
            this.Text = "frmRegistrarPartidos";
            this.Load += new System.EventHandler(this.frmRegistrarPartidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRegistroPartidos)).EndInit();
            this.panelInferior.ResumeLayout(false);
            this.panelInferior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dtgRegistroPartidos;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Button btnEliminarP;
        private System.Windows.Forms.Button btnModificarP;
        private System.Windows.Forms.Button btnRegistrarP;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label lblEstadio;
        private System.Windows.Forms.TextBox txtPartidoId;
        private System.Windows.Forms.Label lblIdPartido;
        private System.Windows.Forms.TextBox txtCapacidadLugar;
        private System.Windows.Forms.Label lblCpacidadEstadio;
        private System.Windows.Forms.Button btnConsultaGeneral;
        private System.Windows.Forms.Label lblEquiLocal;
        private System.Windows.Forms.TextBox txtEquipoLocal;
        private System.Windows.Forms.TextBox txtEquipoVisitante;
        private System.Windows.Forms.Label lblEquiVisitante;
    }
}