using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalEvanyeline.Models
{
    public class Autores
    {

        [Key]
        public int idAutor { get; set; }
        public string nombre_autor { get; set; }
        public string apellido_autor { get; set; }
        public int edad { get; set; }
        public string estado { get; set; }
        public string nacionalidad { get; set; }
        public DateTime nacimiento { get; set; }
        public DateTime muerte { get; set; }
        public int libros_escritos { get; set; }

    }
}


