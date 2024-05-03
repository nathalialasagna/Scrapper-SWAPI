using Scrapper_SWAPI.Dtos;
using System.Text.Json;

namespace Scrapper_SWAPI.SWAPIServices;

public class GetEndpointsSwApi
{
    HttpClient client = new HttpClient();

    public async Task<List<Filme>> GetFilmes()
    {
        List<Filme> filmes = [];
        var Uri = "https://swapi.py4e.com/api/films/?format=json";

        while (Uri != null)
        {
            var response = await client.GetAsync(Uri);

            var jsonString = await response.Content.ReadAsStringAsync();

            var result = JsonSerializer.Deserialize<ResultFilme>(jsonString);

            Uri = result?.next;

            if (result?.results != null) filmes = [.. filmes, .. result.results];
        }
        return filmes ?? [];
    }

    public async Task<List<NaveEstelar>> GetNavesEstelares()
    {
        List<NaveEstelar> naves = [];
        var Uri = "https://swapi.py4e.com/api/starships/?format=json";
       
        while (Uri != null)
        {
            var response = await client.GetAsync(Uri);

            var jsonString = await response.Content.ReadAsStringAsync();

            var result = JsonSerializer.Deserialize<ResultNaveEstelar>(jsonString);
            
            Uri = result?.next;
           
            if(result?.results != null) naves = [.. naves, .. result.results];
        }
        return naves ?? [];
    }

    public async Task<List<Personagem>> GetPersonagens()
    {
        List<Personagem> personagens = [];
        var Uri = "https://swapi.py4e.com/api/people/?format=json";

        while (Uri != null)
        {
            var response = await client.GetAsync(Uri);

            var jsonString = await response.Content.ReadAsStringAsync();

            var result = JsonSerializer.Deserialize<ResultPersonagem>(jsonString);

            Uri = result?.next;

            if (result?.results != null) personagens = [.. personagens, .. result.results];
        }
        return personagens ?? [];
    }

    public async Task<List<Planeta>> GetPlanetas()
    {
        List<Planeta> planetas = [];
        var Uri = "https://swapi.py4e.com/api/planets/?format=json";

        while (Uri != null)
        {
            var response = await client.GetAsync(Uri);

            var jsonString = await response.Content.ReadAsStringAsync();

            var result = JsonSerializer.Deserialize<ResultPlaneta>(jsonString);

            Uri = result?.next;

            if (result?.results != null) planetas = [.. planetas, .. result.results];
        }
        return planetas ?? [];
    }

    public async Task<List<Veiculo>> GetVeiculos()
    {

        List<Veiculo> veiculos = [];
        var Uri = "https://swapi.py4e.com/api/vehicles/?format=json";

        while (Uri != null)
        {
            var response = await client.GetAsync(Uri);

            var jsonString = await response.Content.ReadAsStringAsync();

            var result = JsonSerializer.Deserialize<ResultVeiculo>(jsonString);

            Uri = result?.next;

            if (result?.results != null) veiculos = [.. veiculos, .. result.results];
        }
        return veiculos ?? [];
    }
}
