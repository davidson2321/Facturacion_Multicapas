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
    public partial class frmEditarProducto : MaterialForm
    {
        
        public frmEditarProducto()
        {
            InitializeComponent();
        }
        public int IdProducto { get; set; }
        DataTable dt = new DataTable();//tabla para guardar los datos
        Acceso_datos Acceso = new Acceso_datos();//objeto para acceder a la base de datos

        private void llenarProducto()
        {
            if (IdProducto == 0)
            {
                lblTitulo.Text = "INGRESO NUEVO PRODUCTO";
            }
            else
            {
                string sentencia = $"select * from TBLPRODUCTO where IdProducto = {IdProducto}";
                dt = Acceso.EjecutarComandoDatos(sentencia);

                foreach (DataRow row in dt.Rows)
                {
                    txtProducto.Text = row[1].ToString();
                    txtReferencia.Text = row[2].ToString();
                    txtPrecioCompra.Text = row[3].ToString();
                    txtPrecioVenta.Text = row[4].ToString();
                    txtStock.Text = row[5].ToString();
                    txtCategoria.Text = row[6].ToString();
                    txtImagen.Text = row[7].ToString();
                    txtDetalles.Text = row[8].ToString();
                    
                }
               
            }
        }

        private void frmEditarProducto_Load(object sender, EventArgs e)
        {
            llenarProducto();
        }

        private void txtReferencia_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public bool Guardar()
        {
            Boolean actualizado = false;
            if (validar())
            {
                try
                {
                    Acceso_datos Acceso = new Acceso_datos();
                    string sentencia = $"Exec [actualizar_Producto] {IdProducto},'{txtProducto.Text}',{txtReferencia.Text} ,'{txtPrecioCompra.Text}','{txtPrecioVenta.Text}', '{txtStock.Text}','{txtImagen.Text}', '{txtDetalles.Text}' , '{DateTime.Now.ToShortDateString()}'";
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
            if (txtProducto.Text == string.Empty)
            {
                MensajeError.SetError(txtProducto, "Debe ingresar el nombre del producto");
                txtProducto.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtProducto, ""); }
            
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
