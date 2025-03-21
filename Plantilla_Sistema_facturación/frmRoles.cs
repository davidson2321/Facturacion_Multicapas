using Capa_LogicaDeNegocios;
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
    public partial class frmRoles: Form
    {
        public frmRoles()
        {
            InitializeComponent();
        }

        public int IdRol { get; set; }


        DataTable dt = new DataTable();//tabla para guardar los datos
        Cls_Roles rol = new Cls_Roles();

        private void llenarRol()
        {
            
            dt = rol.Consultar_Rol(IdRol); // consulta para traer los datos del empleado
            if ( dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    txtIdCliente.Text = row[0].ToString();
                    txtDescripcion.Text = row[1].ToString();
                }
            }
            else
            {
                // Handle the case when dt is null or has no rows
                Console.WriteLine("No data found or an error occurred.");
            }
        }
        private void frmRoles_Load(object sender, EventArgs e)
        {
            llenarRol();
            
        }

        public void Guardar()
        {
            string mensaje = "";
            if (validar())
            {
                rol.C_IdRol = IdRol;
                rol.C_StrNombreRol = txtDescripcion.Text;

                mensaje = rol.ActualizarRol();

                MessageBox.Show(mensaje);
            }
        }

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

       
    }
}
