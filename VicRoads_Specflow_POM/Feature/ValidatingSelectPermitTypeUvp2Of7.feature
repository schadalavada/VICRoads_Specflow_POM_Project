Feature: Validate Select Permit type text is displayed	
	#Feature is to test select permit type text on UVP 2 of 7 page.

@UITest
@Browser:Chrome
Scenario Outline: Verify Select permit type text is displayed on UVP 2 of 7 page
	Given I have navigated to the UVP 1 of 7 page
	When I select Vehicle type  as "<VehicleType>"
	When I enter  Address as "<Enter Address>"
	When I select permit start date as "<PermitStartDate>"
	When I select permit duration as "<PermitDuration>"
	When I click on next button on UVP 1 of 7 page
	Then User should be navigated to UVP Step 2 of 7 Page and Select permit type text is displayed
@source:Data.xlsx:UvpData
Examples: 
| VehicleType | Enter Address | Compare Address | PermitStartDate | PemitDuration |
