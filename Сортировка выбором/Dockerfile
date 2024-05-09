FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Сортировка выбором/Сортировка выбором.csproj", "Сортировка выбором/"]
RUN dotnet restore "Сортировка выбором/Сортировка выбором.csproj"
COPY . .
WORKDIR "/src/Сортировка выбором"
RUN dotnet build "Сортировка выбором.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Сортировка выбором.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Сортировка выбором.dll"]
