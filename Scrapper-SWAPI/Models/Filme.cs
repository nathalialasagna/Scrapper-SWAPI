using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Scrapper_SWAPI.Models;

[PrimaryKey(nameof(Id))]
public partial class Filme
{
    public int Id { get; set; }

    public string Titulo { get; set; } = null!;

    public int Episodio { get; set; }

    public string TextoAbertura { get; set; } = null!;

    public string Diretor { get; set; } = null!;

    public string Produtor { get; set; } = null!;

    public string DataLancamento { get; set; } = null!;

    public  List<NavesEstelare> Naves { get; set; } = new List<NavesEstelare>();

    public  List<Personagen> Personagens { get; set; } = new List<Personagen>();

    public  List<Planeta> Planetas { get; set; } = new List<Planeta>();

    public  List<Veiculo> Veiculos { get; set; } = new List<Veiculo>();
}
