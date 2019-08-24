using BookEcommerceDominio.Geral;
using System;

namespace BookEcommerceDominio.Log
{
    public class ControleLog : EntidadeDominio
    {
        public DateTime DataHoraOcorrido { get; set; }
        public Operacao Operacao { get; set; }
    }
}
