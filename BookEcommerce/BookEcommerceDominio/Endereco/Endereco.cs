using BookEcommerceDominio.Geral;

namespace BookEcommerceDominio.Endereco
{
    public class Endereco : EntidadeDominio
    {
        public string NomeEndereco { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }
        public string Observacoes { get; set; }
        public Bairro Bairro { get; set; }
        public TipoLogradouro TipoLogradouro { get; set; }
        public TipoResidencia TipoResidencia { get; set; }
    }
}
