namespace pryGarcia_IEFI
{
    partial class frmUsuarios
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
            this.mstUsuarios = new System.Windows.Forms.MenuStrip();
            this.tstFichaPersonal = new System.Windows.Forms.ToolStripMenuItem();
            this.tstRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tstModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.tstEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labae = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuarioIngresado = new System.Windows.Forms.ToolStripStatusLabel();
            this.mstUsuarios.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstUsuarios
            // 
            this.mstUsuarios.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mstUsuarios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstFichaPersonal,
            this.tstRegistrar,
            this.tstModificar,
            this.tstEliminar});
            this.mstUsuarios.Location = new System.Drawing.Point(0, 0);
            this.mstUsuarios.Name = "mstUsuarios";
            this.mstUsuarios.Size = new System.Drawing.Size(953, 28);
            this.mstUsuarios.TabIndex = 0;
            this.mstUsuarios.Text = "Menu Usuarios";
            // 
            // tstFichaPersonal
            // 
            this.tstFichaPersonal.Name = "tstFichaPersonal";
            this.tstFichaPersonal.Size = new System.Drawing.Size(140, 24);
            this.tstFichaPersonal.Text = "FICHA PERSONAL";
            this.tstFichaPersonal.Click += new System.EventHandler(this.tstFichaPersonal_Click);
            // 
            // tstRegistrar
            // 
            this.tstRegistrar.Name = "tstRegistrar";
            this.tstRegistrar.Size = new System.Drawing.Size(98, 24);
            this.tstRegistrar.Text = "REGISTRAR";
            this.tstRegistrar.Click += new System.EventHandler(this.tstRegistrar_Click);
            // 
            // tstModificar
            // 
            this.tstModificar.Name = "tstModificar";
            this.tstModificar.Size = new System.Drawing.Size(101, 24);
            this.tstModificar.Text = "MODIFICAR";
            this.tstModificar.Click += new System.EventHandler(this.tstModificar_Click);
            // 
            // tstEliminar
            // 
            this.tstEliminar.Name = "tstEliminar";
            this.tstEliminar.Size = new System.Drawing.Size(89, 24);
            this.tstEliminar.Text = "ELIMINAR";
            this.tstEliminar.Click += new System.EventHandler(this.tstEliminar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labae,
            this.lblUsuarioIngresado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 596);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(953, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labae
            // 
            this.labae.Name = "labae";
            this.labae.Size = new System.Drawing.Size(0, 20);
            // 
            // lblUsuarioIngresado
            // 
            this.lblUsuarioIngresado.Name = "lblUsuarioIngresado";
            this.lblUsuarioIngresado.Size = new System.Drawing.Size(62, 20);
            this.lblUsuarioIngresado.Text = "Usuario:";
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 622);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mstUsuarios);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mstUsuarios;
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USUARIOS";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.mstUsuarios.ResumeLayout(false);
            this.mstUsuarios.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tstFichaPersonal;
        private System.Windows.Forms.ToolStripMenuItem tstRegistrar;
        private System.Windows.Forms.ToolStripMenuItem tstModificar;
        private System.Windows.Forms.ToolStripMenuItem tstEliminar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labae;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuarioIngresado;
    }
}