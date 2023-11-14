FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["task6/task6.csproj", "task6/"]
RUN dotnet restore "task6/task6.csproj"
COPY . .
WORKDIR "/src/task6"
RUN dotnet build "task6.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "task6.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "task6.dll"]
