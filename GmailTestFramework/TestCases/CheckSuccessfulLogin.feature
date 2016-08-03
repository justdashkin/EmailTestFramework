Feature: Check successful login

Scenario: Verify that login and sending messages are successful
	Given I open login page
	When I login
	When I create new message