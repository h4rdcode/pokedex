﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using pokedex.Models;

#nullable disable

namespace pokedex.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("pokedex.Models.Jogador", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("estado")
                        .HasColumnType("int");

                    b.Property<int>("idade")
                        .HasColumnType("int");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("jogadores");
                });

            modelBuilder.Entity("pokedex.Models.Pokedex", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int?>("jogadorid")
                        .HasColumnType("int");

                    b.Property<int?>("pokemonid")
                        .HasColumnType("int");

                    b.Property<float>("quantidade")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.HasIndex("jogadorid");

                    b.HasIndex("pokemonid");

                    b.ToTable("pokedexs");
                });

            modelBuilder.Entity("pokedex.Models.Pokemon", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<float>("compra")
                        .HasColumnType("real");

                    b.Property<string>("tipo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("venda")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.ToTable("pokemons");
                });

            modelBuilder.Entity("pokedex.Models.Transacao", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("data")
                        .HasColumnType("datetime2");

                    b.Property<int>("operacao")
                        .HasColumnType("int");

                    b.Property<int?>("pokedexid")
                        .HasColumnType("int");

                    b.Property<float>("quantidade")
                        .HasColumnType("real");

                    b.Property<float>("valor")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.HasIndex("pokedexid");

                    b.ToTable("transacoes");
                });

            modelBuilder.Entity("pokedex.Models.Pokedex", b =>
                {
                    b.HasOne("pokedex.Models.Jogador", "jogador")
                        .WithMany("pokedexs")
                        .HasForeignKey("jogadorid");

                    b.HasOne("pokedex.Models.Pokemon", "pokemon")
                        .WithMany("pokedex")
                        .HasForeignKey("pokemonid");

                    b.Navigation("jogador");

                    b.Navigation("pokemon");
                });

            modelBuilder.Entity("pokedex.Models.Transacao", b =>
                {
                    b.HasOne("pokedex.Models.Pokedex", "pokedex")
                        .WithMany("transacoes")
                        .HasForeignKey("pokedexid");

                    b.Navigation("pokedex");
                });

            modelBuilder.Entity("pokedex.Models.Jogador", b =>
                {
                    b.Navigation("pokedexs");
                });

            modelBuilder.Entity("pokedex.Models.Pokedex", b =>
                {
                    b.Navigation("transacoes");
                });

            modelBuilder.Entity("pokedex.Models.Pokemon", b =>
                {
                    b.Navigation("pokedex");
                });
#pragma warning restore 612, 618
        }
    }
}
