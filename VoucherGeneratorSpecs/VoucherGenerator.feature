Feature: VoucherGeneration
	In order to generate vouchers
	As a Voucher Issuance Engine
	I want to use automated order placement system with feedback

Scenario: Calculate Total Amount for denominations
	Given I have entered denominations details
	When I press Done
	Then I should see total amount $100 and message that says "Proceed for Payment"

Scenario: Issue Vouchers of specified denominations
	Given
	When
	Then