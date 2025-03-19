using System.Windows.Forms;

namespace Plantilla_Sistema_facturación
{
    internal class FmrPrincipal : Form
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FmrPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "FmrPrincipal";
            this.Load += new System.EventHandler(this.FmrPrincipal_Load);
            this.ResumeLayout(false);

        }

        private void FmrPrincipal_Load(object sender, System.EventArgs e)
        {

        }
    }
}