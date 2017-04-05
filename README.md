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
docker build -t echo .
docker run -p 5000:5000 -it --rm echo
```

## License

[WTFPL](http://www.wtfpl.net/) – Do What the F*ck You Want to Public License.

Made with :heart: by [@MarkTiedemann](https://twitter.com/MarkTiedemannDE).