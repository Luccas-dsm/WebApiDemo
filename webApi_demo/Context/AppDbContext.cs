using webApi_demo.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
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