using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace coreApiSeed.Models
{
    public class Cliente
    {
         [Key]
        public int ClienteId { get; set; }

        [MaxLength( 50, ErrorMessage ="o nome deve conter no máximo 50 caracteres")]
        public string nome { get; set; }

        [MaxLength(50, ErrorMessage = "o email deve conter no máximo 100 caracteres")]
        public string email { get; set; }

        public bool ativo { get; set; }
    }
}
