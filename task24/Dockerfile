FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["task24/task24.csproj", "task24/"]
RUN dotnet restore "task24/task24.csproj"
COPY . .
WORKDIR "/src/task24"
RUN dotnet build "task24.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "task24.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "task24.dll"]
