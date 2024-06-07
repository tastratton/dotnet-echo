# dotnet-echo

**Minimal .NET HTTP echo server.**

This repository is a boilerplate for an as-simple-as-possible .NET HTTP server.

## Commands

```sh
# restore packages
dotnet restore

# run app locally
dotnet run

# create release build
dotnet publish -c release -o out

# build image and run container
docker build --rm -t echo .
docker run -p 5000:5000 -it --rm echo
```

## License

This project is a derivative work of https://github.com/MarkTiedemann/dotnet-echo

It retains the original license terms noted below.

> [WTFPL](http://www.wtfpl.net/) – Do What the F*ck You Want to Public License.
> 
> Made with :heart: by [@MarkTiedemann](https://twitter.com/MarkTiedemannDE).

See [CHANGELOG](CHANGELOG.md) for changes.

Note: dockerfile has not been updated for this version as I'm not currently using Docker for this.