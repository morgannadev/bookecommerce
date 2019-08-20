using BookEcommerceCore.Core;
using BookEcommerceCore.Utils;
using BookEcommerceDominio.Geral;
using System;
using System.Collections.Generic;

namespace BookEcommerceCore.DAO.Base
{
    public class AbstractDAO : ConexaoDB, IDAO
    {
        public void Alterar(EntidadeDominio entidade)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EntidadeDominio> Consultar(IEntidadeDominio entidade)
        {
            throw new NotImplementedException();
        }

        public void Excluir(EntidadeDominio entidade)
        {
            throw new NotImplementedException();
        }

        public void Salvar(EntidadeDominio entidade)
        {
            throw new NotImplementedException();
        }
    }
}
