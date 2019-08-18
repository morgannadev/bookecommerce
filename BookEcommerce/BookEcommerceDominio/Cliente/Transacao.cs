using BookEcommerceDominio.Geral;

namespace BookEcommerceDominio.Cliente
{
    public class Transacao : EntidadeDominio
    {
        public string DescricaoTransacao { get; set; }
        public CategoriaTransacao Categoria { get; set; }
    }
}
