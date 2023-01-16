Feature: CreateBooking
	We can create a new booking

@mytag
Scenario: Create a new booking with valid inputs
	Given a booking with first name "Ville"
	And with last name "Valo"
	And with last total price 110
	And with the deposit being paid is "true"
	And with check in date "2022-02-02"
	And with check out date "2022-02-22"
	And with additional needs of "Dinner"
	When the request is sent to register the booking
	Then the response should confirm the booking got created

Scenario: Try creating a new booking with price field missing
	Given an incomplete booking with first name "Kis"
	And also with last name "Kacsa"
	And also with the deposit being paid is "false"
	And also with check in date "2022-02-03"
	And also with check out date "2022-02-23"
	And also with additional needs of "extra pillow"
	When the request is sent to register the booking with a missing field
	Then the response should show the creating process has failed