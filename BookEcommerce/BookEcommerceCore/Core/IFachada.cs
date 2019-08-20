using BookEcommerceCore.Aplicacao;
using BookEcommerceDominio.Geral;

namespace BookEcommerceCore.Core
{
    public interface IFachada
    {
        Resultado Salvar(EntidadeDominio entidade);
        Resultado Alterar(EntidadeDominio entidade);
        Resultado Excluir(EntidadeDominio entidade);
        Resultado Consultar(IEntidadeDominio entidade);
    }
}
