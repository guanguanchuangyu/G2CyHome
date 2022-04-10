del /f /s /q nupkgs\*.*

dotnet build ../src/G2CyHome.sln -c Release

dotnet pack ../src/G2CyHome.Core/G2CyHome.Core.csproj -c Release --output nupkgs
dotnet pack ../src/G2CyHome.EntityConfiguration/G2CyHome.EntityConfiguration.csproj -c Release --output nupkgs
dotnet pack ../src/G2CyHome.Server/G2CyHome.Server.csproj -c Release --output nupkgs

start "" nupkgs
exit