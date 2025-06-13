namespace pryGarcia_IEFI
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.mstPrincipal = new System.Windows.Forms.MenuStrip();
            this.tstTareas = new System.Windows.Forms.ToolStripMenuItem();
            this.tstAdministracion = new System.Windows.Forms.ToolStripMenuItem();
            this.tstAuditoria = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblIngreso = new System.Windows.Forms.ToolStripLabel();
            this.tstFichaPersonal = new System.Windows.Forms.ToolStripMenuItem();
            this.tstRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tstModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.tstEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.tstUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mstPrincipal.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstPrincipal
            // 
            this.mstPrincipal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mstPrincipal.BackgroundImage")));
            this.mstPrincipal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mstPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstTareas,
            this.tstAdministracion});
            this.mstPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mstPrincipal.Name = "mstPrincipal";
            this.mstPrincipal.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mstPrincipal.Size = new System.Drawing.Size(715, 24);
            this.mstPrincipal.TabIndex = 0;
            this.mstPrincipal.Text = "menuStrip1";
            // 
            // tstTareas
            // 
            this.tstTareas.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tstTareas.ImageTransparentColor = System.Drawing.Color.LightGray;
            this.tstTareas.Name = "tstTareas";
            this.tstTareas.Size = new System.Drawing.Size(62, 20);
            this.tstTareas.Text = "TAREAS";
            // 
            // tstAdministracion
            // 
            this.tstAdministracion.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tstAdministracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstUsuarios,
            this.tstAuditoria});
            this.tstAdministracion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tstAdministracion.Name = "tstAdministracion";
            this.tstAdministracion.Size = new System.Drawing.Size(123, 20);
            this.tstAdministracion.Text = "ADMINISTRACION";
            // 
            // tstAuditoria
            // 
            this.tstAuditoria.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tstAuditoria.Name = "tstAuditoria";
            this.tstAuditoria.Size = new System.Drawing.Size(180, 22);
            this.tstAuditoria.Text = "AUDITORIA";
            this.tstAuditoria.Click += new System.EventHandler(this.tstAuditoria_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblIngreso});
            this.toolStrip1.Location = new System.Drawing.Point(0, 480);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(715, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblIngreso
            // 
            this.lblIngreso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreso.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(10, 22);
            this.lblIngreso.Text = ".";
            // 
            // tstFichaPersonal
            // 
            this.tstFichaPersonal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tstFichaPersonal.Name = "tstFichaPersonal";
            this.tstFichaPersonal.Size = new System.Drawing.Size(180, 22);
            this.tstFichaPersonal.Text = "Ficha Personal";
            this.tstFichaPersonal.Click += new System.EventHandler(this.tstFichaPersonal_Click);
            // 
            // tstRegistrar
            // 
            this.tstRegistrar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tstRegistrar.Name = "tstRegistrar";
            this.tstRegistrar.Size = new System.Drawing.Size(180, 22);
            this.tstRegistrar.Text = "Registrar";
            this.tstRegistrar.Click += new System.EventHandler(this.tstRegistrar_Click);
            // 
            // tstModificar
            // 
            this.tstModificar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tstModificar.Name = "tstModificar";
            this.tstModificar.Size = new System.Drawing.Size(180, 22);
            this.tstModificar.Text = "Modificar";
            this.tstModificar.Click += new System.EventHandler(this.tstModificar_Click);
            // 
            // tstEliminar
            // 
            this.tstEliminar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tstEliminar.Name = "tstEliminar";
            this.tstEliminar.Size = new System.Drawing.Size(180, 22);
            this.tstEliminar.Text = "Eliminar";
            this.tstEliminar.Click += new System.EventHandler(this.tstEliminar_Click);
            // 
            // tstUsuarios
            // 
            this.tstUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstFichaPersonal,
            this.tstRegistrar,
            this.tstModificar,
            this.tstEliminar});
            this.tstUsuarios.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tstUsuarios.Name = "tstUsuarios";
            this.tstUsuarios.Size = new System.Drawing.Size(180, 22);
            this.tstUsuarios.Text = "USUARIOS";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(715, 505);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mstPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mstPrincipal;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mstPrincipal.ResumeLayout(false);
            this.mstPrincipal.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tstTareas;
        private System.Windows.Forms.ToolStripMenuItem tstAdministracion;
        private System.Windows.Forms.ToolStripMenuItem tstAuditoria;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblIngreso;
        private System.Windows.Forms.ToolStripMenuItem tstUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tstFichaPersonal;
        private System.Windows.Forms.ToolStripMenuItem tstRegistrar;
        private System.Windows.Forms.ToolStripMenuItem tstModificar;
        private System.Windows.Forms.ToolStripMenuItem tstEliminar;
    }
}