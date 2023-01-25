
Feature: SalaryGrade
	You can add salary grades to a pay grade record.
	A salary grade specifies the used currency and the minimum and maximum salaries.


Scenario: Add new salary grade
	Given I am logged in to the site
	And I registered a new pay grade name
	And I am on the Edit Pay Grades page with entered data for a new salary grade
	When I click on the save salary grade button
	Then the entered minimum and maximum salary should be saved and displayed
	
Scenario: Cancel adding new salary grade
	Given I am logged in to the site
	And I registered a new pay grade name
	And I am on the Edit Pay Grades page with entered data for a new salary grade
	When I click on the cancel pay grade button
	Then I shouldn't see the entered salary data on the Pay Grades page 