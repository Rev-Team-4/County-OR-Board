FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS buildstage
WORKDIR /aspnet
COPY ["OrBoard.Client/OrBoard.Client.csproj", "OrBoard.Client/"]
RUN dotnet restore OrBoard.Client/OrBoard.Client.csproj
COPY . .
WORKDIR /aspnet/OrBoard.Client
RUN dotnet build OrBoard.Client.csproj

FROM buildstage AS publishstage
RUN dotnet publish OrBoard.Client.csproj --no-restore -c Release -o /app

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2
WORKDIR /deploy
# Expose is necessary so containers can talk with each other. 
EXPOSE 80 
COPY --from=publishstage /app .
CMD ["dotnet", "OrBoard.Client.dll"]
