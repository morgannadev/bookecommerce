using BookEcommerceDominio.Geral;

namespace BookEcommerceDominio.Endereco
{
    public class Estado : EntidadeDominio
    {
        public string NomeEstado { get; set; }
        public string Sigla { get; set; }
        public Pais Pais { get; set; }
    }
}
