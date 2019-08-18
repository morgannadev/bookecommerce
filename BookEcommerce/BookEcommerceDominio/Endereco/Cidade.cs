using BookEcommerceDominio.Geral;

namespace BookEcommerceDominio.Endereco
{
    public class Cidade : EntidadeDominio
    {
        public string NomeCidade { get; set; }
        public string Sigla { get; set; }
        public Estado Estado { get; set; }
    }
}
