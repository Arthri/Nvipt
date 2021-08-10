mkdir bin/packages -p

config=${1-"debug"}
root=$PWD

pushd . > /dev/null
packages=$(readlink bin/packages -f)

cd src/Nvipt.Core
dotnet build -c $config
dotnet pack -o $packages -c $config --no-build

popd > /dev/null

cd src/Nvipt.OTAPI
nuget pack Nvipt.OTAPI.csproj -OutputDirectory $packages -Build -Properties Configuration=$config
