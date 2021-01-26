FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["BlazorApp3/Server/BlazorApp3.Server.csproj", "BlazorApp3/Server/"]
COPY ["BlazorApp3/Client/BlazorApp3.Client.csproj", "BlazorApp3/Client/"]
COPY ["BlazorApp3/Shared/BlazorApp3.Shared.csproj", "BlazorApp3/Shared/"]
RUN dotnet restore "BlazorApp3/Server/BlazorApp3.Server.csproj"
COPY . .
WORKDIR "/src/BlazorApp3/Server"
RUN dotnet build "BlazorApp3.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BlazorApp3.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BlazorApp3.Server.dll"]
