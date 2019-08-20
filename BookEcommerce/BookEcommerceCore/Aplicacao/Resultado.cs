using BookEcommerceDominio.Geral;
using System.Collections.Generic;

namespace BookEcommerceCore.Aplicacao
{
    public class Resultado : EntidadeAplicacao
    {
        public Resultado()
        {
            Entidades = new List<IEntidadeDominio>();
            Mensagem = string.Empty;
        }
        public string Mensagem { get; set; }
        public List<IEntidadeDominio> Entidades { get; set; }
    }
}
