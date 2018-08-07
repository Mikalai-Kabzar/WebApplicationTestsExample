Feature: Login

Scenario: 01 - Error message on login with empty credentials
	Given User sign in with login "" and password ""
	Then User sees following error message: "Логин не указан"

Scenario: 02 - Error message on login with missing password
	Given User sign in with login "login" and password ""
	Then User sees following error message: "Пароль не указан"
