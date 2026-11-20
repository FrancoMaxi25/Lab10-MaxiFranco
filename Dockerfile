
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY . .
RUN dotnet restore Lab10-MaxiFranco.Api/Lab10-MaxiFranco.Api.csproj
RUN dotnet publish Lab10-MaxiFranco.Api/Lab10-MaxiFranco.Api.csproj -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app

COPY --from=build /app/publish .

EXPOSE 10000

CMD ["sh", "-c", "dotnet Lab10-MaxiFranco.Api.dll --urls http://0.0.0.0:${PORT:-10000}"]
