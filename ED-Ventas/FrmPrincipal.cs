namespace ED_Ventas
{
    public partial class FrmPrincipal : Form
    {
        RegistroDeVentas registro=new RegistroDeVentas();
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            FrmVenta f = new FrmVenta();
            f.VentaRealizada += F_VentaRealizada;
            f.Show();
        }

        private void F_VentaRealizada(Venta venta)
        {
            registro.AgregarVenta(venta);
            dtgVentas.DataSource = registro.Ventas;
        }
    }
}