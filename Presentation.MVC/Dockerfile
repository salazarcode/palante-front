FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.sln .
COPY Presentation.MVC/*.csproj ./Presentation.MVC/

RUN dotnet restore

# Copy everything else and build
COPY Presentation.MVC/. ./Presentation.MVC/

WORKDIR /app/Presentation.MVC
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=build-env /app/Presentation.MVC/out ./
ENTRYPOINT ["dotnet", "Presentation.MVC.dll"]