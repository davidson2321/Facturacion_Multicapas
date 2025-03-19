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
    public partial class FrmClientes: MaterialForm
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        DataTable dt = new DataTable();
        Acceso_datos Acceso = new Acceso_datos();

        public void llenar_grid()
        {
            dgClientes.Rows.Clear();
            string sentencia = "select idCliente, strNombre, NumDocumento, strTelefono, StrDireccion, StrEmail FROM TBLCLIENTES";
            dt = Acceso.EjecutarComandoDatos(sentencia);

            foreach (DataRow row in dt.Rows)
            {
                dgClientes.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
            }

        }
            private void FrmClientes_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            frmEditarCliente Cliente = new frmEditarCliente();
            Cliente.IdCliente = 0;

            Cliente.ShowDialog();
            llenar_grid();
        }
        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgClientes.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dgClientes.CurrentRow.Index;
                if (MessageBox.Show($"¿Está seguro de borrar el registro? {dgClientes[1,posActual].Value.ToString()}" , "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
                    
                int IdCliente = Convert.ToInt32(dgClientes[0, posActual].Value.ToString());
                string sentencia = $"DELETE FROM TBLCLIENTES WHERE IdCliente = {IdCliente}";
                string Mensaje = Acceso.EjecutarComando(sentencia);
                MessageBox.Show(Mensaje);

            }
            if (dgClientes.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgClientes.CurrentRow.Index;
                frmEditarCliente Cliente = new frmEditarCliente();
                Cliente.IdCliente = int.Parse(dgClientes[0, posActual].Value.ToString());
                Cliente.ShowDialog();
            }
            llenar_grid();
        }

       

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dgClientes.Rows.Clear();//limpia el datagrid
                string sentencia = $"select * FROM TBLCLIENTES WHERE strNombre like '%{txtBuscar.Text}%'";
                dt = Acceso.EjecutarComandoDatos(sentencia);//ejecuta la sentencia
                foreach (DataRow row in dt.Rows)
                {
                    dgClientes.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);//agrega los datos al datagrid
                    txtBuscar.Text = "";//limpia el textbox
                }

            }
            else
            {
               llenar_grid();
            }

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
