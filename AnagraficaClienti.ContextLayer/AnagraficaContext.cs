using AnagraficaClienti.ContextLayer.Configuration;
using AnagraficaClienti.EntitiesLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace AnagraficaClienti.ContextLayer
{
    public class AnagraficaContext : DbContext
    {
        public AnagraficaContext() : base() { }
        public AnagraficaContext(DbContextOptions<AnagraficaContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=WINAPWDCOSSNWJZ; Database=Anagrafica;
                            Integrated Security=true");
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Client>(new ClientConfiguration());
            modelBuilder.ApplyConfiguration<Order>(new OrderConfiguration());
        }
    }
}
