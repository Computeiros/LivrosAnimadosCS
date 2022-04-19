using LivrosAnimados.Core.Data;
using LivrosAnimados.Identidade.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LivrosAnimados.Identidade.Repository
{
    public class IdentidadeContext : DbContext, IUnitOfWork
    {
        public IdentidadeContext(DbContextOptions<IdentidadeContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(IdentidadeContext).Assembly);
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Plano> Plano { get; set; }

        public async Task<bool> Commit()
        {
            foreach (var entry in ChangeTracker.Entries()
                .Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }

            return await base.SaveChangesAsync() > 0;
        }
    }
}
