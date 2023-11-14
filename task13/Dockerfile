FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["task13/task13.csproj", "task13/"]
RUN dotnet restore "task13/task13.csproj"
COPY . .
WORKDIR "/src/task13"
RUN dotnet build "task13.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "task13.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "task13.dll"]
