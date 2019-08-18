using BookEcommerceDominio.Geral;
using System;

namespace BookEcommerceDominio.Venda
{
    public class ParametrizacaoTempo : EntidadeDominio
    {
        public TimeSpan Tempo { get; set; }
    }
}
