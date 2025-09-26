using System.Windows.Forms;

namespace pryPereiroAutoTest
{
    public partial class frmAutoTest : Form
    {
        public frmAutoTest()
        {
            InitializeComponent();
        }

        int[] vecTurno = new int[50];



        private void nudAñoFabricacion_ValueChanged(object sender, EventArgs e)
        {


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int Indice = 0;
        string CantDominio;
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Indice < vecTurno.Length)
            {
                vecTurno[Indice] = Convert.ToInt32(txtNroTurno.Text);

                if (txtDominio.Text.Length == 6)
                {
                    CantDominio = txtDominio.Text;
                }

            }

            Indice++;
            txtNroTurno.Text = "";
            txtDominio.Text = "";
            nudAñoFabricacion.Value = 2000;
            txtTitular.Text = "";



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

        private void txtNroTurno_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNroTurno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNroTurno_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAutoTest_Load(object sender, EventArgs e)
        {

        }

        private void txtCantidadTurnos_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpConsulta_Enter(object sender, EventArgs e)
        {

        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //En la etiqueta muestra el indice, no hace falta poner vecTurno[Indice]
            lblCantTurno.Text = Indice.ToString();

            //Año mas antiguo

            // mostrar el resultado


            lblCantDominioCon6Caracteres.Text = CantDominio;




        }

        private void lblCantDominioCon6Caracteres_Click(object sender, EventArgs e)
        {

        }
    }

}