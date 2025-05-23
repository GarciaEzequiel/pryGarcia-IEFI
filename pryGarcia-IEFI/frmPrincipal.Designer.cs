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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tAREASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDMINISTRACIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUARIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aUDITORIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblUserIngresado = new System.Windows.Forms.ToolStripLabel();
            this.lblFechaLogin = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tAREASToolStripMenuItem,
            this.aDMINISTRACIONToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(502, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tAREASToolStripMenuItem
            // 
            this.tAREASToolStripMenuItem.Name = "tAREASToolStripMenuItem";
            this.tAREASToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.tAREASToolStripMenuItem.Text = "TAREAS";
            // 
            // aDMINISTRACIONToolStripMenuItem
            // 
            this.aDMINISTRACIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSUARIOSToolStripMenuItem,
            this.aUDITORIAToolStripMenuItem});
            this.aDMINISTRACIONToolStripMenuItem.Name = "aDMINISTRACIONToolStripMenuItem";
            this.aDMINISTRACIONToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.aDMINISTRACIONToolStripMenuItem.Text = "ADMINISTRACION";
            // 
            // uSUARIOSToolStripMenuItem
            // 
            this.uSUARIOSToolStripMenuItem.Name = "uSUARIOSToolStripMenuItem";
            this.uSUARIOSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uSUARIOSToolStripMenuItem.Text = "USUARIOS";
            // 
            // aUDITORIAToolStripMenuItem
            // 
            this.aUDITORIAToolStripMenuItem.Name = "aUDITORIAToolStripMenuItem";
            this.aUDITORIAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aUDITORIAToolStripMenuItem.Text = "AUDITORIA";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUserIngresado,
            this.lblFechaLogin});
            this.toolStrip1.Location = new System.Drawing.Point(0, 427);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(502, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblUserIngresado
            // 
            this.lblUserIngresado.Name = "lblUserIngresado";
            this.lblUserIngresado.Size = new System.Drawing.Size(50, 22);
            this.lblUserIngresado.Text = "Usuario:";
            // 
            // lblFechaLogin
            // 
            this.lblFechaLogin.Name = "lblFechaLogin";
            this.lblFechaLogin.Size = new System.Drawing.Size(44, 22);
            this.lblFechaLogin.Text = "Fecha: ";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 452);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tAREASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDMINISTRACIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSUARIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aUDITORIAToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblUserIngresado;
        private System.Windows.Forms.ToolStripLabel lblFechaLogin;
    }
}