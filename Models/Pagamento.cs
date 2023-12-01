using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EbertIan.Models
{
    public class Pagamento
    {
        public int Id {get; set;}

        [Display(Name = "Data Limite")]
        public DateOnly DataLimite {get; set;}

        public double Valor {get; set;}
        public bool Pago {get; set;}

        [Display(Name = "Nota de Venda")]
        [ForeignKey("NotaDeVenda")]
        public int NotaDeVendaId {get; set;}
        public NotaDeVenda NotaDeVenda {get; set;}
    }
}