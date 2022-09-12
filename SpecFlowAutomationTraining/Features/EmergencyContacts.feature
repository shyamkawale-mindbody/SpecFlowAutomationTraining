Feature: Feature1

A short summary of the feature

@tag1
Scenario Outline: Add Emergency Contact
	Given I have a browser with orangehrm page
	When I enter username as '<username>'
	And I enter password as '<password>'
	And I click on login
	And I click on My Info
	And I click on Emergency Contacts
	And I click on Add
	And I fill emergency contact details
		| name   | relationship   | home_telephone   | mobile   | work_telephone   |
		| <name> | <relationship> | <home_telephone> | <mobile> | <work_telephone> |
	And I click on save
	Then I shopuld be navigated to view emergency contacts section
Examples:
	| username | password | name       | relationship | home_telephone | mobile | work_telephone |
	| Admin    | admin123 | Jimmy      | Brother      | 1234           | 123    | 2434           |
	| Admin    | admin123 | Heisenberg | Father       | 1234           | 123    | 2434           |
