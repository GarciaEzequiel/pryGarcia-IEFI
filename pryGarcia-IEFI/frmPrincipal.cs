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
        private string nombreUsuario;
        public frmPrincipal(clsUsuario usuarioIngresado)
        {
            InitializeComponent();
            this.nombreUsuario = usuarioIngresado.NombreUsuario;
        }
        

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            string horaActual = DateTime.Now.ToString("HH:mm:ss");
            string fecha = DateTime.Now.ToString("D");
            lblIngreso.Text = $"Usuario: {nombreUsuario} | Hora de ingreso: {horaActual} | Fecha: {fecha}";
        }
    }
}
