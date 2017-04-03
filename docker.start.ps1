Write-Host Restoring packages -Foreground Blue
dotnet restore

Write-Host Building release -Foreground Blue
dotnet publish -c Release -o out

Write-Host Building image -Foreground Blue
docker build --tag dotnet-echo-server .

Write-Host Running container -Foreground Blue
docker run -p 5000:5000 -it --rm dotnet-echo-server