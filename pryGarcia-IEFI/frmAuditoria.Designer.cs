namespace pryGarcia_IEFI
{
    partial class frmAuditoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuditoria));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.gbxAuditorias = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkPorUsuario = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkPorFecha = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.dgvAuditoria = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbxAuditorias.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(61, 44);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(148, 21);
            this.txtUsuario.TabIndex = 3;
            // 
            // gbxAuditorias
            // 
            this.gbxAuditorias.BackColor = System.Drawing.Color.DarkGray;
            this.gbxAuditorias.Controls.Add(this.btnDescargar);
            this.gbxAuditorias.Controls.Add(this.btnVisualizar);
            this.gbxAuditorias.Controls.Add(this.dgvAuditoria);
            this.gbxAuditorias.Controls.Add(this.groupBox4);
            this.gbxAuditorias.Controls.Add(this.groupBox3);
            this.gbxAuditorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAuditorias.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxAuditorias.Location = new System.Drawing.Point(33, 11);
            this.gbxAuditorias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxAuditorias.Name = "gbxAuditorias";
            this.gbxAuditorias.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxAuditorias.Size = new System.Drawing.Size(649, 406);
            this.gbxAuditorias.TabIndex = 10;
            this.gbxAuditorias.TabStop = false;
            this.gbxAuditorias.Text = "AUDITORIAS";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkPorUsuario);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtUsuario);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(24, 30);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(219, 76);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            // 
            // chkPorUsuario
            // 
            this.chkPorUsuario.AutoSize = true;
            this.chkPorUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPorUsuario.Location = new System.Drawing.Point(6, 16);
            this.chkPorUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkPorUsuario.Name = "chkPorUsuario";
            this.chkPorUsuario.Size = new System.Drawing.Size(122, 19);
            this.chkPorUsuario.TabIndex = 17;
            this.chkPorUsuario.Text = "Filtrar por usuario";
            this.chkPorUsuario.UseVisualStyleBackColor = true;
            this.chkPorUsuario.CheckedChanged += new System.EventHandler(this.chkPorUsuario_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Usuario:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkPorFecha);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.dtpFechaDesde);
            this.groupBox3.Controls.Add(this.dtpFechaHasta);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(247, 30);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(377, 76);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // chkPorFecha
            // 
            this.chkPorFecha.AutoSize = true;
            this.chkPorFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPorFecha.Location = new System.Drawing.Point(16, 16);
            this.chkPorFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkPorFecha.Name = "chkPorFecha";
            this.chkPorFecha.Size = new System.Drawing.Size(111, 19);
            this.chkPorFecha.TabIndex = 16;
            this.chkPorFecha.Text = "Filtrar por fecha";
            this.chkPorFecha.UseVisualStyleBackColor = true;
            this.chkPorFecha.CheckedChanged += new System.EventHandler(this.chkPorFecha_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fecha Inicio del:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Checked = false;
            this.dtpFechaDesde.Enabled = false;
            this.dtpFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(121, 43);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpFechaDesde.Size = new System.Drawing.Size(101, 22);
            this.dtpFechaDesde.TabIndex = 12;
            this.dtpFechaDesde.Value = new System.DateTime(2025, 6, 2, 0, 0, 0, 0);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Enabled = false;
            this.dtpFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(263, 43);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(101, 22);
            this.dtpFechaHasta.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(239, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "al:";
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVisualizar.Location = new System.Drawing.Point(502, 118);
            this.btnVisualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(122, 28);
            this.btnVisualizar.TabIndex = 8;
            this.btnVisualizar.Text = "VISUALIZAR";
            this.btnVisualizar.UseVisualStyleBackColor = false;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnDescargar
            // 
            this.btnDescargar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDescargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDescargar.Location = new System.Drawing.Point(376, 118);
            this.btnDescargar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(122, 28);
            this.btnDescargar.TabIndex = 7;
            this.btnDescargar.Text = "Descargar";
            this.btnDescargar.UseVisualStyleBackColor = false;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // dgvAuditoria
            // 
            this.dgvAuditoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuditoria.Location = new System.Drawing.Point(24, 151);
            this.dgvAuditoria.Name = "dgvAuditoria";
            this.dgvAuditoria.RowHeadersWidth = 51;
            this.dgvAuditoria.Size = new System.Drawing.Size(600, 241);
            this.dgvAuditoria.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Location = new System.Drawing.Point(582, 422);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(715, 457);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbxAuditorias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAuditoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AUDITORIA";
            this.Load += new System.EventHandler(this.frmAuditoria_Load);
            this.gbxAuditorias.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.GroupBox gbxAuditorias;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkPorFecha;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkPorUsuario;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.DataGridView dgvAuditoria;
        private System.Windows.Forms.Button btnSalir;
    }
}