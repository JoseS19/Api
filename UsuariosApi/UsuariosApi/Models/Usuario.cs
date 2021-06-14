using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UsuariosApi.Models
{
    public class Usuario
    {
        [Key]
        public int id_usuario { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public string num_tel { get; set; }
        [Required]
        public string pass { get; set; }
    }
}
