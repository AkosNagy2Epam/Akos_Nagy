Feature: GetBooking
	We can get details of a booking

@mytag
Scenario: Getting data of an existing booking
	Given a booking exists with first name "Keith"
	And last name "Flint"
	When we request its data using its ID
	Then we should get a confirmation code of 200 and data with the correct name

	Scenario: Trying to get data of a booking that doesn't exist
	Given a booking ID that is not associated with any existing booking
	When we request the booking data using this ID
	Then we should get an error code of 404