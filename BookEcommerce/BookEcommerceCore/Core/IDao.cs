using BookEcommerceDominio.Geral;
using System.Collections.Generic;

namespace BookEcommerceCore.Core
{
    public interface IDao
    {
        void Salvar(EntidadeDominio entidade);
        void Alterar(EntidadeDominio entidade);
        void Excluir(EntidadeDominio entidade);
        IEnumerable<EntidadeDominio> Consultar(IEntidadeDominio entidade);
    }
}
