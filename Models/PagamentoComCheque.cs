using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EbertIan.Models
{
    public class PagamentoComCheque : TipoDePagamento
    {
        [Display(Name = "Nome do Banco")]
        public string NomeDoBanco {get; set;}
    }
}