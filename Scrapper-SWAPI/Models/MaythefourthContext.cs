using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Scrapper_SWAPI.Models;

public partial class MaythefourthContext : DbContext
{
    public MaythefourthContext()
    {
    }

    public MaythefourthContext(DbContextOptions<MaythefourthContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Filme> Filmes { get; set; }

    public virtual DbSet<NavesEstelare> NavesEstelares { get; set; }

    public virtual DbSet<Personagen> Personagens { get; set; }

    public virtual DbSet<Planeta> Planetas { get; set; }

    public virtual DbSet<Veiculo> Veiculos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("DataSource=C:\\Users\\natha\\OneDrive\\Documentos\\Scrapper-SWAPI\\Scrapper-SWAPI\\Db\\maythefourth.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Filme>(entity =>
        {
            entity.HasMany(d => d.Naves).WithMany(p => p.Filmes)
                .UsingEntity<Dictionary<string, object>>(
                    "FilmeNavesEstelare",
                    r => r.HasOne<NavesEstelare>().WithMany().HasForeignKey("NavesId"),
                    l => l.HasOne<Filme>().WithMany().HasForeignKey("FilmesId"),
                    j =>
                    {
                        j.HasKey("FilmesId", "NavesId");
                        j.ToTable("FilmeNavesEstelares");
                        j.HasIndex(new[] { "NavesId" }, "IX_FilmeNavesEstelares_NavesId");
                    });

            entity.HasMany(d => d.Personagens).WithMany(p => p.Filmes)
                .UsingEntity<Dictionary<string, object>>(
                    "FilmePersonagem",
                    r => r.HasOne<Personagen>().WithMany().HasForeignKey("PersonagensId"),
                    l => l.HasOne<Filme>().WithMany().HasForeignKey("FilmesId"),
                    j =>
                    {
                        j.HasKey("FilmesId", "PersonagensId");
                        j.ToTable("FilmePersonagem");
                        j.HasIndex(new[] { "PersonagensId" }, "IX_FilmePersonagem_PersonagensId");
                    });

            entity.HasMany(d => d.Planetas).WithMany(p => p.Filmes)
                .UsingEntity<Dictionary<string, object>>(
                    "FilmePlanetum",
                    r => r.HasOne<Planeta>().WithMany().HasForeignKey("PlanetasId"),
                    l => l.HasOne<Filme>().WithMany().HasForeignKey("FilmesId"),
                    j =>
                    {
                        j.HasKey("FilmesId", "PlanetasId");
                        j.ToTable("FilmePlaneta");
                        j.HasIndex(new[] { "PlanetasId" }, "IX_FilmePlaneta_PlanetasId");
                    });

            entity.HasMany(d => d.Veiculos).WithMany(p => p.Filmes)
                .UsingEntity<Dictionary<string, object>>(
                    "FilmeVeiculo",
                    r => r.HasOne<Veiculo>().WithMany().HasForeignKey("VeiculosId"),
                    l => l.HasOne<Filme>().WithMany().HasForeignKey("FilmesId"),
                    j =>
                    {
                        j.HasKey("FilmesId", "VeiculosId");
                        j.ToTable("FilmeVeiculo");
                        j.HasIndex(new[] { "VeiculosId" }, "IX_FilmeVeiculo_VeiculosId");
                    });
        });

        modelBuilder.Entity<Personagen>(entity =>
        {
            entity.HasIndex(e => e.PlanetaId, "IX_Personagens_PlanetaId");

            entity.HasOne(d => d.Planeta).WithMany(p => p.Personagens).HasForeignKey(d => d.PlanetaId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
