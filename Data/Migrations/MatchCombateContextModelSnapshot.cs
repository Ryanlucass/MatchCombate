﻿// <auto-generated />
using System;
using Data.DbCotext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(MatchCombateContext))]
    partial class MatchCombateContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Model.Fight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Box")
                        .HasMaxLength(23)
                        .HasColumnType("nvarchar(23)")
                        .HasColumnName("Octogono");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2")
                        .HasColumnName("Data");

                    b.Property<string>("Locale")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Local");

                    b.HasKey("Id");

                    b.ToTable("Lutas");
                });

            modelBuilder.Entity("Domain.Model.Fighter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)")
                        .HasColumnName("Cpf");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("Criado_em");

                    b.Property<int?>("FightId")
                        .HasColumnType("int")
                        .HasColumnName("LutaId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Nome");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Apelido");

                    b.Property<int>("WeightClass")
                        .HasMaxLength(4)
                        .HasColumnType("int")
                        .HasColumnName("Peso");

                    b.HasKey("Id");

                    b.HasIndex("Cpf")
                        .IsUnique();

                    b.HasIndex("FightId");

                    b.ToTable("Lutador");
                });

            modelBuilder.Entity("Domain.Model.Fighter", b =>
                {
                    b.HasOne("Domain.Model.Fight", "Fight")
                        .WithMany("Fighters")
                        .HasForeignKey("FightId");

                    b.Navigation("Fight");
                });

            modelBuilder.Entity("Domain.Model.Fight", b =>
                {
                    b.Navigation("Fighters");
                });
#pragma warning restore 612, 618
        }
    }
}
