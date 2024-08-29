# Use the official .NET image as a base image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Use the official SDK image to build the application
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Portfolio.csproj", "./"]
RUN dotnet restore "./Portfolio.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Portfolio.csproj" -c Release -o /app/build

# Publish the app
FROM build AS publish
RUN dotnet publish "Portfolio.csproj" -c Release -o /app/publish

# Final stage/image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Portfolio.dll"]
