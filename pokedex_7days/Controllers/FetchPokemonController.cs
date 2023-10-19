using System.Text.Json;
using pokedex_7days.Domain.Contracts;
using pokedex_7days.Domain.Models;

namespace pokedex_7days.Controllers;

public class FetchPokemonController : IFetchPokemon
{
    public FetchPokemonController()
    {
         FetchPokemonFromApi();
    }
    
    private async void FetchPokemonFromApi()
    {
        try
        {
            Console.WriteLine("Realizando consulta de pokemon...");

            var client = new HttpClient();

            string response = await client.GetStringAsync(Environment.GetEnvironmentVariable("pokemonadress"));

            var responseSerializer = JsonSerializer.Deserialize<PokemonModel>(response);
            
            Console.WriteLine($"Pokemon: {responseSerializer!.name}");
            Console.WriteLine($"Height: {responseSerializer.height}");
            Console.WriteLine($"Weight: {responseSerializer.weight}");
            Console.WriteLine("Abilities: ");
            foreach (var abilitiesList in responseSerializer.abilities)
            {
                Console.WriteLine(abilitiesList.ability.name);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}