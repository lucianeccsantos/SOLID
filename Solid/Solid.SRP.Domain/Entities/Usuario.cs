using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.SRP.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }

        public Usuario(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Ativo = false;
        }

        public void Atualizar(string nome)
        {
            Nome = nome;
        }

        public void AtivarUsuario()
        {
            Ativo = true;
        }

        public void RedefinirSenha()
        {
            Senha = "NovaSenha*1234";
        }
    }
}
