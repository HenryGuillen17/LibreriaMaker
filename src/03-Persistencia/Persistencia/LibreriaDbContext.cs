using System;
using Microsoft.EntityFrameworkCore;
using Modelos.Dao;
using Persistencia.Config;

namespace Persistencia
{
    public class LibreriaDbContext : DbContext
    {
        public LibreriaDbContext(
            DbContextOptions<LibreriaDbContext> options
        ) : base(options)
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
            ChangeTracker.LazyLoadingEnabled = true;
        }

        public DbSet<Libro> Libro { get; set; }
        public DbSet<Editorial> Editorial { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            ModelConfig(builder);
        }

        private void ModelConfig(ModelBuilder modelBuilder)
        {
            new LibroConfig(modelBuilder.Entity<Libro>());
            new EditorialConfig(modelBuilder.Entity<Editorial>());
        }
    }
}
