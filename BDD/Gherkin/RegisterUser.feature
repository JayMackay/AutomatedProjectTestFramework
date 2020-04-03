Feature: RegisterUser
	A user makes an account

@mytag
Scenario: I as a user want to make an account
	Given I am on the sign up page
	And I have entered a valid email
	And I have enterd valid details
	When I press Register
	Then the result should be on the my account page
