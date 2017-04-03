FROM microsoft/dotnet:1.1.1-runtime
LABEL name dotnet-echo-server

WORKDIR /app
COPY out .

ENV ASPNETCORE_URLS http://*:5000
EXPOSE 5000

ENTRYPOINT ["dotnet",  "dotnet-echo-server.dll"]