mkdir bin/packages -p

pushd .
packages=$(readlink bin/packages -f)

cd src/Nvipt.Core
dotnet build -o $packages

popd > /dev/null

cd src/Nvipt.OTAPI
nuget pack -OutputDirectory $packages
