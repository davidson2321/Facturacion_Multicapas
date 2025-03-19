using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plantilla_Sistema_facturación
{
    public partial class FrmPrincipal: MaterialForm
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void tablas_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void PnlPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pnlcontenedor_Paint(object sender, PaintEventArgs e)
        {

        }

       
        

        private void AbrirForm(Form formHijo)
        {
            try
            {
                if (this.Pnlcontenedor.Controls.Count > 0)
                    this.Pnlcontenedor.Controls.RemoveAt(0);
                formHijo.TopLevel = false;
                formHijo.FormBorderStyle = FormBorderStyle.None;
                formHijo.Dock = DockStyle.Fill;
                this.Pnlcontenedor.Controls.Add(formHijo);
                formHijo.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            FrmClientes frmCliente = new FrmClientes();
            AbrirForm(frmCliente);
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            FrmProductos frmProducto = new FrmProductos();
            AbrirForm(frmProducto);
        }

        private void btncategorias_Click(object sender, EventArgs e)
        {
            frmCategoriaProductos frmCategoria = new frmCategoriaProductos();
            AbrirForm(frmCategoria);
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            frmListFacturas frmFactura = new frmListFacturas();
            AbrirForm(frmFactura);
        }

       private void btninformes_Click(object sender, EventArgs e)
        {
            frmInformes frmInforme = new frmInformes();
            AbrirForm(frmInforme);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmListEmpleados frmEmpleado = new frmListEmpleados();
            AbrirForm(frmEmpleado);
        }

        private void btnRolEmpleados_Click(object sender, EventArgs e)
        {
            frmListRolEmpleados frmRolEmpleado = new frmListRolEmpleados();
            AbrirForm(frmRolEmpleado);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmListAdminSeguridad frmUsuario = new frmListAdminSeguridad();
            AbrirForm(frmUsuario);
        }
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            frmAyuda frmAyuda = new frmAyuda();
            AbrirForm(frmAyuda);
        }

        private void btnseguridad_Click(object sender, EventArgs e)
        {
            frmAdminSeguridad frmSeguridad = new frmAdminSeguridad();
            AbrirForm(frmSeguridad);
        }
        private void salirbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
