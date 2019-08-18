using BookEcommerceDominio.Endereco;
using BookEcommerceDominio.Geral;
using System;
using System.Collections.Generic;

namespace BookEcommerceDominio.Cliente
{
    public class Cliente : Pessoa
    {
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public Genero Genero { get; set; }
        public StatusCliente Status { get; set; }
        public Usuario Usuario { get; set; }
        public IEnumerable<Transacao> Transacoes { get; set; }
        public IEnumerable<EnderecoCobranca> EnderecosCobranca { get; set; }
        public IEnumerable<EnderecoEntrega> EnderecosEntrega { get; set; }
        public IEnumerable<Telefone> Telefones { get; set; }
    }
}
