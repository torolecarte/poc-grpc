FROM mcr.microsoft.com/dotnet/core/runtime:3.1-buster-slim AS base
WORKDIR /app

ENV TZ=America/Sao_Paulo
RUN ln -snf /usr/share/zoneinfo/$TZ /etc/localtime && echo $TZ > /etc/timezone

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["ConsoleAppTimezoneTests/ConsoleAppTimezoneTests.csproj", "ConsoleAppTimezoneTests/"]
RUN dotnet restore "ConsoleAppTimezoneTests/ConsoleAppTimezoneTests.csproj"
COPY . .
WORKDIR "/src/ConsoleAppTimezoneTests"
RUN dotnet build "ConsoleAppTimezoneTests.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ConsoleAppTimezoneTests.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "ConsoleAppTimezoneTests.dll"]