#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Chopping.API/Chopping.API.csproj", "Chopping.API/"]
RUN dotnet restore "Chopping.API/Chopping.API.csproj"
COPY . .
WORKDIR "/src/Chopping.API"
RUN dotnet build "Chopping.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Chopping.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Chopping.API.dll"]
