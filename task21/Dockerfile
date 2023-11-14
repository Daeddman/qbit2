FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["task21/task21.csproj", "task21/"]
RUN dotnet restore "task21/task21.csproj"
COPY . .
WORKDIR "/src/task21"
RUN dotnet build "task21.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "task21.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "task21.dll"]
