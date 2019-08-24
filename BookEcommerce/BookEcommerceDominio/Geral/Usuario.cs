using BookEcommerceDominio.Constantes;
using System.ComponentModel.DataAnnotations;

namespace BookEcommerceDominio.Geral
{
    public class Usuario : EntidadeDominio
    {
        public string LoginUsuario { get; set; }

        [Required]
        [MinLength(8, ErrorMessage = (Mensagens.QUANTIDADE_INCORRETA_DE_CARACTERES))]
        public string Senha { get; set; }
        public Perfil Perfil { get; set; }
    }
}
