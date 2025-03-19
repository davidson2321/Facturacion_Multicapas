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
    public partial class frmEditarCategoriaProducto: MaterialForm
    {
        public frmEditarCategoriaProducto()
        {
            InitializeComponent();
        }
        public int IdCategoria { get; set; }

        DataTable dt = new DataTable();//tabla para guardar los datos
        Acceso_datos Acceso = new Acceso_datos();//objeto para acceder a la base de datos



        private void llenarCategoria()
        {
            if (IdCategoria == 0)
            {
                lblTitulo.Text = "INGRESO NUEVO CLIENTE";//titulo del formulario
            }
            else
            {
                //Actualizar el registro con el id pasado
                string sentencia = $"select * from TBLCATEGORIA_PROD where idCategoria = {IdCategoria}";//consulta para traer los datos del cliente

                dt = Acceso.EjecutarComandoDatos(sentencia);//ejecuta la sentencia
                foreach (DataRow row in dt.Rows)
                {

                    txtCategoria.Text = row[1].ToString();






                }
            }
        }


        private void frmEditarCategoriaProducto_Load(object sender, EventArgs e)
        {
           llenarCategoria();
        }

        // *************************************** ACTUALIZACIONES ********* ********************
        // ------- funciones que permiten el ingreso , retiro y actualización de la información de Clientes en la base de datos

        public bool Guardar()
        {
            Boolean actualizado = false;
            if (validar())
            {
                try
                {
                    Acceso_datos Acceso = new Acceso_datos();
                    string sentencia = $"Exec [actualizar_Categoria] {IdCategoria},'{txtCategoria.Text}'{DateTime.Now.ToShortDateString()}'";
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
            if (txtCategoria.Text == string.Empty)
            {
                MensajeError.SetError(txtCategoria, "Debe ingresar el nombre de la categoria ");
                txtCategoria.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtCategoria, ""); }
           
           
          
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
        // Add this field to fix the error
        private ErrorProvider MensajeError = new ErrorProvider();
    }
}
