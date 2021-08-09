mkdir bin/packages -p

root=$PWD

pushd . > /dev/null
packages=$(readlink bin/packages -f)

cd src/Nvipt.Core
dotnet pack -o $packages

popd > /dev/null

cd src/Nvipt.OTAPI
nuget pack Nvipt.OTAPI.csproj -OutputDirectory $packages -Build
