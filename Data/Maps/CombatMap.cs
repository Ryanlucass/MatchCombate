using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Maps
{
    public class FightMap : IEntityTypeConfiguration<Combat>
    {
        public void Configure(EntityTypeBuilder<Combat> builder)
        {
            //Mapeando a tabela do banco 

            builder.ToTable("Combate");

            builder.HasKey(c => c.Id);

            //id
            builder.Property(c => c.Id)
                .HasColumnName("id");

            builder.Property(c => c.FistNickName)
                .HasColumnName("apelidolutfirst");

            builder.Property(c => c.FistNickName)
                .HasColumnName("apelidolutsecond");

            //horario_inicial
            builder.Property(x => x.DateHours)
                .HasColumnName("dataluta");

            //rounds
            builder.Property(x => x.Rounds)
                .HasColumnName("rounds");

            //status_luta
            builder.Property(x => x.StatusFight)
                .HasColumnName("status_luta")
                .HasMaxLength(10);
        }
    }
}


