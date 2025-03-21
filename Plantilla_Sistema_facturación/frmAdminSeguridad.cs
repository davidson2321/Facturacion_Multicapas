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
using Capa_LogicaDeNegocios;

namespace Plantilla_Sistema_facturación
{
    public partial class frmAdminSeguridad: MaterialForm
    {
        public frmAdminSeguridad()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        Cls_Seguridad SeguridadEmpleado = new Cls_Seguridad();
        private void llenar_combo_Empleados()
        {

            cboEmpleado.DataSource = SeguridadEmpleado.ConsultarEmpleados();
            cboEmpleado.DisplayMember = "StrNombre";
            cboEmpleado.ValueMember = "IdEmpleado";
        }
        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (txtUsuario.Text == string.Empty)
            {
                MensajeError.SetError(txtUsuario, "debe ingresar un valor de Usuario");
                txtUsuario.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtUsuario, ""); }
            if (!IsNumeric(txtPassword.Text) || txtPassword.Text == "")
            {
                MensajeError.SetError(txtPassword, "Debe ingresar un valor de cédula");
                txtPassword.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtPassword, ""); }
            return errorCampos;
        }

        //metodo para validar si los valores son numericos
        private bool IsNumeric(string num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        // función que permite guardar los datos de ingreso a un usuario
        public void Guardar()
        {
            string mensaje = "";
            if (validar())
            {
                SeguridadEmpleado.C_IdEmpleado = int.Parse(cboEmpleado.SelectedValue.ToString());
                SeguridadEmpleado.C_StrUsuario = txtUsuario.Text;
                SeguridadEmpleado.C_StrClave = txtPassword.Text;
                SeguridadEmpleado.C_StrUsuarioModifico = "Javier";
                mensaje = SeguridadEmpleado.ActualizarSeguridadEmpleado();
                MessageBox.Show(mensaje);
                  
            }
            txtPassword.Text = "";
            txtUsuario.Text = "";
        }
        // función que permite eliminar los datos de ingreso de un usuario
        public void Eliminar()
        {
            if (MessageBox.Show($"ESTA SEGURO DE BORRAR EL REGISTRO DE:  \n {cboEmpleado.Text }", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                SeguridadEmpleado.C_IdEmpleado = int.Parse(cboEmpleado.SelectedValue.ToString());

                string mensaje = SeguridadEmpleado.EliminarSeguridadEmpleado();
                if (mensaje != "")
                {
                    MessageBox.Show(mensaje);
                }
                else
                {
                    MessageBox.Show($"BORRADO EL REGISTRO");
                    txtPassword.Text = "";
                    txtUsuario.Text = "";
                }
            }
        }


        public void Consultar()
        {
            int IdEmpleado = int.Parse(cboEmpleado.SelectedValue.ToString());
            dt = SeguridadEmpleado.Consulta_SeguridadEmpleado(IdEmpleado);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    txtUsuario.Text = row[0].ToString();
                    txtPassword.Text = row[1].ToString();
                }
            }
            else
            {
                txtUsuario.Text = "";
                txtPassword.Text = "";
                MessageBox.Show("No hay datos para mostrar");
            }
        }

        private void cboEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenar_combo_Empleados();
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            llenar_combo_Empleados();
        }
        private void frmAdminSeguridad_Load(object sender, EventArgs e)
        {
            llenar_combo_Empleados();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();

        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }


        private void BtnSalir_Click(object sender, EventArgs e)
        {
            //verificamos si desea cerrar la ventana
            DialogResult Rta;
            Rta = MessageBox.Show("Desea salir de la edición ?", "MENSAJE DE ADVERTENCIA",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Rta == DialogResult.OK)
            {
                this.Close();
            }

        }


      
    }
}
