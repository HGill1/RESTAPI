Feature: Alexa Responses for supported pension
	As a Aviva pension holder I have linked my Amazon and MyAviva accounts so 
	I want to check alexa Responses  for supported pension

@Alexa
Scenario: Launch Skill and receive personal welcome
	Given This is the first time I am using the skill
	When I open the skill 
	Then I will receive my first-time welcome message

Scenario:   My PIN is correct and I have only one supported pension
	Given I have one supported pension
	And I have launched the skill
	When  I give my correct PIN 
	Then I will receive following responses
	| receive a personalised affirmation                   | Thanks Harry, that’s correct                                           |
	| functionality for pension                            | At the moment, I can let you know the latest value of your pension     |
	| new features/products are coming soon                | but new features for pensions and other Aviva products are coming soon |
	| asked whether I want to hear the value of my pension | Would you like me to tell you the latest value of your pension?        |                                                                  

Scenario:I have one supported pension and I want to know the value of it
	Given I launch the skill
	And I give my correct PIN
	When I am asked whether I want to know the value of my pension
	Then I receive following responses
	| value of my policy in whole numbers |
	| have a great morning                |
	| my session will close               |

Scenario:  I have one supported pension and I don't want to know the value of it
	Given I launch the skill
	And I give my correct PIN
	When I am asked whether I want to know the value of my pension
	Then  I am told to have a great morning
	And my session will close
