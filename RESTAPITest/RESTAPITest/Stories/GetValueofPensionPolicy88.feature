Feature: AlexaResponses
	As a Tester
	I want to check aviva response for pension API

@Alexa
Scenario: I do no have a Pension policy with Aviva
	Given I do not have a pension policy with Aviva on MDM
	When I ask Alexa for the value of my pension
	Then Alexa will tell me that they cannot locate a pension policy for me

Scenario:  I have an out of scope Pension policy
	Given I only have an out-of-scope pension policy with Aviva
	When I ask Alexa for the value of my pension
	Then Alexa will tell me that they cannot service valuations for my pension(s) right now

Scenario:  I have just one in-scope policy
	Given  I only have one in-scope pension policy 
	When I ask Alexa for the value of my pension
	And the value of that policy has been supplied from the api
	Then Alexa will tell me the value of the pension
	And let me know the date that valuation was calculated

Scenario:  API gives a bad response
	Given I have asked Alexa for the value of my pension policy
	When Alexa gets a bad-response from the getPensions Valuation api
	Then Alexa will tell me that my pension value is not available right now

Scenario:   API times-out
	Given I have asked Alexa for the value of my pension policy
	When the getPensions Valuation api response is time-out
	Then Alexa will tell me that my pension value is not available right now