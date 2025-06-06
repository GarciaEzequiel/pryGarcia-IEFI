using pryGarcia_IEFI.FORMULARIOS_USUARIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGarcia_IEFI
{
    public partial class frmUsuarios : Form
    {
        public clsUsuario usuarioIngresado;

        public frmUsuarios(clsUsuario usuarioIngresado)
        {
            InitializeComponent();
            this.usuarioIngresado = usuarioIngresado;
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            lblUsuarioIngresado.Text = $"Usuario: {usuarioIngresado.NombreUsuario}";
        }

        private void tstFichaPersonal_Click(object sender, EventArgs e)
        {
            frmFichaPersonal frm = new frmFichaPersonal();
            AbrirFormularioUnico("frmFichaPersonal", frm);
        }

        private void tstRegistrar_Click(object sender, EventArgs e)
        {
            frmRegistrar frm = new frmRegistrar();
            AbrirFormularioUnico("frmRegistrar", frm);
        }

        private void tstModificar_Click(object sender, EventArgs e)
        {
            frmModificar frm = new frmModificar();
            AbrirFormularioUnico("frmModificar", frm);
        }

        private void tstEliminar_Click(object sender, EventArgs e)
        {
            frmEliminar frm = new frmEliminar();
            AbrirFormularioUnico("frmEliminar", frm);
        }

        private void AbrirFormularioUnico(string nombreFormulario, Form nuevoFormulario)
        {
            Form frmAbierto = Application.OpenForms[nombreFormulario];

            // Si ya está abierto, no hacer nada
            if (frmAbierto != null)
                return;

            // Cierra todos los froms hijos abiertos antes de abrir el nuevo
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            // Abre el nuevo formulario
            nuevoFormulario.MdiParent = this;
            nuevoFormulario.Show();

            nuevoFormulario.MdiParent = this;
            nuevoFormulario.Dock = DockStyle.Fill;
            nuevoFormulario.StartPosition = FormStartPosition.Manual;
            nuevoFormulario.Location = new Point(0, 0);
            nuevoFormulario.Show();
        }
    }
}
