Hometask 9(WebUI):

The solution for the hometask is in the Hometask9 folder.
There are 2 projects present in the solution:
	WebUI: 		This one contains everything the tests need to work.

	WebUITests: 	This project contains the tests.(4 positive and 4 negative)
			The tests are in BDD style created using SpecFlow.

After the tests are run, the generated test report can be found in the
WebUITests\bin\Debug\netcoreapp3.1\TestReport\
folder. The report is generated using Extent.

The tests can be run from the command line using the following command:
dotnet test "WebUITests.dll"
The location for the WebUITests.dll file is: WebUITests\bin\Debug\netcoreapp3.1

The projects target .NET Core 3.1
	
