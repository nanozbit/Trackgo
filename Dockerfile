FROM postgres:13.4-alpine

FROM mcr.microsoft.com/dotnet/sdk:3.1.18-alpine3.13

RUN mkdir -p /usr/src/track4go

WORKDIR /usr/src/track4go

COPY Track4GoBackend .

RUN dotnet build

EXPOSE 5001

CMD ["dotnet", "run --project ./Track4GoBackend/Track4GoApi/Track4GoApi.csproj"]

