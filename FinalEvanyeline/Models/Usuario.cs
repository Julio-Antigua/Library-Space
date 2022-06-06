using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalEvanyeline.Models
{
    public class Usuario
    {
        [Key]
        public int idUsuario { get; set; }
        public string nombre { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }

        public string contrasena { get; set; }
    }
}
