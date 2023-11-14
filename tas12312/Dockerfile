FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["tas12312/tas12312.csproj", "tas12312/"]
RUN dotnet restore "tas12312/tas12312.csproj"
COPY . .
WORKDIR "/src/tas12312"
RUN dotnet build "tas12312.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "tas12312.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "tas12312.dll"]
