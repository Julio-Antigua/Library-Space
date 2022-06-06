using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalEvanyeline.Models
{
    public class UserInfo
    {
        [Key]
        [Required]
        public string Email { get; set; }
        [Required]
        public string Passoword { get; set; }


    }
}
