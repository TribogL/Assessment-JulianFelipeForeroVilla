# Etapa base: se usa para ejecutar la aplicación
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Etapa de construcción: SDK para compilar la aplicación
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copiar el archivo de proyecto y restaurar las dependencias
COPY ["Assessment-JulianFelipeForeroVilla.csproj", "./"]
RUN dotnet restore "Assessment-JulianFelipeForeroVilla.csproj"

# Copiar el resto del código fuente y construir la aplicación
COPY . .
WORKDIR "/src"
RUN dotnet build "Assessment-JulianFelipeForeroVilla.csproj" -c Release -o /app/build

# Etapa de publicación
FROM build AS publish
RUN dotnet publish "Assessment-JulianFelipeForeroVilla.csproj" -c Release -o /app/publish

# Etapa final: se usa para ejecutar la aplicación ya publicada
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Assessment-JulianFelipeForeroVilla.dll"]

