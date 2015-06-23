Feature: OrderingVouchers

Scenario: Validate order and denomination
	Given I have mentioned the total amount
	And I have specified equivalent denomination values
	When I press buy
	Then the validation result should appear on screen
