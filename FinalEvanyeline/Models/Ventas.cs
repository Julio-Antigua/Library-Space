using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalEvanyeline.Models
{
    public class Ventas
    {
        [Key]
        public int idVentas { get; set; }
        public DateTime ventas_fecha { get; set; }
        public decimal total { get; set; }
        public int cantidad { get; set; }
        public string nombreCliente { get; set; }
        public int idlibro { get; set; }
    }
}

