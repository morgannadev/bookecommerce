using System;

namespace BookEcommerceDominio.Log
{
    public class ControleLog
    {
        public DateTime DataOcorrido { get; set; }
        public TimeSpan HoraOcorrido { get; set; }
        public Operacao Operacao { get; set; }
    }
}
