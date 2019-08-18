using BookEcommerceDominio.FormaPagto;
using BookEcommerceDominio.Geral;
using System.Collections.Generic;

namespace BookEcommerceDominio.Venda
{
    public class Troca : EntidadeDominio
    {
        public IEnumerable<StatusTroca> Status { get; set; }
        public IEnumerable<CupomTroca> Cupons { get; set; }
        public Item Item { get; set; }
    }
}
