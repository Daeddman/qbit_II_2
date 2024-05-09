FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Библиотечный метод/Библиотечный метод.csproj", "Библиотечный метод/"]
RUN dotnet restore "Библиотечный метод/Библиотечный метод.csproj"
COPY . .
WORKDIR "/src/Библиотечный метод"
RUN dotnet build "Библиотечный метод.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Библиотечный метод.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Библиотечный метод.dll"]
