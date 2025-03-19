using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Plantilla_Sistema_facturación
{
    public partial class frmListAdminSeguridad: MaterialForm
    {
        public frmListAdminSeguridad()
        {
            InitializeComponent();
        }

        private void frmListAdminSeguridad_Load(object sender, EventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            frmEditarUsuarioSeguridad Usuario = new frmEditarUsuarioSeguridad();
            Usuario.IdUsuario = 0;

            Usuario.ShowDialog();
        }
        private void dgSeguridad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgSeguridad.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dgSeguridad.CurrentRow.Index;
                if (MessageBox.Show("¿Está seguro de borrar el registro?", "CONFIRMACIÓN", MessageBoxButtons.YesNo) == DialogResult.Yes) ;
                MessageBox.Show($"BORRADO indice {e.RowIndex} ID {dgSeguridad[0, posActual].Value}");

            }
            if (dgSeguridad.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgSeguridad.CurrentRow.Index;
                frmEditarUsuarioSeguridad Usuario = new frmEditarUsuarioSeguridad();
                Usuario.IdUsuario = int.Parse(dgSeguridad[0, posActual].Value.ToString());
                Usuario.ShowDialog();
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
