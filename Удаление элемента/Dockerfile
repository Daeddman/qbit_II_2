FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Удаление элемента/Удаление элемента.csproj", "Удаление элемента/"]
RUN dotnet restore "Удаление элемента/Удаление элемента.csproj"
COPY . .
WORKDIR "/src/Удаление элемента"
RUN dotnet build "Удаление элемента.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Удаление элемента.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Удаление элемента.dll"]
