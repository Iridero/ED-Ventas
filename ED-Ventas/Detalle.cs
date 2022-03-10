using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_Ventas
{
    public class Detalle
    {
        public string Descripción { get; set; }
        public decimal Precio { get; set; }
        public float Cantidad { get; set; }
        public decimal Monto
        {
            get
            {
                return Precio * (decimal)Cantidad;
            }
        }

        public override string ToString()
        {
            return $"Desc:{Descripción}, Precio:{Precio}, Cant.:{Cantidad}, Total:{Monto}";
        }
    }
}
