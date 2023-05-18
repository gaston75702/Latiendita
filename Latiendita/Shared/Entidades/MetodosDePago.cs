using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

public enum MetodoPago
{
    [Display(Name = "Efectivo")]
    Efectivo,

    [Display(Name = "Tarjeta de Crédito")]
    TarjetaCredito,

    [Display(Name = "Transferencia Bancaria")]
    TransferenciaBancaria,

    // Agrega más métodos de pago si es necesario
}

