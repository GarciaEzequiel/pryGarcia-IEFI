using pryGarcia_IEFI.DATOS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGarcia_IEFI
{
    public partial class frmLogin : Form
    {   
        clsConexion conexionBD;
        public frmLogin()
        {
            InitializeComponent();    
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            clsUsuarioDatos usuarioDatos = new clsUsuarioDatos();
            clsUsuario usuario = usuarioDatos.ValidarLogin(nombreUsuario, contraseña);

            if (usuario != null)
            {
                MessageBox.Show($"¡Bienvenido {usuario.Nombre} {usuario.Apellido} ({usuario.Area})!");
                // Podés abrir el formulario principal o pasar datos del usuario
                this.Hide();
                frmPrincipal principal = new frmPrincipal(usuario);
                principal.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos, o cuenta inactiva.");
            }
        }
    }
}
