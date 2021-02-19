Feature:Update Customer Details
	
@TC_UpdateFirstName
Scenario: Registered customer updates personal information - first name

	Given launch "chrome" browser
	When I navigate to "Automation Test" website
	Then I verify "home" page is displayed
	When I click on SignIn button
	And I login to the portal with the following details
	| Email		 | Password |
	| adminemail | adminpwd |
	Then I verify "my account" page is displayed
	When I click on "My Personal Information"
	Then I verify "Personal Information" page is displayed
	When I update first name to "Lavanyaa"
	Then I enter password
	When I click on "Save"
    Then I verify personal information is successfully updated
	And close the browser




	
	