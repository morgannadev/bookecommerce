using System;

namespace BookEcommerceDominio.FormaPagto
{
    public class Cupom : FormaPagamento
    {
        public double Valor { get; set; }
        public DateTime DataValidade { get; set; }
    }
}
