FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Сортировка по сумме цифр/Сортировка по сумме цифр.csproj", "Сортировка по сумме цифр/"]
RUN dotnet restore "Сортировка по сумме цифр/Сортировка по сумме цифр.csproj"
COPY . .
WORKDIR "/src/Сортировка по сумме цифр"
RUN dotnet build "Сортировка по сумме цифр.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Сортировка по сумме цифр.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Сортировка по сумме цифр.dll"]
