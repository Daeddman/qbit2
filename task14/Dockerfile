FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["task14/task14.csproj", "task14/"]
RUN dotnet restore "task14/task14.csproj"
COPY . .
WORKDIR "/src/task14"
RUN dotnet build "task14.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "task14.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "task14.dll"]
