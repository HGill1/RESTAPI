Feature: Alexa Close session during day
	As a Aviva pension holder I have linked my Amazon and MyAviva accounts so 
	I want close the session

@Alexa
Scenario: Close session during the day
	Given  a MyAviva skill session is open
	When I say "Alexa stop" 
	Then Alexa will say "Have a good morning"
	And my session will close
