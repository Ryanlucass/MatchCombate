using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Maps
{
    public class JudgeMap : IEntityTypeConfiguration<Judge>
    {
        public void Configure(EntityTypeBuilder<Judge> builder)
        {

            builder.ToTable("Juiz");

            builder.HasKey(c => c.Id);

            //id
            builder.Property(c => c.Id)
                .HasColumnName("id");

            //nome
            builder.Property(c => c.Name)
                .HasColumnName("nome")
                .HasMaxLength(30);

            //cpf
            builder.Property(c => c.Cpf)
                .HasColumnName("cpf")
                .HasMaxLength(11);

            //dataCriacao
            builder.Property(c => c.CreatedAt)
                .HasColumnName("dataCriacao");

            //telefone
            builder.Property(c => c.Phone)
                .HasColumnName("telefone")
                .HasMaxLength(10);
        }
    }
}


