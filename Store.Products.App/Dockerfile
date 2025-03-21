﻿FROM --platform=linux/amd64 mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM --platform=linux/amd64 mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Store.Products.App/Store.Products.App.csproj", "Store.Products.App/"]
COPY ["Store.Products.Core/Store.Products.Core.csproj", "Store.Products.Core/"]
RUN dotnet restore "Store.Products.App/Store.Products.App.csproj"
COPY . .
WORKDIR "/src/Store.Products.App"
RUN dotnet build "Store.Products.App.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Store.Products.App.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Store.Products.App.dll"]