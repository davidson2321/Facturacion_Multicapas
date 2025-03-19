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
    public partial class frmEditarEmpleado: MaterialForm
    {
        public frmEditarEmpleado()
        {
            InitializeComponent();
        }

        public int IdEmpleado { get; set; }

        DataTable dt = new DataTable();//tabla para guardar los datos
        Acceso_datos Acceso = new Acceso_datos();//objeto para acceder a la base de datos


        private void llenarEmpleado()
        {
            if (IdEmpleado == 0)
            {
                lblTitulo.Text = "INGRESO NUEVO EMPLEADO";
            }
            else
            {
                string sentencia = $"SELECT e.IdEmpleado, e.strNombre, e.NumDocumento, e.StrDireccion, e.StrTelefono, e.StrEmail, r.StrDescripcion, e.DtmIngreso, e.DtmRetiro, e.strDatosAdicionales FROM TBLEMPLEADO e INNER JOIN TBLROLES r ON e.IdRolEmpleado = r.IdRolEmpleado WHERE e.IdEmpleado = {IdEmpleado}";//consulta para traer los datos del cliente

                dt = Acceso.EjecutarComandoDatos(sentencia);//ejecuta la sentencia
                foreach (DataRow row in dt.Rows)
                {
                    txtIdEmpleado.Text = row[0].ToString();
                    txtNombre.Text = row[1].ToString();
                    TxtDocumento.Text = row[2].ToString();
                    txtDireccion.Text = row[3].ToString();
                    txtTelefono.Text = row[4].ToString();
                    txtEmail.Text = row[5].ToString();
                    txtRol.Text = row[6].ToString();

                }




            }
        }
        private void frmEditarEmpleado_Load(object sender, EventArgs e)
        {
            llenarEmpleado();
        }

        public bool Guardar()
        {
            Boolean actualizado = false;
            if (validar())
            {
                try
                {
                    Acceso_datos Acceso = new Acceso_datos();
                    string sentencia = $"Exec [actualizar_Empleado] {IdEmpleado},'{txtNombre.Text}',{TxtDocumento.Text} ,'{txtDireccion.Text}','{txtTelefono.Text}', '{txtEmail.Text}','{txtRol.Text}','{DateTime.Now.ToShortDateString()}'";
                    MessageBox.Show(Acceso.EjecutarComando(sentencia));
                    actualizado = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("falló inserción: " + ex);
                    actualizado = false;
                }
            }
            return actualizado;

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
            this.Close();
        }
        private ErrorProvider MensajeError = new ErrorProvider();

    }
}
