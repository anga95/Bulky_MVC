# Stage 1: Base
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 5001

# Stage 2: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Kopiera projektfiler
COPY ["BulkyWeb/BulkyWeb.csproj", "BulkyWeb/"]
COPY ["Bylky.DataAccess/Bylky.DataAccess.csproj", "Bylky.DataAccess/"]
COPY ["Bulky.Models/Bulky.Models.csproj", "Bulky.Models/"]
COPY ["Bulky.Utility/Bulky.Utility.csproj", "Bulky.Utility/"]

# Restore beroenden
RUN dotnet restore "BulkyWeb/BulkyWeb.csproj"

# Kopiera alla filer
COPY . .

# Bygg projektet
WORKDIR "/src/BulkyWeb"
RUN dotnet build "BulkyWeb.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Stage 3: Publish
FROM build AS publish
RUN dotnet publish "BulkyWeb.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Stage 4: Final
FROM base AS final
WORKDIR /app
ENV ASPNETCORE_URLS=http://+:5001
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BulkyWeb.dll"]
