﻿FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Сортировка времени/Сортировка времени.csproj", "Сортировка времени/"]
RUN dotnet restore "Сортировка времени/Сортировка времени.csproj"
COPY . .
WORKDIR "/src/Сортировка времени"
RUN dotnet build "Сортировка времени.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Сортировка времени.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Сортировка времени.dll"]
