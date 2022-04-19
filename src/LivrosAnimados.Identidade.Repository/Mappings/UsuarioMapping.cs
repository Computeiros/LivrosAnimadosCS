using LivrosAnimados.Identidade.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LivrosAnimados.Identidade.Repository.Mappings
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Nome)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.HasOne(u => u.Plano)
                .WithMany()
                .HasForeignKey(u => u.PlanoId);

            builder.ToTable("Usuario");
        }
    }
}
