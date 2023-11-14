FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["task19/task19.csproj", "task19/"]
RUN dotnet restore "task19/task19.csproj"
COPY . .
WORKDIR "/src/task19"
RUN dotnet build "task19.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "task19.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "task19.dll"]
