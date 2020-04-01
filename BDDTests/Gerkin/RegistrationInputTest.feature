Feature: Registration

@mytag
Scenario: Enter vaild Email address
	Given I am on the signup page
	And I have enter a valid username of "Cathy@home.com"
	When i click off
	Then the result should see a green check mark in the box
