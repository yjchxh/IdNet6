#!/usr/bin/env bash
set -euo pipefail

rm -rf nuget
mkdir nuget

dotnet tool restore

pushd ./src/Storage
chmod +x build.sh
./build.sh "$@"
popd

pushd ./src/IdNet6
chmod +x build.sh
./build.sh "$@"
popd

pushd ./src/EntityFramework.Storage
chmod +x build.sh
./build.sh "$@"
popd

pushd ./src/EntityFramework
chmod +x build.sh
./build.sh "$@"
popd

pushd ./src/AspNetIdentity
chmod +x build.sh
./build.sh "$@"
popd
