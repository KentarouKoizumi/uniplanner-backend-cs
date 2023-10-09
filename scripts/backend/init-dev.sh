#!/bin/bash

rm -fR Api/bin/ && rm -fR Api/obj/

cd /dotnet-app && dotnet run --project Api