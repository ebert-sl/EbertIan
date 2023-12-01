using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EbertIan.Models
{
    public interface TipoDePagamento
    {
        int Id {get; set;}
        string NomeDoCobrado {get; set;}
        string InformacoesAdicionais {get; set;}
        ICollection<NotaDeVenda>? NotasDeVendas {get; set;}
    }
}