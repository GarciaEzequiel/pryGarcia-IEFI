using pryGarcia_IEFI.DATOS;
using pryGarcia_IEFI.MODELOS;
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
    public partial class frmPrincipal : Form
    {
        private DateTime horaInicioSesion;
        private int idAuditoria;
        //private string nombreUsuario;
        public clsUsuario usuarioIngresado;
        public frmPrincipal(clsUsuario usuarioIngresado, int idAuditoria,DateTime horaInicioSesion)
        {
            InitializeComponent();
            this.FormClosing += frmPrincipal_FormClosing;
            this.usuarioIngresado = usuarioIngresado;
            this.horaInicioSesion = DateTime.Now;
            this.idAuditoria = idAuditoria;

        }
        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DateTime salida = DateTime.Now;
            TimeSpan tiempoUso = salida - usuarioIngresado.FechaAcceso;

            clsAuditoriaDatos auditoriaDatos = new clsAuditoriaDatos();
            auditoriaDatos.ActualizarTiempoUso(usuarioIngresado.IdAuditoriaSesion, (int)tiempoUso.TotalSeconds);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (usuarioIngresado.Area == "Operario" )
            {
                tstAdministracion.Visible = false;
            }
            
            string horaActual = DateTime.Now.ToString("HH:mm:ss");
            string fecha = DateTime.Now.ToString("D");
            lblIngreso.Text = $"Usuario: {usuarioIngresado.NombreUsuario} | Hora de ingreso: {horaActual} | Fecha: {fecha}";
        }

        private void tstAuditoria_Click(object sender, EventArgs e)
        {
            frmAuditoria auditoria = new frmAuditoria(usuarioIngresado);
            auditoria.Show();
        }

        private void tstUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios usuarios = new frmUsuarios(usuarioIngresado);
            usuarios.Show();
        }
    }
}
