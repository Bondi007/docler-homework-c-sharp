Feature: Automated UI testing of http://uitest.duodecadits.com based on the given specification

Background: Background step
Given The user opens http://uitest.duodecadits.com

@DoclerTests
Scenario: CTC1 - Check logo and title - Form Page
	When The user clicks on Form button in the upper Menu
	Then The user is navigated to the Form page
	And Page title is UI Testing Site
	And Company logo is displayed

@DoclerTests
Scenario Outline: CTC2 - Check logo and title - Form Page - after submitting the name
	When The user clicks on Form button in the upper Menu
	Then The user is navigated to the Form page
	And The user types "<username>" in the input box
	And The user clicks on Submit button
	And Page title is UI Testing Site
	And Company logo is displayed
 Examples:
 | username |
 | Test |

@DoclerTests
Scenario: CTC3 - Check logo and title - Home Page
	When The user clicks on Home button in the upper Menu
	Then The user is navigated to the Home page
	And Page title is UI Testing Site
	And Company logo is displayed


@DoclerTests
Scenario: CTC4 - Test UI Testing Page - Check if it navigates to Home page
	When The user clicks on UI Testing button in the upper Menu
	Then The user is navigated to the Home page

@DoclerTests
Scenario: CTC5 - Test Error Page
	When The user clicks on Error button in the upper Menu
	Then The user is navigated to the Error page
	And The user gets Error File not found message

@DoclerTests
Scenario: CTC6 - Test Home Page - Check if Home menu turns to active status
	When The user clicks on Home button in the upper Menu
	Then The user is navigated to the Home page
	And Home menu turns to active status	

@DoclerTests
 Scenario: CTC7 - Test Home Page - Check if the correct header and paragraph are displayed
	When The user clicks on Home button in the upper Menu
	Then The user is navigated to the Home page
	And Correct Header and Paragraph is displayed	

@DoclerTests
 Scenario: CTC8 - Test Form Page - Check if Input box and Submit button are displayed
	When The user clicks on Form button in the upper Menu
	Then The user is navigated to the Form page
	And The input form and submit button is displayed

@DoclerTests 
 Scenario: CTC9 - Test Form Page - Check if Form menu turns to active status
	When The user clicks on Form button in the upper Menu
	Then The user is navigated to the Form page
	And Form menu turns to active status

@DoclerTests 
 Scenario Outline: CTC10 - Test Form Page - Test submitting different names
	When The user clicks on Form button in the upper Menu
	Then The user is navigated to the Form page
	And The user types "<username>" in the input box	
	And The user clicks on Submit button
	And Page displays Hello "<username>"! message
 Examples:
 | username |
 | John |
 | Sophia |
 | Charlie |
 | Emily |

 