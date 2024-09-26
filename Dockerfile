# Använd en officiell bild som bas
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Bygg stadiet
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["BulkyWeb/BulkyWeb.csproj", "./"]
RUN dotnet restore "./BulkyWeb.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "BulkyWeb.csproj" -c Release -o /app/build

# Publicera stadiet
FROM build AS publish
RUN dotnet publish "BulkyWeb.csproj" -c Release -o /app/publish

# Sätt upp runtime stadiet
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BulkyWeb.dll"]  # Starta applikationen
