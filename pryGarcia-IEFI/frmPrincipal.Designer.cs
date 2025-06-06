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
            this.mstPrincipal = new System.Windows.Forms.MenuStrip();
            this.tstTareas = new System.Windows.Forms.ToolStripMenuItem();
            this.tstAdministracion = new System.Windows.Forms.ToolStripMenuItem();
            this.tstUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tstAuditoria = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblIngreso = new System.Windows.Forms.ToolStripLabel();
            this.mstPrincipal.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstPrincipal
            // 
            this.mstPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mstPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstTareas,
            this.tstAdministracion});
            this.mstPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mstPrincipal.Name = "mstPrincipal";
            this.mstPrincipal.Size = new System.Drawing.Size(953, 28);
            this.mstPrincipal.TabIndex = 0;
            this.mstPrincipal.Text = "menuStrip1";
            // 
            // tstTareas
            // 
            this.tstTareas.Name = "tstTareas";
            this.tstTareas.Size = new System.Drawing.Size(75, 24);
            this.tstTareas.Text = "TAREAS";
            // 
            // tstAdministracion
            // 
            this.tstAdministracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstUsuarios,
            this.tstAuditoria});
            this.tstAdministracion.Name = "tstAdministracion";
            this.tstAdministracion.Size = new System.Drawing.Size(146, 24);
            this.tstAdministracion.Text = "ADMINISTRACION";
            // 
            // tstUsuarios
            // 
            this.tstUsuarios.Name = "tstUsuarios";
            this.tstUsuarios.Size = new System.Drawing.Size(224, 26);
            this.tstUsuarios.Text = "USUARIOS";
            this.tstUsuarios.Click += new System.EventHandler(this.tstUsuarios_Click);
            // 
            // tstAuditoria
            // 
            this.tstAuditoria.Name = "tstAuditoria";
            this.tstAuditoria.Size = new System.Drawing.Size(224, 26);
            this.tstAuditoria.Text = "AUDITORIA";
            this.tstAuditoria.Click += new System.EventHandler(this.tstAuditoria_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblIngreso});
            this.toolStrip1.Location = new System.Drawing.Point(0, 597);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(953, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblIngreso
            // 
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(12, 22);
            this.lblIngreso.Text = ".";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 622);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mstPrincipal);
            this.MainMenuStrip = this.mstPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
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
        private System.Windows.Forms.ToolStripMenuItem tstUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tstAuditoria;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblIngreso;
    }
}