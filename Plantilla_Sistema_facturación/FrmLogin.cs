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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string Respuesta = "";
            if (TxtUsuario.Text != "" && TxtPasword.Text != string.Empty)
            {
                Acceso_datos Acceso = new Acceso_datos();
                Respuesta = Acceso.ValidarUsuario(TxtUsuario.Text, TxtPasword.Text);
                if (Respuesta != "")
                {
                    MessageBox.Show("Bienvenido : " + Respuesta);
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
    }
}
