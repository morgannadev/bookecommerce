using BookEcommerceDominio.Geral;
using BookEcommerceDominio.Log;
using System.Collections.Generic;

namespace BookEcommerceDominio.Livro
{
    public class Estoque : EntidadeDominio
    {
        public int Quantidade { get; set; }
        public IEnumerable<Livro> Livros { get; set; }
        public ControleLog Log { get; set; }
    }
}
