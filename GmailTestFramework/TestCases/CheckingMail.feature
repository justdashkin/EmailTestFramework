Feature: CheckingMail

Scenario: Send and check mail
	Given I open login page
	When I login
	Then My profile should be opened
	When I create new message
	When I address message to "looksliketestuser@gmail.com"
	When I print subject "looks like test subject"
	When I print message: "Looks like awesome email!"
	When I send mail
	When I find message
	Then Sender is expected sender
	Then Subject is expected subject
	Then Message is expected message