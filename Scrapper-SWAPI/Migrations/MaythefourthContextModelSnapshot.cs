﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Scrapper_SWAPI.Models;

#nullable disable

namespace Scrapper_SWAPI.Migrations
{
    [DbContext(typeof(MaythefourthContext))]
    partial class MaythefourthContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("FilmeNavesEstelare", b =>
                {
                    b.Property<int>("FilmesId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NavesId")
                        .HasColumnType("INTEGER");

                    b.HasKey("FilmesId", "NavesId");

                    b.HasIndex(new[] { "NavesId" }, "IX_FilmeNavesEstelares_NavesId");

                    b.ToTable("FilmeNavesEstelares", (string)null);
                });

            modelBuilder.Entity("FilmePersonagem", b =>
                {
                    b.Property<int>("FilmesId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PersonagensId")
                        .HasColumnType("INTEGER");

                    b.HasKey("FilmesId", "PersonagensId");

                    b.HasIndex(new[] { "PersonagensId" }, "IX_FilmePersonagem_PersonagensId");

                    b.ToTable("FilmePersonagem", (string)null);
                });

            modelBuilder.Entity("FilmePlanetum", b =>
                {
                    b.Property<int>("FilmesId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlanetasId")
                        .HasColumnType("INTEGER");

                    b.HasKey("FilmesId", "PlanetasId");

                    b.HasIndex(new[] { "PlanetasId" }, "IX_FilmePlaneta_PlanetasId");

                    b.ToTable("FilmePlaneta", (string)null);
                });

            modelBuilder.Entity("FilmeVeiculo", b =>
                {
                    b.Property<int>("FilmesId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VeiculosId")
                        .HasColumnType("INTEGER");

                    b.HasKey("FilmesId", "VeiculosId");

                    b.HasIndex(new[] { "VeiculosId" }, "IX_FilmeVeiculo_VeiculosId");

                    b.ToTable("FilmeVeiculo", (string)null);
                });

            modelBuilder.Entity("Scrapper_SWAPI.Models.Filme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DataLancamento")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Diretor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Episodio")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Produtor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TextoAbertura")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Filmes");
                });

            modelBuilder.Entity("Scrapper_SWAPI.Models.NavesEstelare", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CapacidadeCarga")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Classe")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ClassificacaoHiperdrive")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Comprimento")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Consumiveis")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CustoEmCreditos")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Fabricante")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Mglt")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Passageiros")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Tripulacao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("VelocidadeMaxima")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("NavesEstelares");
                });

            modelBuilder.Entity("Scrapper_SWAPI.Models.Personagen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Altura")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("AnoNascimento")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CorCabelo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CorOlhos")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CorPele")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Peso")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PlanetaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "PlanetaId" }, "IX_Personagens_PlanetaId");

                    b.ToTable("Personagens");
                });

            modelBuilder.Entity("Scrapper_SWAPI.Models.Planeta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Clima")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Diametro")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Gravidade")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PeriodoOrbital")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PeriodoRotacao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Populacao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SuperficieAquatica")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Terreno")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Planetas");
                });

            modelBuilder.Entity("Scrapper_SWAPI.Models.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CapacidadeCarga")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Classe")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Comprimento")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Consumiveis")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CustoEmCreditos")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Fabricante")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Passageiros")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Tripulacao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("VelocidadeMaxima")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Veiculos");
                });

            modelBuilder.Entity("FilmeNavesEstelare", b =>
                {
                    b.HasOne("Scrapper_SWAPI.Models.Filme", null)
                        .WithMany()
                        .HasForeignKey("FilmesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Scrapper_SWAPI.Models.NavesEstelare", null)
                        .WithMany()
                        .HasForeignKey("NavesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FilmePersonagem", b =>
                {
                    b.HasOne("Scrapper_SWAPI.Models.Filme", null)
                        .WithMany()
                        .HasForeignKey("FilmesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Scrapper_SWAPI.Models.Personagen", null)
                        .WithMany()
                        .HasForeignKey("PersonagensId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FilmePlanetum", b =>
                {
                    b.HasOne("Scrapper_SWAPI.Models.Filme", null)
                        .WithMany()
                        .HasForeignKey("FilmesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Scrapper_SWAPI.Models.Planeta", null)
                        .WithMany()
                        .HasForeignKey("PlanetasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FilmeVeiculo", b =>
                {
                    b.HasOne("Scrapper_SWAPI.Models.Filme", null)
                        .WithMany()
                        .HasForeignKey("FilmesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Scrapper_SWAPI.Models.Veiculo", null)
                        .WithMany()
                        .HasForeignKey("VeiculosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Scrapper_SWAPI.Models.Personagen", b =>
                {
                    b.HasOne("Scrapper_SWAPI.Models.Planeta", "Planeta")
                        .WithMany("Personagens")
                        .HasForeignKey("PlanetaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Planeta");
                });

            modelBuilder.Entity("Scrapper_SWAPI.Models.Planeta", b =>
                {
                    b.Navigation("Personagens");
                });
#pragma warning restore 612, 618
        }
    }
}