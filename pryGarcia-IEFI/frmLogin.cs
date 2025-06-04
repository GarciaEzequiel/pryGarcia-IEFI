using pryGarcia_IEFI.DATOS;
using pryGarcia_IEFI.MODELOS;
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
                //MessageBox.Show($"¡Bienvenido {usuario.Nombre} {usuario.Apellido} ({usuario.Area})!");

                clsAuditoriaDatos datos = new clsAuditoriaDatos();
                clsAuditoria nueva = new clsAuditoria
                {
                    IdUsuario = usuario.IdUsuario,
                    Fecha = DateTime.Now,
                    TiempoUso = 0
                };
                int idAuditoria = datos.RegistrarAuditoriaYDevolverId(nueva);

                usuario.IdAuditoriaSesion = idAuditoria;
                usuario.FechaAcceso = nueva.Fecha;

                this.Hide();
                frmPrincipal frmPrincipal = new frmPrincipal(usuario, idAuditoria, nueva.Fecha);
                frmPrincipal.Show();

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos, o cuenta inactiva.");
            }
        }
    }
}
