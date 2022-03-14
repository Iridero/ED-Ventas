namespace ED_Ventas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            FrmVenta f = new FrmVenta();
            f.Show();
        }
    }
}