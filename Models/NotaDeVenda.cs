using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EbertIan.Models
{
    public class NotaDeVenda
    {
        public int Id {get; set;}
        public DateOnly Data {get; set;}
        public bool Tipo {get; set;}

        [ForeignKey("Cliente")]
        public int ClienteId {get; set;}
        public Cliente Cliente {get; set;}

        [ForeignKey("Vendedor")]
        public int VendedorId {get; set;}
        public Vendedor Vendedor {get; set;}

        [ForeignKey("Transportadora")]
        public int TransportadoraId {get; set;}
        public Transportadora? Transportadora {get; set;}

        public ICollection<Pagamento> Pagamentos {get; set;}

        [Display(Name = "Pagamento com Cheque")]
        [ForeignKey("PagamentoComCheque")]
        public int PagamentoComChequeId {get; set;}
        public PagamentoComCheque? PagamentoComCheque {get; set;}

        [Display(Name = "Pagamento com Cartão")]
        [ForeignKey("PagamentoComCartao")]
        public int PagamentoComCartaoId {get; set;}
        public PagamentoComCartao? PagamentoComCartao {get; set;}

        public ICollection<Item> Itens {get; set;}
    }
}