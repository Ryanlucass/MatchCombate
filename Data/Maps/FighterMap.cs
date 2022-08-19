using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Maps
{
    public class FighterMap : IEntityTypeConfiguration<Fighter>
    {
        public void Configure(EntityTypeBuilder<Fighter> builder)
        {
            //id
            builder.Property(c => c.Id)
                .HasColumnName("id");

            //criado_em
            builder.Property(c => c.CreateAt)
                .HasColumnName("criado_em");

            //nome
            builder.Property(c => c.Name)
                .HasColumnName("nome");

            //apelido
            builder.Property(c => c.NickName)
                .HasColumnName("apelido");

            //arte_marcial
            builder.Property(c => c.Martialarts)
                .HasColumnName("arte_marcial");

            //cpf
            builder.Property(c => c.Cpf)
                .HasColumnName("cpf")
                .HasMaxLength(11);

            //peso
            builder.Property(c => c.WeightClass)
                .HasColumnName("peso");
            //id_luta
        }
    }
}


