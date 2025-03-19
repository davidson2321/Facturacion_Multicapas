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
    public partial class frmListRolEmpleados : MaterialForm
    {
        public frmListRolEmpleados()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        Acceso_datos Acceso = new Acceso_datos();
        public void llenar_grid()
        {
            dgRolEmpleados.Rows.Clear();
            string sentencia = "select IdRolEmpleado, StrDescripcion FROM TBLROLES";
            dt = Acceso.EjecutarComandoDatos(sentencia);

            foreach (DataRow row in dt.Rows)
            {
                dgRolEmpleados.Rows.Add(row[0], row[1]);
            }

        }
        private void frmListRolEmpleados_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            frmEditarRolEmpleado rolEmpleado = new frmEditarRolEmpleado();
            rolEmpleado.IdRolEmpleado = 0;

            rolEmpleado.ShowDialog();
            llenar_grid();
        }
        private void dgRolEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgRolEmpleados.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dgRolEmpleados.CurrentRow.Index;
                if (MessageBox.Show($"¿Está seguro de borrar el registro? {dgRolEmpleados[1, posActual].Value.ToString()}", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;

                int IdRolEmpleado = Convert.ToInt32(dgRolEmpleados[0, posActual].Value.ToString());
                string sentencia = $"DELETE FROM TBLROLES WHERE IdRolEmpleado = {IdRolEmpleado}";
                string Mensaje = Acceso.EjecutarComando(sentencia);
                MessageBox.Show(Mensaje);

            }
            if (dgRolEmpleados.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgRolEmpleados.CurrentRow.Index;
                frmEditarRolEmpleado rolEmpleado = new frmEditarRolEmpleado();
                rolEmpleado.IdRolEmpleado = int.Parse(dgRolEmpleados[0, posActual].Value.ToString());
                rolEmpleado.ShowDialog();
            }
            llenar_grid();
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dgRolEmpleados.Rows.Clear();//limpia el datagrid
                string sentencia = $"select * FROM TBLROLES WHERE strDescripcion like '%{txtBuscar.Text}%'";
                dt = Acceso.EjecutarComandoDatos(sentencia);//ejecuta la sentencia
                foreach (DataRow row in dt.Rows)
                {
                    dgRolEmpleados.Rows.Add(row[0], row[1]);//agrega los datos al datagrid
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