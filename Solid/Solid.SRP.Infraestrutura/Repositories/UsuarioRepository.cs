using System;
using System.Collections.Generic;
using System.Text;
using Solid.SRP.Domain;
using Solid.SRP.Domain.Entities;
using Solid.SRP.Domain.Interfaces.Repository;

namespace Solid.SRP.Infra.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        DataContext _db = new DataContext();
        public void DeletarUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void Inserir(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
