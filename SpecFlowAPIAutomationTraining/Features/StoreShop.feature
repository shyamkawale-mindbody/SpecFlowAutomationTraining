Feature: StoreShop
In order to create an environment for managing pet shop
as a user
I want to handle the orders

Scenario: Find Purchase Order By Id
Given I have base url 'https://petstore.swagger.io/v2/' and resource with orderid  'store/order/1'
When I do get rquest
Then I should get the response as 200 

Scenario: Find Order By Non-Existing Id
Given I have base url 'https://petstore.swagger.io/v2/' and resource with orderid  'store/order/1'
When I do get rquest
Then I should get the response as 404
