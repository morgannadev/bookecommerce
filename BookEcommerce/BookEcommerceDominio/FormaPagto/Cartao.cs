namespace BookEcommerceDominio.FormaPagto
{
    public class Cartao : FormaPagamento
    {
        public bool Preferencial { get; set; }
        public string Numero { get; set; }
        public string NomeImpresso { get; set; }
        public Bandeira Bandeira { get; set; }
    }
}
