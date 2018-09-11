using Solid.SRP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.SRP.Domain.Interfaces.Repository
{
    public interface IUsuarioRepository
    {
        void Inserir(Usuario usuario);
        List<Usuario> ObterTodos();
        void DeletarUsuario(Usuario usuario);
    }
}
