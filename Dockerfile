FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

# copy all the layers' csproj files into respective folders
COPY ["./Api/Api.csproj", "src/Api/"]
COPY ["./Application/Application.csproj", "src/Application/"]
COPY ["./Infrastructure/Infrastructure.csproj", "src/Infrastructure/"]
COPY ["./Core/Core.csproj", "src/Core/"]
COPY ["./Domain/Domain.csproj", "src/Domain/"]
COPY ["./UnitTest/UnitTest.csproj", "src/UnitTest/"]

# run restore over Api project - this pulls restore over the dependent projects as well
RUN dotnet restore "src/Api/Api.csproj"

COPY . .

# run build over the Api project
WORKDIR "/src/Api/"
RUN dotnet build -c Release -o /app/build

# run publish over the Api project
FROM build AS publish
RUN dotnet publish -c Release -o /app/publish

FROM base AS runtime
WORKDIR /app

COPY --from=publish /app/publish .
RUN ls -l
ENTRYPOINT [ "dotnet", "Api.dll" ]