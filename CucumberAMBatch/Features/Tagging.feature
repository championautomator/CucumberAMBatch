Feature: Tags in Specflow

@sanity
Scenario: Verify login
Given This is valid login test

@sanity @End2End
Scenario: Verify logout
Given This is logout test

@RegressionTest
Scenario: Verify search
Given This is search test

@RegressionTest @End2End
Scenario: Verify advanced search
Given This is advanced serach test

@End2End
Scenario: Verify prepaid recharge
Given This is prepaid recharge test

@End2End
Scenario: Verify post paid recharge
Given This is post paid recharge test

