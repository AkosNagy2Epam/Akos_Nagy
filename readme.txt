Hometask(WebUI):

The solution for the hometask is in the Hometask9 folder.
There are 2 projects present in the solution:
	WebUI: 		This one contains everything the tests need to work.

	WebUITests: 	This project contains the tests.(4 positive and 4 negative)
			The tests are in BDD style created using SpecFlow.

After the tests are run, the generated test report can be found in the
WebUITests\bin\Debug\netcoreapp3.1\TestReport\
folder. The report is generated using Extent.

The tests can be run from the command line using the following command:
dotnet test WebUITests.dll
The location for the WebUITests.dll file is: WebUITests\bin\Debug\netcoreapp3.1

The projects target .NET Core 3.1

The tests work with all the different languages of the tested website UI.

_______________________________________

The WebUI hometask were:

General requirements:

Open https://opensource-demo.orangehrmlive.com/
    Your script must log in to the site with the credentials specified above input form (input is case-sensitive - if spaces are present).

 
Scenario 1:
    Add a New record (Go to Admin -> Job - Pay Grades -> Click on the Add button)
        Add RandomName
        Save changes
    Click on Add button in the section Assigned Currencies
        Select Currency
        Add Minimum and Maximum Salary
        Save changes          
    Check that your changes are visible on the Currencies block [check Currency fields with Minimum/Maximum Salary]
 

Scenario 2:
    Add a New record (Go to Admin -> Job - Pay Grades -> Click on the Add button)
        Add RandomName
        Save changes
    Click on Add button in the section Assigned Currencies
        Select Currency
        Add Minimum and Maximum Salary
        Click on the Cancel button
    Check that data is not visible on the Pay Grades page [check Name and Currency fields]

 
Write a script after the scenario: Delete your created data and make sure your field is removed.

What affects the assessment:
	Write a script
	Instruction in Readme
	Connect Report for tests
	Running from the command line
	Application of OOP principles (+SOLID)
	Design Patterns (as an example = Page Object, Builder, Factory)
	Use SpecFlow
