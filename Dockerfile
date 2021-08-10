FROM mcr.microsoft.com/dotnet/sdk:3.1 AS base

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ./PokeTrader.Api ./PokeTrader.Api
#COPY ["Api.Calculo/Api.Calculo.csproj", "Calculo/"]
COPY ["PokeTrader.CrossCutting/PokeTrader.CrossCutting.csproj", "PokeTrader.CrossCutting/"]
COPY ["PokeTrader.Data/PokeTrader.Data.csproj", "PokeTrader.Data/"]
COPY ["PokeTrader.Domain/PokeTrader.Domain.csproj", "PokeTrader.Domain/"]
COPY ["PokeTrader.Service/PokeTrader.Service.csproj", "PokeTrader.Service/"]
RUN dotnet restore "PokeTrader.Api/PokeTrader.Api.csproj"
COPY . .
WORKDIR "/src/PokeTrader.Api"
RUN dotnet build "PokeTrader.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "PokeTrader.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app

COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "PokeTrader.Api.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet PokeTrader.Api.dll
