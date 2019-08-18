using BookEcommerceDominio.Geral;

namespace BookEcommerceDominio.Livro
{
    public class RegistroMovimentacao : EntidadeDominio
    {
        public StatusLivro Status { get; set; }
        public string Justificativa { get; set; }
    }
}
