using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_Ventas
{
    public class RegistroDeVentas
    {
        private List<Venta> ventas;

        public List<Venta> Ventas
        {
            get { return ventas; }
            //set { ventas = value; }
        }
        public void AgregarVenta(Venta nueva)
        {
            if (ventas==null)
            {
                ventas = new List<Venta>();
            }
            ventas.Add(nueva);
        }
    }
}
