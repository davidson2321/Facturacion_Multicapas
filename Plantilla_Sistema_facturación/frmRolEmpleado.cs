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
    public partial class frmRolEmpleado: MaterialForm
    {
        public frmRolEmpleado()
        {
            InitializeComponent();
        }
        public int IdRolEmpleado { get; set; }
        private void frmRolEmpleado_Load(object sender, EventArgs e)
        {
            if (IdRolEmpleado == 0 )
            {
                lblTitulo.Text = "INGRESO NUEVO ROL EMPLEADO";
            }
            else
            {
                lblTitulo.Text = "EDITAR ROL EMPLEADO";
                txtIdRolEmpleado.Text = IdRolEmpleado.ToString();
                txtNombreRol.Text = "Nombre Rol";
                txtDescripcionRol.Text = "Descripcion Rol";

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
