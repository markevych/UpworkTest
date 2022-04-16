Feature: Registration

Creates users in database and checks if registration process is possible for current user

@tag1
Scenario: Allowed registration for new users
	Given The email of user is example@site.com
	When user with such email doesn't exist in database
	Then user is allowed to be registered in application

Scenario: Not allowed registration for new users
	Given The email of user is example@site.com
	When user with such email exists in database
	Then user is not allowed to be registered in application
