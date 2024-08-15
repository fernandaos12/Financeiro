FROM mcr.microsoft.com/dotnet/aspnet:7.0-nanoserver-1809 AS base
WORKDIR /app
EXPOSE 5014

ENV ASPNETCORE_URLS=http://+:5014

FROM mcr.microsoft.com/dotnet/sdk:7.0-nanoserver-1809 AS build
ARG configuration=Release
WORKDIR /src
COPY ["Financeiro/Financeiro.csproj", "Financeiro/"]
RUN dotnet restore "Financeiro\Financeiro.csproj"
COPY . .
WORKDIR "/src/Financeiro"
RUN dotnet build "Financeiro.csproj" -c $configuration -o /app/build

FROM mysql:8.0
ENV MYSQL_ROOT_PASSWORD = 18191819
ENV MYSQL_ROOT_DATABASE = financeirodb
ENV MYSQL_USER = admin
ENV MYSQL_PASSWORD = admin

COPY my.cnf /etc/mysql/my.cnf
EXPOSE 3306
CMD ["mysqld"]

FROM build AS publish
ARG configuration=Release
RUN dotnet publish "Financeiro.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Financeiro.dll"]

