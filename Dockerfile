FROM microsoft/dotnet:2.0.0-runtime

WORKDIR /app
COPY out .

ENV ASPNETCORE_URLS http://*:5000

ENTRYPOINT dotnet echo.dll