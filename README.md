WebAPI Hometask:

The solution for the hometask is in the WebAPITest folder.
There are 2 projects present in the solution:
	WebAPITest: This one contains everything the tests need to work.

	Tests: 	This project contains the tests.(4 positive and 4 negative)
		The tests are in BDD style created using SpecFlow.

		After the tests are run, the generated test report can be found in the
		WebAPITest\Tests\bin\Debug\netcoreapp3.1\TestReport\
		folder. The report is generated using Extent.
	
The postman folder contains the exported postman collection which has 8 requests that correspond to the 8 tests.
_____________________________________________
_____________________________________________

The WebAPI HomeTask were: 

Create API tests for the following Web API https://restful-booker.herokuapp.com/apidoc/index.html.

Detailed description: https://restful-booker.herokuapp.com/

Requirements:

·        cover with tests ONLY CRUD operations;

·        at least 2 tests for each operation – 1 positive and 1 negative;

·        positive tests should validate the response for successful status code and expected response content. For example, you are getting exactly the same booking that we created before;

·        negative tests should follow the same approach as positive tests but validate unsuccessful status code(e.g. 400, 401, 500, etc.) and expected error messages.

Note: please create the Postman collection and commit it as well.

How the score is calculated:

   Each scenario 
   
   Add test results reporter
   
   Instructions for your project in Readme file 
   
   Tests in BDD style
