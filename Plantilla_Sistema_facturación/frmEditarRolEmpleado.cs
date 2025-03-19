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
    public partial class frmEditarRolEmpleado: MaterialForm
    {
        public frmEditarRolEmpleado()
        {
            InitializeComponent();
        }

        public int IdRolEmpleado { get; set; }//propiedad para recibir el id del rol empleado
       

        DataTable dt = new DataTable();//tabla para guardar los datos
        Acceso_datos Acceso = new Acceso_datos();//objeto para acceder a la base de datos

        private void llenarRolEmpleado()
        {
            if (IdRolEmpleado == 0)
            {
                lblTitulo.Text = "INGRESO NUEVO ROL";//titulo del formulario
            }
            else
            {
                //Actualizar el registro con el id pasado
                string sentencia = $"select * from TBLROLES where IdRolEmpleado = {IdRolEmpleado}";//consulta para traer los datos del cliente

                dt = Acceso.EjecutarComandoDatos(sentencia);//ejecuta la sentencia
                foreach (DataRow row in dt.Rows)
                {

                    txtDescripcion.Text = row[1].ToString();
                   
                }






            }
        }
        private void frmEditarRolEmpleado_Load(object sender, EventArgs e)
        {
            llenarRolEmpleado();
        }

        public bool Guardar()
        {
            Boolean actualizado = false;
            if (validar())
            {
                try
                {
                    Acceso_datos Acceso = new Acceso_datos();
                    string sentencia = $"Exec [actualizar_RolEmpleado] {IdRolEmpleado},'{txtDescripcion.Text}','{DateTime.Now.ToShortDateString()}'";
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
            if (txtDescripcion.Text == string.Empty)
            {
                MensajeError.SetError(txtDescripcion, "Debe ingresar el nombre del rol empleado");
                txtDescripcion.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtDescripcion, ""); }
            
            return errorCampos;
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
