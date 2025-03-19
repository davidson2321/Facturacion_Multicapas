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
    public partial class frmCategoriaProductos: MaterialForm
    {
        public frmCategoriaProductos()
        {
            InitializeComponent();
        }


        DataTable dt = new DataTable();
        Acceso_datos Acceso = new Acceso_datos();

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        public void llenar_grid()
        {
            dgCategorias.Rows.Clear();
            string sentencia = "SELECT  idCategoria, StrDescripcion FROM TBLCATEGORIA_PROD ";
            dt = Acceso.EjecutarComandoDatos(sentencia);

            foreach (DataRow row in dt.Rows)
            {
                dgCategorias.Rows.Add(row[0], row[1]);
            }
        }
        private void frmCategoriaProductos_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            frmEditarCategoriaProducto Categoria = new frmEditarCategoriaProducto();
            Categoria.IdCategoria = 0;

            Categoria.ShowDialog();
            llenar_grid();
        }
        private void dgCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgCategorias.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dgCategorias.CurrentRow.Index;
                if (MessageBox.Show($"¿Está seguro de borrar la categoria? {dgCategorias[1, posActual].Value.ToString()}", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;

                int IdCategoria = Convert.ToInt32(dgCategorias[0, posActual].Value.ToString());
                string sentencia = $"DELETE FROM TBLCATEGORIA_PROD  WHERE IdCategoria = {IdCategoria}";
                string Mensaje = Acceso.EjecutarComando(sentencia);
                MessageBox.Show(Mensaje);

            }
            if (dgCategorias.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgCategorias.CurrentRow.Index;
                frmEditarCategoriaProducto Categoria = new frmEditarCategoriaProducto();
                Categoria.IdCategoria = int.Parse(dgCategorias[0, posActual].Value.ToString());
                Categoria.ShowDialog();
            }
            llenar_grid();
        }

        

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dgCategorias.Rows.Clear();//limpia el datagrid
                string sentencia = $"select * FROM TBLCATEGORIA_PROD WHERE StrDescripcion like '%{txtBuscar.Text}%'";
                dt = Acceso.EjecutarComandoDatos(sentencia);//ejecuta la sentencia
                foreach (DataRow row in dt.Rows)
                {
                    dgCategorias.Rows.Add(row[0], row[1]);//agrega los datos al datagrid
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
