FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["pokedex_7days/pokedex_7days.csproj", "pokedex_7days/"]
RUN dotnet restore "pokedex_7days/pokedex_7days.csproj"
COPY . .
WORKDIR "/src/pokedex_7days"
RUN dotnet build "pokedex_7days.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "pokedex_7days.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "pokedex_7days.dll"]
