Feature: RegistrationTest
	In order to login on the site
	As a useer
	I want to input a valid email address

@mytag
Scenario: Registration
	Given I have entered an invalid email address
	When I press create an account
	Then the an invalid message should be displayed
