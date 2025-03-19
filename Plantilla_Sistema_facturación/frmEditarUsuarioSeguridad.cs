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
    public partial class frmEditarUsuarioSeguridad: MaterialForm
    {
        public frmEditarUsuarioSeguridad()
        {
            InitializeComponent();
        }

        public int IdUsuario { get; set; }
        private void frmEditarUsuarioSeguridad_Load(object sender, EventArgs e)
        {
            if (IdUsuario == 0)
            {
                lblTitulo.Text = "INGRESO NUEVO USUARIO";
            }
            else
            {
                lblTitulo.Text = "EDITAR USUARIO";
                txtIdUsuario.Text = IdUsuario.ToString();
                txtNombre.Text = "Nombre Usuario";
                txtUsuario.Text = "Usuario";
                txtClave.Text = "Clave";

            }  
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Empleado actualizado correctamente");
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
