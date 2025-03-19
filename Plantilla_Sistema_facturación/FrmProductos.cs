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
    public partial class FrmProductos: MaterialForm
    {
       
        public FrmProductos()
        {
            InitializeComponent();
        }


        DataTable dt = new DataTable();
        Acceso_datos Acceso = new Acceso_datos();

        public void llenar_grid()
        {
            dgProductos.Rows.Clear();
            string sentencia = "SELECT   p.idProducto, p.strNombre,  p.strCodigo, p.NumPrecioCompra, p.NumPrecioVenta,  p.NumStock, c.strDescripcion AS Categoria, p.strFoto, p.StrDetalle FROM TBLPRODUCTO p INNER JOIN TBLCATEGORIA_PROD c ON p.idCategoria = c.idCategoria; ";
            dt = Acceso.EjecutarComandoDatos(sentencia);

            foreach (DataRow row in dt.Rows)
            {
                dgProductos.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5],row[6], row[7], row[8]);
            }
        }
        private void FrmProductos_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            frmEditarProducto Producto = new frmEditarProducto();
            Producto.IdProducto = 0;//0 para nuevo registro
            Producto.ShowDialog();
            llenar_grid();

        }

        private void dgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgProductos.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dgProductos.CurrentRow.Index;
                if (MessageBox.Show($"¿Está seguro de borrar el producto? {dgProductos[1, posActual].Value.ToString()}", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;

                int IdProducto = Convert.ToInt32(dgProductos[0, posActual].Value.ToString());
                string sentencia = $"DELETE FROM TBLPRODUCTO WHERE IdProducto = {IdProducto}";
                string Mensaje = Acceso.EjecutarComando(sentencia);
                MessageBox.Show(Mensaje);

            }
            if (dgProductos.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgProductos.CurrentRow.Index;
                frmEditarProducto Producto = new frmEditarProducto();
                Producto.IdProducto = int.Parse(dgProductos[0, posActual].Value.ToString());
                Producto.ShowDialog();
            }
            llenar_grid();
        }
      

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dgProductos.Rows.Clear();//limpia el datagrid
                string sentencia = $"select * FROM TBLPRODUCTO WHERE strNombre like '%{txtBuscar.Text}%'";
                dt = Acceso.EjecutarComandoDatos(sentencia);//ejecuta la sentencia
                foreach (DataRow row in dt.Rows)
                {
                    dgProductos.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8]);//agrega los datos al datagrid
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
