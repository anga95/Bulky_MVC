# Bygg stadiet
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Kopiera .csproj filer för både DataAccess och Web-projektet
COPY ["BulkyWeb/BulkyWeb.csproj", "./BulkyWeb/"]
COPY ["Bylky.DataAccess/Bylky.DataAccess.csproj", "./Bylky.DataAccess/"]

# Kör dotnet restore för att återställa beroenden
RUN dotnet restore "./BulkyWeb/BulkyWeb.csproj"

# Kopiera hela projektets filer
COPY . .

# Bygg projektet
WORKDIR "/src/BulkyWeb"
RUN dotnet build "BulkyWeb.csproj" -c Release -o /app/build

# Publicera projektet
FROM build AS publish
RUN dotnet publish "BulkyWeb.csproj" -c Release -o /app/publish

# Runtime stadiet
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8081
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BulkyWeb.dll"]
