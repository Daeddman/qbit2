FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["qbit3/qbit3.csproj", "qbit3/"]
RUN dotnet restore "qbit3/qbit3.csproj"
COPY . .
WORKDIR "/src/qbit3"
RUN dotnet build "qbit3.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "qbit3.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "qbit3.dll"]
