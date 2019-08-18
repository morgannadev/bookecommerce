using BookEcommerceDominio.Geral;
using System.Collections.Generic;

namespace BookEcommerceDominio.Venda
{
    public class CarrinhoCompra : EntidadeDominio
    {
        public IEnumerable<Item> Itens { get; set; }
        public Frete Frete { get; set; }
    }
}
