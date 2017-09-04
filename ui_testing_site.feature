Feature: Regression tests for UI Testing Site
 
 	Scenario Outline: Smoke test for UI Testing Site
 		Given I opened the http://uitest.duodecadits.com url
		When I click on the <PageName> button
 		Then the title should be UI Testing Site
		And the company logo should be visible

		Example: 
			| PageName   |
			| Home page  |
			| Form page  |

	Scenario: Regression test for Home page
		Given I opened the http://uitest.duodecadits.com url
		When I click on the Home button
		Then I should get navigated to the Home page
		And the Home button should be activated

	Scenario: Regression test for Form page
		Given I opened the http://uitest.duodecadits.com url
		When I click on the Form button
		Then I should get navigated to the Form page
		And the Form button should be activated

	Scenario: Regression test for Error page
		Given I opened the http://uitest.duodecadits.com url
		When I click on the Error button
		Then I should get an error message with 404 http response code

	Scenario Outline: Functional test for Home page
		Given I opened the http://uitest.duodecadits.com url
		Then the welcome message should be <WelcomeMessage>
		And the description message should be <Description>

		Example:
			| WelcomeMessage 							  | Description 																			|
			| Welcome to the Docler Holding QA Department | This site is dedicated to perform some exercises and demonstrate automated web testing. |

	Scenario Outline: Functional test for Form page 
		Given I opened the http://uitest.duodecadits.com url
		When I click on the Form button
		Then I should get navigated to the Form page
		And the input field should be visible
		And the submit should be visible

		When I type <Value> the input field
		And I click on the submit button
		Then The home page should be visible
		And the following text should appear and equal to <Result>

		Example:
			| Value		| Result 			|
			| John	  	| Hello John!		|
			| Sophia  	| Hello Sophia! 	|
			| Charlie	| Hello Charlie!  	|
			| Emily		| Hello Emily!		|

