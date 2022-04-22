# Setup instruction

## Pre-requirements

1. .NET SDK
2. Installing SpecFlow.Plus.LivingDoc.CLI
	- Run `dotnet tool install --global SpecFlow.Plus.LivingDoc.CLI` command

## Steps

1. Run `dotnet build` command
2. Run `dotnet test` command
	- This command will output tests results in terminal
3. Run `livingdoc test-assembly UpworkTest.SpecFlow/bin/Debug/net6.0/UpworkTest.SpecFlow.dll --output Report.html` command
	- This command will generate file Report.html with all Specflo documentation represented in web page
