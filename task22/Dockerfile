FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["task22/task22.csproj", "task22/"]
RUN dotnet restore "task22/task22.csproj"
COPY . .
WORKDIR "/src/task22"
RUN dotnet build "task22.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "task22.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "task22.dll"]
