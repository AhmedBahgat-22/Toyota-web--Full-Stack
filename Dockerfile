# Use the .NET 10 SDK to build the app
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# Copy the project file and restore dependencies
COPY ["ToyotaProject.csproj", "./"]
RUN dotnet restore "ToyotaProject.csproj"

# Copy the rest of the files and build
COPY . .
RUN dotnet publish "ToyotaProject.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Use the .NET 10 ASP.NET runtime to run the app
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

# Tell Docker to run the app
ENTRYPOINT ["dotnet", "ToyotaProject.dll"]
