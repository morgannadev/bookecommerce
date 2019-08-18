using BookEcommerceDominio.Geral;

namespace BookEcommerceDominio.Endereco
{
    public class Bairro : EntidadeDominio
    {
        public string NomeBairro { get; set; }
        public Cidade Cidade { get; set; }
    }
}
