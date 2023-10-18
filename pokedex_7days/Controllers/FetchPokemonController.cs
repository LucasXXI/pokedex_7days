using pokedex_7days.Domain.Contracts;

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
            
            Console.WriteLine(response);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}