using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_Ventas
{
    public class Venta
    {
        public event AlActualizarLista DetalleAgregado;

        public DateTime Fecha { get; set; }
        private List<Detalle> detalles;

        public List<Detalle> Detalles
        {
            get { return detalles; }
            
        }


        public decimal Total
        {
            get {
                decimal total = 0;
                foreach (var detalle in detalles)
                {
                    total += detalle.Monto;
                }
                return total; 
            }
        }

        public void Agregar(string descripción, 
            decimal precio, float cantidad)
        {
            // Aquí validamos antes
            Detalle nuevo = new Detalle()
            {
                Descripción = descripción,
                Precio = precio,
                Cantidad = cantidad
            };
            if (detalles==null)
            {
                detalles = new List<Detalle>();
            }
            detalles.Add(nuevo);
            DetalleAgregado?.Invoke(nuevo);
        }
    }
}
