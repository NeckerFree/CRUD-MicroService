# Use the official .NET image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5001

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy csproj and restore as distinct layers
COPY ["Inventory.AuthAPI/Inventory.AuthAPI.csproj", "Inventory.AuthAPI/"]
COPY ["Inventory.AuthManagement/Inventory.AuthManagement.csproj", "Inventory.AuthManagement/"]
RUN dotnet restore "Inventory.AuthAPI/Inventory.AuthAPI.csproj"

# Copy everything and build the API
COPY . .
WORKDIR "/src/Inventory.AuthAPI"
RUN dotnet build "Inventory.AuthAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Inventory.AuthAPI.csproj" -c Release -o /app/publish

# Final stage - production image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Inventory.AuthAPI.dll"]