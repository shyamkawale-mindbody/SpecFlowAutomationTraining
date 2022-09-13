@AddEmployee
Feature: Employee
In order to add, edit, delete employee records
As an admin
I want to modify the employee details in dashboard

@low @smoke
Scenario: Add Valid Employee
	Given I have browser with OrangeHrm Page
	When I enter username as 'Admin'
	And I enter password as 'admin123'
	And I click on login
	And I click on PIM
	And I click on Add Employee
	And I fill the add employee section
		| firstname | middlename | lastname | employee_id | toggle_login_detail | username | password    | confirm_password | status   |
		| Shyam     | Vilas      | Kawale   | 1001        | on                  | Shyam    | Welcome@123 | Welcome@123      | disabled |
	And I click on save employee
	Then I should be navigate to personal section with added emplyee records
