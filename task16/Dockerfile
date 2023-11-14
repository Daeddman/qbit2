FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["task16/task16.csproj", "task16/"]
RUN dotnet restore "task16/task16.csproj"
COPY . .
WORKDIR "/src/task16"
RUN dotnet build "task16.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "task16.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "task16.dll"]
