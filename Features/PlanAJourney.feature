Feature: Plan Your Journey functinality in TFL website

A short summary of the feature

Background: 
	Given I am on the TFL home page
	When I click on Plan a journey tab
	Then I should be on Plan a journey page

@tag1
Scenario: Validate plan our journey
	When I enter the text 'Leicester' in From text field
	And I click on the 'Leicester Square Underground Station' from the search suggestion
	And I enter the text 'Covent' in To text field
	And I click on the 'Covent Garden Underground Station' from the search suggestion
	And I click on Plan my journey button
	Then I should be on journey results screen
	And I should see the Walking and cycling time

	When I click on Edit preferences button
	Then I should see the show me section
	When I select the Routes with least walking radio button
	And I select the Update Journey button
	Then I should see the journey time in results page

	When I click on view details button
	Then I should see the complete access information

	Scenario: Validate the widgets behaviour when an invalid journey is planned
	When I enter the text 'LeicesterWrong' in From text field
	And I enter the text 'CoventInvalid' in To text field
	And I click on Plan my journey button
	Then I should see more than one location marching message

	Scenario: Validate the widgets behaviour when no locations are entered
	When I click on Plan my journey button
	Then I should see an error message under From text field
	And I should see an error message under To text field


	