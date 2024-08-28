from mcr.microsoft.com/dotnet/sdk:8.0 as SDK
workdir /app
run dotnet new console -n MenuDotnet -o App
copy ./Program.cs /app/App
workdir /app/App
run dotnet publish -c Release -o /app/out
from mcr.microsoft.com/dotnet/runtime:8.0
copy --from=SDK /app/out .
entrypoint dotnet MenuDotnet.dll
