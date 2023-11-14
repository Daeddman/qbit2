FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["task12/task12.csproj", "task12/"]
RUN dotnet restore "task12/task12.csproj"
COPY . .
WORKDIR "/src/task12"
RUN dotnet build "task12.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "task12.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "task12.dll"]
