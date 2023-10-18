using pokedex_7days.Controllers;
using pokedex_7days.Domain.Contracts;

namespace pokedex_7days.Infra.Extensions;

public static class HttpExtension
{
    public static IServiceCollection AddHtppExtensions(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IFetchPokemon, FetchPokemonController>();

        return services;
    }
}