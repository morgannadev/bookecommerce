using BookEcommerceDominio.Geral;

namespace BookEcommerceDominio.Cliente
{
    public class Telefone : EntidadeDominio
    {
        public string Ddd { get; set; }
        public string Numero { get; set; }
        public TipoTelefone TipoTelefone { get; set; }
    }
}
