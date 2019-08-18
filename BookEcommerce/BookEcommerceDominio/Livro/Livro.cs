using BookEcommerceDominio.Geral;
using System.Collections;
using System.Collections.Generic;

namespace BookEcommerceDominio.Livro
{
    public class Livro : EntidadeDominio
    {
        public string Titulo { get; set; }
        public string Isbn { get; set; }
        public int NumeroPaginas { get; set; }
        public string Sinopse { get; set; }
        public string CodigoBarras { get; set; }
        public Editora Editora { get; set; }
        public Dimensao Dimensao { get; set; }
        public IEnumerable<GrupoPrecificacao> GruposPrecificacao { get; set; }
        public IEnumerable<RegistroMovimentacao> Registros { get; set; }
        public IEnumerable<Valor> Valores { get; set; }
        public IEnumerable<Autor> Autores { get; set; }
        public IEnumerable<CategoriaLivro> Categorias { get; set; }
    }
}
