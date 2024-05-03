using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Scrapper_SWAPI.Models;

[PrimaryKey(nameof(Id))]
public partial class NavesEstelare
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string Modelo { get; set; } = null!;

    public string Fabricante { get; set; } = null!;

    public string CustoEmCreditos { get; set; } = null!;

    public string Comprimento { get; set; } = null!;

    public string VelocidadeMaxima { get; set; } = null!;

    public string Tripulacao { get; set; } = null!;

    public string Passageiros { get; set; } = null!;

    public string CapacidadeCarga { get; set; } = null!;

    public string ClassificacaoHiperdrive { get; set; } = null!;

    public string Mglt { get; set; } = null!;

    public string Consumiveis { get; set; } = null!;

    public string Classe { get; set; } = null!;

    public virtual ICollection<Filme> Filmes { get; set; } = new List<Filme>();
}
