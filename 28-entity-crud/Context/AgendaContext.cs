using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _28_entity_crud.Entities;
using Microsoft.EntityFrameworkCore;

namespace _28_entity_crud.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) :
            base(options)
        {
        }

        public DbSet<Contato> Contatos { get; set; }
    }
}
