#!/bin/sh
dotnet new sln -n Lab2_Polymorphism
dotnet sln add Task1/Task1.csproj Task2/Task2.csproj Task5/Task5.csproj
dotnet new gitignore
dotnet build
