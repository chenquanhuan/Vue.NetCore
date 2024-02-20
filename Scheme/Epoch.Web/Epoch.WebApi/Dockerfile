#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
RUN apt-get update; apt-get install libfontconfig1 -y

WORKDIR /app
EXPOSE 9991

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Epoch.WebApi/Epoch.WebApi.csproj", "Epoch.WebApi/"]
COPY ["Epoch.System/Epoch.System.csproj", "Epoch.System/"]
COPY ["Epoch.Core/Epoch.Core.csproj", "Epoch.Core/"]
COPY ["Epoch.Entity/Epoch.Entity.csproj", "Epoch.Entity/"]
COPY ["Epoch.Order/Epoch.Order.csproj", "Epoch.Order/"]
COPY ["Epoch.AppManager/Epoch.AppManager.csproj", "Epoch.AppManager/"]
COPY ["Epoch.Builder/Epoch.Builder.csproj", "Epoch.Builder/"]
RUN dotnet restore "Epoch.WebApi/Epoch.WebApi.csproj"
COPY . .
WORKDIR "/src/Epoch.WebApi"
RUN dotnet build "Epoch.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Epoch.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Epoch.WebApi.dll"]