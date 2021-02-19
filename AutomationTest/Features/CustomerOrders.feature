Feature:Order T-Shirt and Verify Order History
	
@TC_OrderTShirtAndVerifyOrder
Scenario: Order T-Shirt and Verify Order History

	Given launch "chrome" browser
	When I navigate to "Automation Test" website
	Then I verify "home" page is displayed
	When I click on SignIn button
	And I login to the portal with the following details
	| Email		 | Password |
	| adminemail | adminpwd |
	Then I verify "my account" page is displayed
	When I click on "T-Shirts"
	Then I verify "T-shirts" page is displayed
	Then I hover mouse and click Add to cart
	Then I verify product added successfully
	When I click on "Proceed to checkout"
	Then I verify "Shopping summary" page is displayed
	When I click on "standard checkout"
	Then I verify "ADDRESSES" page is displayed
	When I click on "Process Address"
	Then I verify "SHIPPING" page is displayed
	When I click on "Agree Terms"
	When I click on "Process Shipping"
	Then I verify "Payment" page is displayed
	When I click on "Pay by bank wire"
	When I click on "Confirm Order"
	Then I verify "Order Confirmation" page is displayed
	Then I get order reference
	When I click on "Back to orders"
	Then I verify "ORDER HISTORY" page is displayed
	And I verify order in order history
	And close the browser
	
	




	
	