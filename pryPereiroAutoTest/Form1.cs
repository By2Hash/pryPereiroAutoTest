using System.Windows.Forms;

namespace pryPereiroAutoTest
{
    public partial class frmAutoTest : Form
    {
        public frmAutoTest()
        {
            InitializeComponent();
        }

        private void nudAñoFabricacion_ValueChanged(object sender, EventArgs e)
        {


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {



        }

        private void txtTitular_TextChanged(object sender, EventArgs e)
        {
            if (txtTitular.Text != "")
            {
                btnRegistrar.Enabled = true;
               
            }
            else
            {
                btnRegistrar.Enabled = false;
            }
        }

        private void txtDominio_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNroTurno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
