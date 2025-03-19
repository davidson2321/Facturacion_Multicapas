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
    public partial class frmListEmpleados: MaterialForm   
    {
        public frmListEmpleados()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        Acceso_datos Acceso = new Acceso_datos();

        public void llenar_grid()
        {
            dgEmpleados.Rows.Clear();
            string sentencia = "SELECT e.IdEmpleado, e.strNombre, e.NumDocumento, e.StrDireccion, e.StrTelefono, e.StrEmail, r.StrDescripcion, e.DtmIngreso, e.DtmRetiro, e.strDatosAdicionales FROM TBLEMPLEADO e INNER JOIN TBLROLES r ON e.IdRolEmpleado = r.IdRolEmpleado";
            dt = Acceso.EjecutarComandoDatos(sentencia);

            foreach (DataRow row in dt.Rows)
            {
                dgEmpleados.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9]);
            }
        }
        private void frmListEmpleados_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            frmEditarEmpleado Empleado = new frmEditarEmpleado();
            Empleado.IdEmpleado = 0;

            Empleado.ShowDialog();
            llenar_grid();
        }

        private void dgEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            if (dgEmpleados.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dgEmpleados.CurrentRow.Index;
                if (MessageBox.Show($"¿Está seguro de borrar el registro? {dgEmpleados[1, posActual].Value.ToString()}", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;

                int IdEmpleado = Convert.ToInt32(dgEmpleados[0, posActual].Value.ToString());
                string sentencia = $"DELETE FROM TBLEMPLEADO WHERE IdEmpleado = {IdEmpleado}";
                string Mensaje = Acceso.EjecutarComando(sentencia);
                MessageBox.Show(Mensaje);

            }
            if (dgEmpleados.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgEmpleados.CurrentRow.Index;
                frmEditarEmpleado Empleado = new frmEditarEmpleado();
                Empleado.IdEmpleado = int.Parse(dgEmpleados[0, posActual].Value.ToString());
                Empleado.ShowDialog();
            }
            llenar_grid();
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dgEmpleados.Rows.Clear();//limpia el datagrid
                string sentencia = $"select * FROM TBLEMPLEADO WHERE strNombre like '%{txtBuscar.Text}%'";
                dt = Acceso.EjecutarComandoDatos(sentencia);//ejecuta la sentencia
                foreach (DataRow row in dt.Rows)
                {
                    dgEmpleados.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);//agrega los datos al datagrid
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
