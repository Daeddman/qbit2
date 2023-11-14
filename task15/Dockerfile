FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["task15/task15.csproj", "task15/"]
RUN dotnet restore "task15/task15.csproj"
COPY . .
WORKDIR "/src/task15"
RUN dotnet build "task15.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "task15.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "task15.dll"]
