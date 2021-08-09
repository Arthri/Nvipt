mkdir bin/packages -p

config=${1-"debug"}
root=$PWD

pushd . > /dev/null
packages=$(readlink bin/packages -f)

cd src/Nvipt.Core
dotnet pack -o $packages -c $config

popd > /dev/null

cd src/Nvipt.OTAPI
nuget pack Nvipt.OTAPI.csproj -OutputDirectory $packages -Build -Properties Configuration=$config
