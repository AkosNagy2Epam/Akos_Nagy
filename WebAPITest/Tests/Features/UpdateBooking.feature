Feature: UpdateBooking
	We can update data of an existing booking

@mytag
Scenario: Update an existing booking with valid data
	Given a new first name of "Tony"
	And a new last name of "Kakko"
	And a new total price of 110
	And a new deposit being paid value of "true"
	And a new check in date of "2022-02-02"
	And a new check out date of "2022-02-22"
	And a new additional need of "Dinner"
	And we have a valid token for authentication
	And we have the id of an existing booking
	When we send a request to update the booking using the token and the ID
	Then the response should contain a confirmation code of 200

Scenario: Trying to update an existing booking with missing data
	Given we have a new first name of "Tony"
	And we have a new last name of "Kakko"
	And we have a new deposit being paid value of "true"
	And we have a new check in date of "2022-02-02"
	And we have a new check out date of "2022-02-22"
	And we have a new additional need of "Dinner"
	And also a valid token for authentication
	And we also have the id of an existing booking
	When a request is sent to update with no price data using the token and the ID
	Then the response should contain an error code of 400