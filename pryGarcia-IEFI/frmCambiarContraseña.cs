using pryGarcia_IEFI.DATOS;
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
    public partial class frmCambiarContraseña : Form
    {
        private readonly clsUsuario usuario;
        public frmCambiarContraseña(clsUsuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            txtUsuario.Text = usuario.NombreUsuario;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nueva = txtNuevaContraseña.Text;

            if (!string.IsNullOrWhiteSpace(nueva))
            {
                clsUsuarioDatos datos = new clsUsuarioDatos();
                datos.ActualizarContraseña(usuario.IdUsuario, nueva);

                MessageBox.Show("Contraseña actualizada correctamente.");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("La contraseña no puede estar vacía.");
            }
        }
    }
}
