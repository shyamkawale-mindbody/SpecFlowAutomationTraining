Feature: Login

In Order to maintain the Employee Records
As a User
I want to login into the portal

Background:
	Given I have browser with OrangeHrm Page

@tag1
Scenario: Valid Credential
	When I enter username as 'Admin'
	And I enter password as 'admin123'
	And I click on login
	Then I should be navigate to 'PIM' dashboard screen

@tag2
Scenario Outline: Invalid Crredential
	When I enter username as '<username>'
	And I enter password as '<password>'
	And I click on login
	Then I should get error message as '<error_message>'
Examples:
	| username | password | error_message       |
	| shyam    | pass     | Invalid credentials |
	| ram      | pass123  | Invalid credentials |