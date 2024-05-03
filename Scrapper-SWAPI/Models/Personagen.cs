using System;
using System.Collections.Generic;

namespace Scrapper_SWAPI.Models;

public partial class Personagen
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string Altura { get; set; } = null!;

    public string Peso { get; set; } = null!;

    public string CorCabelo { get; set; } = null!;

    public string CorPele { get; set; } = null!;

    public string CorOlhos { get; set; } = null!;

    public string AnoNascimento { get; set; } = null!;

    public string Genero { get; set; } = null!;

    public int PlanetaId { get; set; }

    public virtual Planeta Planeta { get; set; } = null!;

    public virtual ICollection<Filme> Filmes { get; set; } = new List<Filme>();
}
