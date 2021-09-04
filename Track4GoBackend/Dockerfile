FROM mcr.microsoft.com/dotnet/sdk:3.1-alpine AS build-api

ARG BUILD_CONFIGURATION=Debug
ENV ASPNETCORE_ENVIRONMENT=Development
ENV DOTNET_USE_POLLING_FILE_WATCHER=true  
ENV ASPNETCORE_URLS=http://+:5001  

RUN mkdir -p /usr/src/Track4GoBackend

WORKDIR /usr/src/Track4GoBackend

COPY . .

RUN dotnet build Track4GoBackend.sln

WORKDIR /usr/src/Track4GoBackend/Track4GoApi

EXPOSE 5001

ENTRYPOINT ["dotnet", "run","--project", "Track4GoApi.csproj"]


