using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalEvanyeline.Models
{
    public class Libros
    {
        [Key]
        public int idlibro { get; set; }
        public string nombre { get; set; }
        public int autor { get; set; }
        public string genero { get; set; }
        public decimal precio { get; set; }
        public string editorial { get; set; }
        public int paginas { get; set; }
        public int Cant_disponible { get; set; }

    }
}
