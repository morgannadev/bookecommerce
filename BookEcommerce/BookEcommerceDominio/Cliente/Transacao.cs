using BookEcommerceDominio.Geral;
using BookEcommerceDominio.Log;

namespace BookEcommerceDominio.Cliente
{
    public class Transacao : EntidadeDominio
    {
        public string DescricaoTransacao { get; set; }
        public CategoriaTransacao Categoria { get; set; }
        public ControleLog Log { get; set; }
    }
}
