using pryFerreyraInventario;

namespace pryFerreyraActSemana2
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void cbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            frmGestion frm = new();
            frm.Show();
            this.Close();
        }

        private void gbMain_Enter(object sender, EventArgs e)
        {

        }
    }
}
