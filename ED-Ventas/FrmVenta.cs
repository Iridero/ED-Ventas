using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED_Ventas
{
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
        }

        private Venta ventaActual;

        public Venta VentaActual
        {
            get { return ventaActual; }
            set { ventaActual = value; }
        }


        private void FrmVenta_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ventaActual==null)
            {
                ventaActual = new Venta();
                ventaActual.DetalleAgregado += VentaActual_DetalleAgregado;
            }
            ventaActual.Agregar(txtDescripcion.Text,
                nmrPrecio.Value, (float)nmrCantidad.Value);
        }

        private void VentaActual_DetalleAgregado(Detalle detalle)
        {
            MessageBox.Show(detalle.ToString());
        }
    }
}
