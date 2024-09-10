# Use the official .NET 7 runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Use the SDK to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Inventory.AuthAPI/Inventory.AuthAPI.csproj", "Inventory.AuthAPI/"]
COPY ["Inventory.AuthManagement/Inventory.AuthManagement.csproj", "Inventory.AuthManagement/"]
RUN dotnet restore "Inventory.AuthAPI/Inventory.AuthAPI.csproj"
COPY . .
WORKDIR "/src/Inventory.AuthAPI"
RUN dotnet build "Inventory.AuthAPI.csproj" -c Release -o /app/build

# Publish the application
FROM build AS publish
RUN dotnet publish "Inventory.AuthAPI.csproj" -c Release -o /app/publish

# Use the runtime image to run the app
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Inventory.AuthAPI.dll"]
