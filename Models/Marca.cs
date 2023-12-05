using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EbertIan.Models
{
    public class Marca
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        
        [Display(Name = "Descrição")]
        public string Descricao {get; set;}
    }
}