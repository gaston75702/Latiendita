using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latiendita.Shared.Entidades
{
    public class Pedido
    {
        public List<ItemCarrito> Items { get; set; } = null!;
        public Cliente Cliente { get; set; } = null!;
        public MetodoPago MetodoPago { get; set; }

        public decimal Total => CalcularTotal();
        private decimal CalcularTotal()
        {
            decimal total = 0;

            foreach (var item in Items)
            {
                total += item.Cantidad * item.Producto.Precio;
            }

            return total;

        }

    }
}