using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EbertIan.Models
{
    public class PagamentoComCartao : TipoDePagamento
    {
        public int Id {get; set;}

        [Display(Name = "Nome do Cobrado")]
        public string NomeDoCobrado {get; set;}
        [Display(Name = "Informações Adicionais")]
        public string InformacoesAdicionais {get; set;}
        public ICollection<NotaDeVenda>? NotasDeVendas {get; set;}
        [Display(Name = "Número do Cartão")]
        public String NumeroDoCartao {get; set;}
        public String Bandeira {get; set;}
    }
}