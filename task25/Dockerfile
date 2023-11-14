FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["task25/task25.csproj", "task25/"]
RUN dotnet restore "task25/task25.csproj"
COPY . .
WORKDIR "/src/task25"
RUN dotnet build "task25.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "task25.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "task25.dll"]
