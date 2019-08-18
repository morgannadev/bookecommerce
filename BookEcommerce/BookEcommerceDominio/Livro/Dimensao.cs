using BookEcommerceDominio.Geral;

namespace BookEcommerceDominio.Livro
{
    public class Dimensao : EntidadeDominio
    {
        public double Altura { get; set; }
        public double Largura { get; set; }
        public double Profundidade { get; set; }
        public double Peso { get; set; }
    }
}
