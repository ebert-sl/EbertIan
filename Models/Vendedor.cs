using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EbertIan.Models
{
    public class Vendedor
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public ICollection<NotaDeVenda>? NotasDeVendas {get; set;}
    }
}