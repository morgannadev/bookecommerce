using System;

namespace BookEcommerceDominio.Geral
{
    public class EntidadeDominio : IEntidadeDominio
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
