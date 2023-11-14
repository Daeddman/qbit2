FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["task9/task9.csproj", "task9/"]
RUN dotnet restore "task9/task9.csproj"
COPY . .
WORKDIR "/src/task9"
RUN dotnet build "task9.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "task9.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "task9.dll"]
