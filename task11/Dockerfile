FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["task11/task11.csproj", "task11/"]
RUN dotnet restore "task11/task11.csproj"
COPY . .
WORKDIR "/src/task11"
RUN dotnet build "task11.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "task11.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "task11.dll"]
