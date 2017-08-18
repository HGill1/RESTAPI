Feature: Alexa Responses for unsupported product
	As a Aviva pension holder I have linked my Amazon and MyAviva accounts so 
	I want to check alexa Responses for unsupported product

@Alexa
Scenario: Launch Skill and receive personal welcome that I have one unsupported policy
	Given  I have one policy that is an unsupported product 
	And I request Alexa the value of my pension
	When  I give my correct PIN  
	Then  I will receive following responses
	| I will be told I have one unsupported policy              |
	| the product name is "productGroup" is "policyDisplayName" |
	| have a great morning                                      |
	| my session will close                                     |
