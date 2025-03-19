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
    public partial class frmFacturas: MaterialForm
    {
        public frmFacturas()
        {
            InitializeComponent();
        }
        public int IdFactura { get; set; }

        DataTable dt = new DataTable();//tabla para guardar los datos
        Acceso_datos Acceso = new Acceso_datos();//objeto para acceder a la base de datos

        private void llenarFactura()
        {
            if (IdFactura == 0)
            {
                lblTitulo.Text = "INGRESAR NUEVA FACTURA";
            }
            else
            {
                //Actualizar el registro con el id pasado
                string sentencia = $"SELECT f.idFactura, f.idFactura,  c.StrNombre AS Cliente, e.strNombre AS Empleado, f.NumDescuento, f.NumImpuesto, f.NumValorTotal, f.DtmFechaModifica, f.IdEstado FROM TBLFACTURA f  INNER JOIN TBLCLIENTES c ON f.IdCliente = c.IdCliente  INNER JOIN TBLEMPLEADO e ON f.IdEmpleado = e.IdEmpleado  WHERE f.IdFactura = {IdFactura};";
                dt = Acceso.EjecutarComandoDatos(sentencia);//ejecuta la sentencia
                foreach (DataRow row in dt.Rows)
                {

                    txtIdFactura.Text = row[0].ToString();
                    txtNumeroFactura.Text = row[1].ToString();
                    txtCliente.Text = row[2].ToString();
                    txtEmpleado.Text = row[3].ToString();
                    txtDescuento.Text = row[4].ToString();
                    txtIva.Text = row[5].ToString();
                    txtTotalFactura.Text = row[6].ToString();
                    txtFecha.Text = row[7].ToString();
                    txtEstadoFactura.Text = row[8].ToString();



                }

            }
        }
        private void frmFacturas_Load(object sender, EventArgs e)
        {
            llenarFactura();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
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
                    string sentencia = $"Exec [actualizar_Factura] {IdFactura},'{IdFactura}', '{txtCliente.Text}', '{txtEmpleado.Text}', '{txtDescuento.Text}','{txtIva.Text}', '{txtTotalFactura}','{txtFecha.Text}','{txtEstadoFactura}', '{DateTime.Now.ToShortDateString()}'";
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
            if (txtCliente.Text == string.Empty)
            {
                MensajeError.SetError(txtCliente, "Debe ingresar el nombre del cliente");
                txtCliente.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtCliente, ""); }
          
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

