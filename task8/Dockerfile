FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["task8/task8.csproj", "task8/"]
RUN dotnet restore "task8/task8.csproj"
COPY . .
WORKDIR "/src/task8"
RUN dotnet build "task8.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "task8.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "task8.dll"]
