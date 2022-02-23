#!/usr/bin/env bash

cd nuget
dotnet nuget push ./*.nupkg --api-key "$1" --source https://api.nuget.org/v3/index.json --skip-duplicate