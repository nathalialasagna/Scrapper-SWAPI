using System;
using System.Collections.Generic;

namespace Scrapper_SWAPI.Models;

public partial class Planeta
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string PeriodoRotacao { get; set; } = null!;

    public string PeriodoOrbital { get; set; } = null!;

    public string Diametro { get; set; } = null!;

    public string Clima { get; set; } = null!;

    public string Gravidade { get; set; } = null!;

    public string Terreno { get; set; } = null!;

    public string SuperficieAquatica { get; set; } = null!;

    public string Populacao { get; set; } = null!;

    public virtual ICollection<Personagen> Personagens { get; set; } = new List<Personagen>();

    public virtual ICollection<Filme> Filmes { get; set; } = new List<Filme>();
}
