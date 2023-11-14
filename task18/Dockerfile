FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["task18/task18.csproj", "task18/"]
RUN dotnet restore "task18/task18.csproj"
COPY . .
WORKDIR "/src/task18"
RUN dotnet build "task18.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "task18.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "task18.dll"]
