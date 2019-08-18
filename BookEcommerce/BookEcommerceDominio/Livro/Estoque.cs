using BookEcommerceDominio.Geral;
using System.Collections.Generic;

namespace BookEcommerceDominio.Livro
{
    public class Estoque : EntidadeDominio
    {
        public int Quantidade { get; set; }
        public IEnumerable<Livro> Livros { get; set; }
    }
}
