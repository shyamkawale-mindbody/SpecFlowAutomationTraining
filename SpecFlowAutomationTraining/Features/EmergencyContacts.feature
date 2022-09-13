@AddEmergencyContacts
Feature: EmergencyContacts
In order to reach the employee relation on emergency
As an admin
I should have access to add, edit, delete employee emergency contacts 

Background:
	Given I have browser with OrangeHrm Page

@tag1
Scenario Outline: Add Emergency Contact
	When I enter username as '<username>'
	And I enter password as '<password>'
	And I click on login
	And I click on My Info
	And I click on Emergency Contacts
	And I click on Add Assigned Emergency Contacts
	And I fill emergency contact details
		| contact_name   | relationship   | home_telephone   | mobile   | work_telephone   |
		| <contact_name> | <relationship> | <home_telephone> | <mobile> | <work_telephone> |
	And I click on save Emergency Contact
	Then I should see the added records in the table
Examples:
	| username | password | contact_name | relationship | home_telephone | mobile | work_telephone |
	| Admin    | admin123 | Jimmy        | Brother      | 1234           | 123    | 2434           |
	| Admin    | admin123 | Heisenberg   | Father       | 1234           | 123    | 2434           |
