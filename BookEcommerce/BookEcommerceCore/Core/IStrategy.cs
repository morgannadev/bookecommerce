using BookEcommerceDominio.Geral;

namespace BookEcommerceCore.Core
{
    public interface IStrategy
    {
        string Processar(IEntidadeDominio entidade);
    }
}
