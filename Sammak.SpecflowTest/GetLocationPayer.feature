@Beat.Billing
@GetLocationPayer
Feature: GetLocationPayer
	In order to display the appropriate data
	As a consumer of the Billing Location Payer API 
	I want to be told the Name of the payer

Background: 
	Given the feature test is initialized

Scenario Outline: GetLocationPayer_Get Valid Payer
	Given I have a valid payer ID <payerId>
	When I make a request to the API with payer ID
	Then the status code is OK
		And The name in the record returned should be <name>

	Examples: 
	| payerId | name |
	| 1       | Ristenka  |
	| 2       | Testing  |

Scenario Outline: GetLocationPayer_Get Invalid Payer
	Given I have an invalid payer ID <invalidPayerId>
	When I make a request to the API with payer ID
	Then the status code is OK
		And The returned result is empty

	Examples: 
	| invalidPayerId |
	| 1073741823  | 

