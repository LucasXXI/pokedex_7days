namespace pokedex_7days.Domain.Models;

public class PokemonModel
{
    public string name { get; set; }
    public int height { get; set; }
    public int weight {get; set;} 
    public List<AbilitiesModel> abilities { get; set; }
}

