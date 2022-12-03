Feature: TMFeature

As a Turnup portal user
I would like to create, edit, and delete both Time and Material records
So that I can manage an employee's Time and Material successfully

#did not pass parms to create a record to show code with hard-coded data
Scenario: Create a Time record with valid data
	Given I logged into Turnup portal successfully
	When I navigate to Time and Materials page
	And I create a new Time record
	Then The Time record was created successfully

Scenario Outline: Edit existing Time record with valid data
	Given I logged into Turnup portal successfully
	When I navigate to Time and Materials page
	And I update Time record containing code '<ExistingCode>' with '<NewCode>'
	Then The Time record code was updated successfully with '<NewCode>'

Examples:
| ExistingCode        | NewCode             |
| my time code        | my edited time code |
| my edited time code | my 2nd ed time code |
| my 2nd ed time code | my 3rd ed time code |

Scenario Outline: Delete existing Time record
	Given I logged into Turnup portal successfully
	When I navigate to Time and Materials page
	And I delete existing Time record with code of '<ExistingCode>'
	Then The Time record with code '<ExistingCode>' was deleted successfully

Examples:
| ExistingCode        |
| my 3rd ed time code |