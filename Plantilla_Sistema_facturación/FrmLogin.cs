using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capa_LogicaDeNegocios;

namespace Plantilla_Sistema_facturación
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click_2(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

      

        private void btnValidar_Click(object sender, EventArgs e)
        {
     
            if (TxtUsuario.Text != "" && TxtPasword.Text != string.Empty)
            {
               Validar_usuario Obj_validar = new Validar_usuario();

                Obj_validar.C_StrUsuario = TxtUsuario.Text;
                Obj_validar.C_StrClave = TxtPasword.Text;
                Obj_validar.ValidarUsuario();
                if (Obj_validar.C_IdEmpleado !=0)
                {
                    MessageBox.Show("Datos de verificacion Validos" );
                    FrmPrincipal frmppal = new FrmPrincipal();
                    this.Hide();
                    frmppal.Show();
                }
                else
                {
                    MessageBox.Show("USUARIOS Y CLAVE NO ENCONTRADO");
                    TxtUsuario.Text = "";
                    TxtUsuario.Focus();
                    TxtPasword.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Debes ingresar un usuario y una nueva clave");
            }
        }

        private void TxtUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
