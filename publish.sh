#!/usr/bin/env bash

. .env

dotnet pack -c Release || exit 1

read -r -d '' PROJECTS <<- EOF
Domain.Abstractions
Domain.Models
Exceptions
Misc
TestUtils
Messaging.Contracts
EOF

echo "$PROJECTS" | while read proj;
do
    directory="$(pwd)"
    cd "$proj"

    dotnet nuget push \
    .build/bin/Release/Filebin.Shared.$proj.$current_version.nupkg \
    -k $NUGET_API_KEY \
    -s https://api.nuget.org/v3/index.json

    cd "$directory"
done