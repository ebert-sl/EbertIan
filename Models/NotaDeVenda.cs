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
        
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }
        public StatusNotaDeVenda Status {get; set;}

        [Display(Name = "Cliente")]
        public int ClienteId {get; set;}
        public Cliente? Cliente {get; set;}

        [Display(Name = "Vendedor")]
        public int VendedorId {get; set;}
        public Vendedor? Vendedor {get; set;}

        [Display(Name = "Transportadora")]
        public int TransportadoraId {get; set;}
        public Transportadora? Transportadora {get; set;}

        [Display(Name = "Tipo De Pagamento")]
        public int TipoDePagamentoId {get; set;}
        public TipoDePagamento? TipoDePagamento {get; set;}
    }
}