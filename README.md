# dotnet-echo-server

**Barebones .NET echo server.**

## Commands

- To start the app:

```
dotnet restore
dotnet run
```

- To start the app in a `docker` container:

```
dotnet restore
dotnet publish -c Release -o out
docker build -t dotnet-echo-server .
docker run -p 5000:5000 -it --rm dotnet-echo-server
```

## Miscellaneous

This project was generated using the `dotnet` CLI:

```
dotnet new web --framework netcoreapp1.1 --name dotnet-echo-server
```

## License

[WTFPL](http://www.wtfpl.net/) – Do What the F*ck You Want to Public License.

Made with :heart: by [@MarkTiedemann](https://twitter.com/MarkTiedemannDE).