using Microsoft.EntityFrameworkCore;
using webApi_demo.models;

namespace webApi_demo.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions <AppDbContext> options)
        :base (options)
        {}
        public DbSet<Agenda>Agendas {get;set;}
        public DbSet<Contato> Contatos { get; set; }
    }
}