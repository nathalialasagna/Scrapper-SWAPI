using Scrapper_SWAPI.Extension;
using Scrapper_SWAPI.Models;
using Scrapper_SWAPI.SWAPIServices;

namespace Scrapper_SWAPI.Services;

public class AddDataToDB
{
    private readonly GetEndpointsSwApi _endpoinst;
    private readonly MaythefourthContext _context;
    public AddDataToDB()
    {
        _endpoinst = new GetEndpointsSwApi();
        _context = new MaythefourthContext();
    }

    public void AddFilmes()
    {
        var endpoinst = new GetEndpointsSwApi();
        var filmes = endpoinst.GetFilmes().Result;

        foreach (var f in filmes)
        {
            _context.Filmes.Add(new Filme
            {
                Id = f.url.GetIdFromUrl(),
                Titulo = f.title,
                Episodio = f.episode_id,
                TextoAbertura = f.opening_crawl,
                Diretor = f.director,
                Produtor = f.producer,
                DataLancamento = f.release_date,
                Personagens = f.characters.Select(u => _context.Personagens.FirstOrDefault(a => a.Id == u.GetIdFromUrl())!).ToList() ?? [],
                Planetas = f.planets.Select(u => _context.Planetas.FirstOrDefault(a => a.Id == u.GetIdFromUrl())!).ToList() ?? [],
                Naves = f.starships.Select(u => _context.NavesEstelares.FirstOrDefault(a => a.Id == u.GetIdFromUrl())!).ToList() ?? [],
                Veiculos = f.vehicles.Select(u => _context.Veiculos.FirstOrDefault(a => a.Id == u.GetIdFromUrl())!).ToList() ?? [],
            });
        }
        _context.SaveChanges();
    }

    public void AddNaves()
    {
        var naves = _endpoinst.GetNavesEstelares().Result;

        foreach (var n in naves)
        {

            _context.NavesEstelares.Add(new NavesEstelare
            {
                Id = n.url.GetIdFromUrl(),
                Nome = n.name,
                Modelo = n.model,
                Fabricante = n.manufacturer,
                CustoEmCreditos = n.cost_in_credits,
                Comprimento = n.length,
                VelocidadeMaxima = n.max_atmosphering_speed,
                Passageiros = n.passengers,
                Tripulacao = n.crew,
                CapacidadeCarga = n.cargo_capacity,
                ClassificacaoHiperdrive = n.starship_class,
                Mglt = n.MGLT,
                Consumiveis = n.consumables,
                Classe = n.starship_class
            });
        }
        _context.SaveChanges();
    }

    public void AddPlanetas()
    {
        var planetas = _endpoinst.GetPlanetas().Result;

        foreach (var p in planetas)
        {
            _context.Planetas.Add(new Planeta
            {
                Id = p.url.GetIdFromUrl(),
                Nome = p.name,
                PeriodoRotacao = p.rotation_period,
                PeriodoOrbital = p.orbital_period,
                Diametro = p.diameter,
                Clima = p.climate,
                Gravidade = p.gravity,
                Terreno = p.terrain,
                SuperficieAquatica = p.surface_water,
                Populacao = p.population
            });
        }
        _context.SaveChanges();
    }

    public void AddPersonagens()
    {
        var personagens = _endpoinst.GetPersonagens().Result;

        foreach (var p in personagens)
        {
            _context.Personagens.Add(new Personagen
            {
                Id = p.url.GetIdFromUrl(),
                Nome = p.name,
                Altura = p.height,
                Peso = p.mass,
                CorCabelo = p.hair_color,
                CorPele = p.skin_color,
                CorOlhos = p.eye_color,
                AnoNascimento = p.birth_year,
                Genero = p.gender,
                Planeta = _context.Planetas.FirstOrDefault(u => u.Id == p.homeworld.GetIdFromUrl())!
            });
        }
        _context.SaveChanges();
    }

    public void AddVeiculos()
    {
        var veiculos = _endpoinst.GetVeiculos().Result;

        foreach (var v in veiculos)
        {
            _context.Veiculos.Add(new Veiculo
            {
                Id = v.url.GetIdFromUrl(),
                Nome = v.name,
                Modelo = v.model,
                Fabricante = v.manufacturer,
                CustoEmCreditos = v.cost_in_credits,
                Comprimento = v.length,
                VelocidadeMaxima = v.max_atmosphering_speed,
                Tripulacao = v.crew,
                Passageiros = v.passengers,
                CapacidadeCarga = v.cargo_capacity,
                Consumiveis = v.consumables,
                Classe = v.vehicle_class
            });
        }
        _context.SaveChanges();
    }
}