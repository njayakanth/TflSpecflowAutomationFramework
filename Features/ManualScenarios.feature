Feature: Manual scenarios for TFL website

#Manual scenarios

	Scenario: Validate change time  
	Given I am on the TFL home page
	When I click on Plan a journey tab
	When I click on change time button
	Then the leaving tab should be selected
	And Arriving tab should be unselected
	And date drowdown should be selected with Today
	And the current time should be selected
	When I select the arriving tab 
	Then date drowdown should be pre selected with Today
	And the current time should be pre selected

	Scenario: Validate recent tab 
	Given I am on the TFL home page
	When I click on Plan a journey tab
	When I enter the text 'Seven Kings' in From text field
	And I click on the 'Seven Kings, Ilford, UK' from the search suggestion
	And I enter the text 'East Ham' in To text field
	And I click on the 'East Ham Underground Station' from the search suggestion
	And I click on Plan my journey button
	Then I should be on journey results screen
	When I click on add favourites
	Then I should see favourites journeys section on star overylay 
	And I should see the my places section on overylay 
	When I click on the favourites journeys Star
	Then star should be selected
	When I click on done button 
	Then star overylay screen should be closed
	When I click on Edit button in My Journeys overlay
	Then star overylay screen should be opened

	Scenario: Validate the performace of the plan a journey in slow internet 
	Given I am on the TFL home page
	When I click on Plan a journey tab
	When I enter the text 'Manor park' in From text field
	And I click on the 'Manor Park Rail Station' from the search suggestion
	And I enter the text 'Goodmayes' in To text field
	And I click on the 'Goodmayes Rail Station' from the search suggestion
	And I click on Plan my journey button
	Then I should be on journey results screen