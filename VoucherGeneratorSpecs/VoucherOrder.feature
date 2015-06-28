Feature: Mobile voucher order

  @app
  Background: 
	Given Following countries
	| Country   | Currency | Denominations      | VoucherCodeLength |
	| Singapore | SGD      | 5, 10, 20, 50      | 5                 |
	| India     | INR      | 5, 10, 20, 50, 100 | 6                 |

  @app
  Scenario Outline: Order voucher form
    Given the client is from <country>
	When the client wants to order vouchers
    Then the display currency should be <currency>
    And the selectable voucher denominations should be <denominations>

	Examples: 
	| country   | currency | denominations      |
	| Singapore | SGD      | 5, 10, 20, 50	    |
	| India     | INR      | 5, 10, 20, 50, 100 |

  @app
  Scenario: Submit voucher orders
    Given the client is from Singapore
    When the client orders the following vouchers
      |denomination|quantity|
      |           5|     100|
      |          10|     150|
      |          50|     200|
    Then the total face value should be 12000
    And the total number of vouchers should be 450
	And the order currency should be SGD
    #And the order should be sent for approval by staff

  @app
  Scenario: Approve voucher orders
    Given the client is from Singapore
    When the client orders the following vouchers
      |denomination|quantity|
      |           5|     100|
      |          10|     150|
      |          50|     200|
    And the order is approved
    Then the following vouchers should be generated
      |denomination|quantity|
      |           5|     100|
      |          10|     150|
      |          50|     200|
    #And each voucher code should be 5 characters long
    #And each voucher code should have alphanumeric characters
