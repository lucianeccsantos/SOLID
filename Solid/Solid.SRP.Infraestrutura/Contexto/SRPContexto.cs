using Solid.SRP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Solid.SRP.Infra.Data.Contexto
{
    public class SRPContexto
    {
    }

    public DbSet<Usuario> Usuarios { get; set; }
}

