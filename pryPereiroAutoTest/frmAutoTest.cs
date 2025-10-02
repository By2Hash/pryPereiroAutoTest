using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace pryPereiroAutoTest
{
    public partial class frmAutoTest : Form
    {
        public frmAutoTest()
        {
            InitializeComponent();
        }

        struct AutoTest
        {
            public int CantTurnos;
            public string Dominio;
            public int MasAntiguo;
            


        }

        

        AutoTest[] vecConsulta = new AutoTest[50];
        int Indice = 0;

        AutoTest Consulta = new AutoTest();


        private void nudAñoFabricacion_ValueChanged(object sender, EventArgs e)
        {


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int mayor = 2050;
        int menor ;
        
        int Cantidad = 0;


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Indice < vecConsulta.Length)
            {
                Consulta.CantTurnos = txtNroTurno.TextLength;
                
                if (txtDominio.Text.Length <= 6)
                {
                    lblCantDominioCon6Caracteres.Text = "";
                }
               else
                {
                    Cantidad++;
                }


                    Consulta.MasAntiguo = (int)nudAñoFabricacion.Value;

                if ((int)nudAñoFabricacion.Value < mayor)
                {
                    menor = (int)nudAñoFabricacion.Value;
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
            lblCantTurno.Text = Indice.ToString();
            lblMasAntiguo.Text = menor.ToString();
            lblCantDominioCon6Caracteres.Text = Cantidad.ToString();








        }

        private void lblCantDominioCon6Caracteres_Click(object sender, EventArgs e)
        {

        }
    }

}