using LivrosAnimados.Identidade.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LivrosAnimados.Identidade.Repository.Mappings
{
    public class PlanoRepository : IEntityTypeConfiguration<Plano>
    {
        public void Configure(EntityTypeBuilder<Plano> builder)
        {
            builder.HasKey(p => p.Id);

            builder.ToTable("Plano");
        }
    }
}
