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
    public partial class frmListFacturas: MaterialForm
    {
        public frmListFacturas()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        Acceso_datos Acceso = new Acceso_datos();

        public void llenar_grid()
        {
            dgFacturas.Rows.Clear();
            string sentencia = "SELECT f.idFactura, f.idFactura, c.StrNombre AS Cliente, e.strNombre AS Empleado, f.NumDescuento, f.NumImpuesto, f.NumValorTotal, f.DtmFechaModifica, f.IdEstado  FROM TBLFACTURA f INNER JOIN TBLCLIENTES c ON f.IdCliente = c.IdCliente INNER JOIN TBLEMPLEADO e ON f.IdEmpleado = e.IdEmpleado ";
            dt = Acceso.EjecutarComandoDatos(sentencia);

            foreach (DataRow row in dt.Rows)
            {
                
                dgFacturas.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8]);
            }

        }
        private void frmListFacturas_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            frmFacturas Facturas = new frmFacturas();
            Facturas.IdFactura = 0;

            Facturas.ShowDialog();
            llenar_grid();
        }
        private void dgFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgFacturas.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dgFacturas.CurrentRow.Index;
                if (MessageBox.Show($"¿Está seguro de borrar el registro? {dgFacturas[1, posActual].Value.ToString()}", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;

                int IdFactura = Convert.ToInt32(dgFacturas[0, posActual].Value.ToString());
                string sentencia = $"DELETE FROM TBLFACTURA WHERE IdFactura={IdFactura}";
                string Mensaje = Acceso.EjecutarComando(sentencia);
                MessageBox.Show(Mensaje);

            }
            if (dgFacturas.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgFacturas.CurrentRow.Index;
                frmFacturas Facturas = new frmFacturas();
                Facturas.IdFactura = int.Parse(dgFacturas[0, posActual].Value.ToString());
                Facturas.ShowDialog();
            }
            llenar_grid();
        }

        

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dgFacturas.Rows.Clear();//limpia el datagrid
                string sentencia = $"select * FROM TBLFACTURA WHERE IdFactura like '%{txtBuscar.Text}%'";
                dt = Acceso.EjecutarComandoDatos(sentencia);//ejecuta la sentencia
                foreach (DataRow row in dt.Rows)
                {
                    dgFacturas.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8]);//agrega los datos al datagrid
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
