Feature: SearchFunctionalityTest
	In order to make navigation easier
	As a user
	I want to be able to search items

@mytag
Scenario: Add two numbers
	Given I am on the home page
	And I have entered "dress" into the search bar
	When I press enter
	Then a new page with the results should be displayed
