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
    public partial class frmEmpleados: MaterialForm
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        public int IdEmpleado { get; set; }

        DataTable dt = new DataTable();//tabla para guardar los datos
        Cls_Empleados empleado = new Cls_Empleados();//instancia de la clase Cls_Empleados


        private void llenarEmpleado()
        {

            dt = empleado.Consulta_Empleado(IdEmpleado);//consulta para traer los datos del empleado
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    txtIdEmpleado.Text = row[0].ToString();
                    txtNombre.Text = row[1].ToString();
                    TxtDocumento.Text = row[2].ToString();
                    txtDireccion.Text = row[3].ToString();
                    txtTelefono.Text = row[4].ToString();
                    txtEmail.Text = row[5].ToString();


                    txtRol.SelectedValue = int.Parse(row[6].ToString());
                    txtFechaIngreso.Value = Convert.ToDateTime(row[7].ToString());
                    txtFechaRetiro.Value = Convert.ToDateTime(row[8].ToString());
                    txtDatosAdicionales.Text = row[9].ToString();

                }
            }
           
        }

        private void llenar_combo()
        {
            txtRol.DataSource = empleado.ConsultarRol();
            txtRol.DisplayMember = "StrDescripcion";
            txtRol.ValueMember = "IdRolEmpleado";
        }
        private void txtRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenar_combo();
        }

        private void frmEditarEmpleado_Load(object sender, EventArgs e)
        {
            llenar_combo();
            if (IdEmpleado == 0)
            {
                lblTitulo.Text = "INGRESO NUEVO EMPLEADO";
            }
            else
            {
                lblTitulo.Text = "EDITAR EMPLEADO";
                llenarEmpleado();
            }
        }

        public void Guardar()
        {
            string mensaje = "";
            if (validar())
            {
                empleado.C_IdEmpleado = IdEmpleado;
                empleado.C_StrNombre = txtNombre.Text;
                empleado.C_NumDocumento = TxtDocumento.Text; // Changed from double to string
                empleado.C_StrDireccion = txtDireccion.Text;
                empleado.C_StrTelefono = txtTelefono.Text;
                empleado.C_StrEmail = txtEmail.Text;
                empleado.C_IdRolEmpleado = txtRol.SelectedValue.ToString(); // Changed from int to string
                empleado.C_DtmIngreso = txtFechaIngreso.Value.ToString("yyyy-MM-dd");
                empleado.C_DtmRetiro = txtFechaRetiro.Value.ToString("yyyy-MM-dd");
                empleado.C_strDatosAdicionales = txtDatosAdicionales.Text;
                empleado.C_StrUsuarioModifico = "Admin";
                mensaje = empleado.ActualizarEmpleado();

                MessageBox.Show(mensaje);
            }
        }

        //FUNCIÓN QE PERMITE VALIDAR LOS CAMPOS DEL FORMULARIO
        private bool validar()
        {
            Boolean errorCampos = true;
            if (txtNombre.Text == string.Empty)
            {
                MensajeError.SetError(txtNombre, "Debe ingresar el nombre del cliente");
                txtNombre.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtNombre, ""); }
            if (TxtDocumento.Text == "")
            {
                MensajeError.SetError(TxtDocumento, "debe ingresar el documento");
                TxtDocumento.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(TxtDocumento, ""); }
            if (!esNumerico(TxtDocumento.Text))
            {
                MensajeError.SetError(TxtDocumento, "El Documento debe ser numerico");
                TxtDocumento.Focus();
                return false;
            }
            MensajeError.SetError(TxtDocumento, "");
            return errorCampos;
        }

        //función para validar si un valor dado es numerico
        private bool esNumerico(string num)
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
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Rta;
            Rta = MessageBox.Show("Desea salir de la edicion ?", "MENSAJE DE ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Rta == DialogResult.Yes)
            {
                this.Close();
            }
        }
       


       
    }
}
