using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latiendita.Shared.DTOs
{
    public class PedidoDTO
    {
        public List<ItemCarritoDTO> Items { get; set; }
        public ClienteDTO Cliente { get; set; }
        public string MetodoPago { get; set; }
        // Otras propiedades según sea necesario
    }
}
