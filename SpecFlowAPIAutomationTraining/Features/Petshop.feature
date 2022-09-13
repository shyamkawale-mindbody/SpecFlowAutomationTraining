Feature: Petshop
In order to create an environment for managing pet shop
As a user 
I want to create, edit, delete, get pet details
Background: 
	Given I have base url 'https://petstore.swagger.io/v2/' and resource 'pet/102' 

Scenario: Find Pet By Petid
	When I do the Get request
	Then I should get the response as 200 
	And I should get the pet details in json format

Scenario: Find Pet By Invalid Petid 
	When I do the Get request 
	Then I should get the response as 400 
	And I should get message as 'Invalid ID supplied'

Scenario: Find Pet By PetId which is not present 
	When I do the Get request 
	Then I should get the response as 404 
	And I should get message as 'Pet not found'

Scenario: Delete pet by petid 
	And I need add api_key 'AK888' in the header 
	When I do the Delete request 
	Then I should get the response as 200

Scenario: Delete pet by Invalid petid 
	And I need add api_key 'AK888' in the header
	When I do the Delete request 
	Then I should get the response as 400 
	And I should get message as 'Invalid ID supplied'

Scenario: Delete pet by non-existing petid 
	And I need add api_key 'AK888' in the header
	When I do the Delete request 
	Then I should get the response as 404 
	And I should get message as 'Pet not found'
