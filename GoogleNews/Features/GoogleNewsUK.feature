Feature: Google News UK 

@tearDown
Scenario: To test whether the UK section always shown in the page
	Given the user landed in the google news uk homepage
	Then the user should see the UK section 


Scenario: To test whether the image is displayed next to every news story
	Given the user landed in the google news uk homepage
	Then the user should see the image next to every news story


