﻿FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["task5/task5.csproj", "task5/"]
RUN dotnet restore "task5/task5.csproj"
COPY . .
WORKDIR "/src/task5"
RUN dotnet build "task5.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "task5.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "task5.dll"]
