FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["task4/task4.csproj", "task4/"]
RUN dotnet restore "task4/task4.csproj"
COPY . .
WORKDIR "/src/task4"
RUN dotnet build "task4.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "task4.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "task4.dll"]
