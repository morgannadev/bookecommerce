using BookEcommerceDominio.Geral;
using BookEcommerceDominio.Log;

namespace BookEcommerceDominio.Venda
{
    public class Pedido : EntidadeDominio
    {
        public CarrinhoCompra CarrinhoCompra { get; set; }
        public StatusPedido Status { get; set; }
        public ControleLog Log { get; set; }
    }
}
