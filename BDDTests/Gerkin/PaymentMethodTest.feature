Feature: PaymentMethod
In order to complete order
As a user
I want to choose my payment method

@mytag
Scenario: Select Valid Payment Method
Given I am on the payment method page
When I press Pay By Bank Wire
Then I should be on the Order Summary page
