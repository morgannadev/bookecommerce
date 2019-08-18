using BookEcommerceDominio.Geral;
using BookEcommerceDominio.Log;

namespace BookEcommerceDominio.Livro
{
    public class RegistroMovimentacao : EntidadeDominio
    {
        public StatusLivro Status { get; set; }
        public string Justificativa { get; set; }
        public ControleLog Log { get; set; }
    }
}
