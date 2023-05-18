using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latiendita.Shared.DTOs
{
    public class ItemCarritoDTO
    {
        public ProductoDTO Producto { get; set; }
        public int Cantidad { get; set; }
        // Otras propiedades según sea necesario
    }
}
