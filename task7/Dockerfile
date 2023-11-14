FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["task7/task7.csproj", "task7/"]
RUN dotnet restore "task7/task7.csproj"
COPY . .
WORKDIR "/src/task7"
RUN dotnet build "task7.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "task7.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "task7.dll"]
