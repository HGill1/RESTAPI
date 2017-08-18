Feature: Pension Plan
	As a Aviva customer
	I want to check my pension plan

@AlexaPOC
Scenario: Validating pension plan
	Given I have pension plan with Aviva
	When I check my pension plan
	Then I can see my pension plan
	And  my fund value is "19874.03"
