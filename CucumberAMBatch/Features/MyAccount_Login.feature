Feature: MyAccount_Login Feature
	This feature will test a login functionality

#Simple login without parameter
#Scenario: Log-in with valid username and password
#	Given open browser
#	When Enter the url "http://practice.automationtesting.in/"
#	And Click on My Account Menu
#	And Enter registered username and password
#	And Click on login button
#	Then User must successfully login to the web page

#Simple login with examples and keywords
#Scenario Outline: Log-in with valid username and password
#	Given open browser
#	When Enter the url "http://practice.automationtesting.in/"
#	And Click on My Account Menu
#	And Enter registered <username> and <password>
#	And Click on login button
#	Then Verify Login

#	Examples:
#	| username                    | password              |
#	| Championautomator@gmail.com | @Championautomator1720 |
#	| Championautomator@gmail.com | @test123               |
#	| Championautomator@gmail.com | yyyyytest123           |

#Simple login with data table
#Scenario: Log-in with valid username and password
#	Given open browser
#	When Enter the url "http://practice.automationtesting.in/"
#	And Click on My Account Menu
#	And Enter registered username and password
#	|Key     |Value                      |
#	|Username|Championautomator@gmail.com|
#	|Password|@Championautomator1720     |
#	And Click on login button
#	Then User must successfully login to the web page

#Simple login with multiple data table
@only
Scenario: Log-in with valid username and password
	Given open browser
	When Enter the url "http://practice.automationtesting.in/"
	And Click on My Account Menu
	And Enter credentials
	|Username     |Password |
	|Championautomator@gmail.com|@Championautomator1720 |
	And Click on login button
	Then User must successfully login to the web page
	