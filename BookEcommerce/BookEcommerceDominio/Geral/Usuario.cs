namespace BookEcommerceDominio.Geral
{
    public class Usuario : EntidadeDominio
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public Perfil Perfil { get; set; }
    }
}
