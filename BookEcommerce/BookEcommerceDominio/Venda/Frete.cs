using BookEcommerceDominio.Endereco;
using BookEcommerceDominio.Geral;

namespace BookEcommerceDominio.Venda
{
    public class Frete : EntidadeDominio
    {
        public EnderecoEntrega Endereco { get; set; }
        public double Valor { get; set; }
    }
}
