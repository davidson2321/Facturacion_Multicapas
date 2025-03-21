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
    public partial class frmListaRoles : MaterialForm
    {
        public frmListaRoles()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        Cls_Roles rol = new Cls_Roles();

        public void llenar_grid()
        {
            dgRolEmpleados.Rows.Clear();
            dt = rol.ConsultarRol();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    dgRolEmpleados.Rows.Add(row[0].ToString(), row[1].ToString());
                }
            }
            else {
                MessageBox.Show("No hay datos para mostrar");
            }

            

        }
        private void frmListRolEmpleados_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            frmRoles rolEmpleado = new frmRoles();
            rolEmpleado.IdRol = 0;

            rolEmpleado.ShowDialog();
            llenar_grid();
        }
        private void dgRolEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgRolEmpleados.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dgRolEmpleados.CurrentRow.Index;
                if (MessageBox.Show($"¿Está seguro de borrar el registro? {dgRolEmpleados[1, posActual].Value.ToString()}", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;

                int IdRol = Convert.ToInt32(dgRolEmpleados[0, posActual].Value.ToString());
                
                string Mensaje = rol.Eliminar_Rol(IdRol);
                MessageBox.Show(Mensaje);

            }
            if (dgRolEmpleados.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgRolEmpleados.CurrentRow.Index;
                frmRoles rolEmpleado = new frmRoles();
                rolEmpleado.IdRol = int.Parse(dgRolEmpleados[0, posActual].Value.ToString());
                rolEmpleado.ShowDialog();
            }
            llenar_grid();
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dgRolEmpleados.Rows.Clear();//limpia el datagrid
                
                dt = rol.Filtrar_Rol(txtBuscar.Text);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        dgRolEmpleados.Rows.Add(row[0].ToString(), row[1].ToString());//agrega los datos al datagrid
                        
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
                llenar_grid();
            }
            txtBuscar.Text = "";//limpia el textbox
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}