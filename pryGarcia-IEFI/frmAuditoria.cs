using ClosedXML.Excel;
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
    
    public partial class frmAuditoria : Form
    {
        public clsUsuario usuarioIngresado;
        public clsAuditoriaDatos datos;

        public frmAuditoria(clsUsuario usuarioIngresado)
        {
            InitializeComponent();
            this.usuarioIngresado = usuarioIngresado;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            //dgvAuditoria.DataSource = null;
        }

        private void frmAuditoria_Load(object sender, EventArgs e)
        {
            //lblUsuarioIngresado.Text = $"Usuario: {usuarioIngresado.NombreUsuario}";
            txtUsuario.Clear();
            dtpFechaDesde.Value = DateTime.Now;
            dtpFechaHasta.Value = DateTime.Now;
            datos = new clsAuditoriaDatos();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            DateTime? desde = null;
            DateTime? hasta = null;
            string usuario = null;

            if (chkPorFecha.Checked)
            {
                desde = dtpFechaDesde.Value.Date;
                hasta = dtpFechaHasta.Value.Date;
            }

            if (chkPorUsuario.Checked) 
            {
                usuario = txtUsuario.Text.Trim();
            }

            List<clsAuditoria> lista = datos.ObtenerAuditoriasFiltradas(usuario, desde, hasta);
            dgvAuditoria.Columns.Clear();
            dgvAuditoria.Rows.Clear();

            // Defino columnas con encabezados personalizados
            dgvAuditoria.Columns.Add("IdAuditoria", "ID Auditoría");
            dgvAuditoria.Columns.Add("NombreUsuario", "Usuario");
            dgvAuditoria.Columns.Add("Fecha", "Fecha");
            dgvAuditoria.Columns.Add("TiempoUso", "Tiempo de Uso (segundos)");

            // Cargo filas con los datos
            foreach (clsAuditoria a in lista)
            {
                dgvAuditoria.Rows.Add(
                    a.IdAuditoria.ToString(),
                    a.NombreUsuario,
                    a.Fecha.ToString("dd/MM/yyyy HH:mm:ss"),
                    a.TiempoUso.ToString()
                );
            }
            dgvAuditoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAuditoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAuditoria.ReadOnly = true;
        }

        private void chkPorUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPorUsuario.Checked)
            {
                txtUsuario.Enabled = true;
            }
            else 
            {
                txtUsuario.Enabled=false;
                txtUsuario.Text = "";
            }
        }

        private void chkPorFecha_CheckedChanged(object sender, EventArgs e)
        {

            if (chkPorFecha.Checked)
            {
                dtpFechaHasta.Enabled = true;
                dtpFechaDesde.Enabled = true;
            }
            else
            {
                dtpFechaHasta.Enabled = false;
                dtpFechaDesde.Enabled = false;
            }
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            if (dgvAuditoria.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos Excel (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Guardar auditorías como Excel";
            saveFileDialog.FileName = "Auditorias.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Auditorias");

                        // Escribir encabezados
                        for (int i = 0; i < dgvAuditoria.Columns.Count; i++)
                        {
                            worksheet.Cell(1, i + 1).Value = dgvAuditoria.Columns[i].HeaderText;
                        }

                        // Escribir datos
                        for (int i = 0; i < dgvAuditoria.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvAuditoria.Columns.Count; j++)
                            {
                                worksheet.Cell(i + 2, j + 1).Value = dgvAuditoria.Rows[i].Cells[j].Value?.ToString();
                            }
                        }

                        // Guardar archivo
                        workbook.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Archivo Excel generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    
}
