using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _29_frontend_aspnetmvc.Models;
using Microsoft.EntityFrameworkCore;

namespace _29_frontend_aspnetmvc.Context
{
  public class AgendaContext : DbContext
  {
    public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
    {

    }

    public DbSet<Contato> Contatos { get; set; }
  }
}