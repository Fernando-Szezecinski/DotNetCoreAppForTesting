FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 as base
WORKDIR /app
COPY . .

CMD ASPNETCORE_URLS=http://*:$PORT dotnet DotNetCoreAppForTesting.dll