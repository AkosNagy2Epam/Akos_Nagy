Feature: DeleteBooking
	We can delete a booking from the system

@mytag
Scenario: Delete an existing booking
	Given an ID that is associated with an existing booking
	And a valid authentication token is present
	When a request is sent to delete a booking using the ID and the token
	Then the response contains a confirmation code of 201

Scenario: Trying to delete a booking that doesn't exist	
	Given a valid authentication token is obtained
	And an ID that is not associated with any existing booking
	When a request is sent to delete using the ID and the token
	Then the response contains an error code of 405