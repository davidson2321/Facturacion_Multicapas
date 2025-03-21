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
using Capa_LogicaDeNegocios;

namespace Plantilla_Sistema_facturación
{
    public partial class frmListEmpleados: MaterialForm   
    {
        public frmListEmpleados()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        Cls_Empleados empleado = new Cls_Empleados();

        public void llenar_grid()
        {
            dgEmpleados.Rows.Clear();
            dt = empleado.ConsultaEmpleado(); // Changed to match the method signature

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    dgEmpleados.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString());
                }
            }
            else
            {
                MessageBox.Show("No hay datos para mostrar");
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
                if (MessageBox.Show($"¿Está seguro de borrar el registro? {dgEmpleados[1, posActual].Value.ToString()}", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int IdEmpleado = Convert.ToInt32(dgEmpleados[0, posActual].Value.ToString());
                    string Mensaje = empleado.Eliminar_Empleado(IdEmpleado);
                    MessageBox.Show(Mensaje);
                }
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
                
                dt = empleado.Filtrar_Empleado(txtBuscar.Text);//llama al metodo de la clase empleado
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        dgEmpleados.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString());//agrega los datos al datagrid

                    }
                }
                else
                {
                    MessageBox.Show("No hay datos para mostrar");
                    llenar_grid();//
                }


            }
            else
            {
                llenar_grid();//si no ingresaron valor a buscar llena el datagrid con todos los datos
            }
            txtBuscar.Text = "";//limpia el campo de busqueda
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
