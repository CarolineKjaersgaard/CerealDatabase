
# syntax=docker/dockerfile:1

# Build stage
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /CerealDatabase
# Copy and restore dependencies
COPY CerealDatabase.csproj ./
RUN dotnet restore

# Copy the rest of the code and publish
COPY . ./
COPY Data/Cereal.csv ./Data/Cereal.csv
RUN dotnet publish -c Release -o out

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /CerealDatabase
COPY --from=build /CerealDatabase/out .

EXPOSE 5250
EXPOSE 7185

ENTRYPOINT ["dotnet", "CerealDatabase.dll"]
