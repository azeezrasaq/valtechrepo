Feature: Booking a flight 

As a cheapflight user 
I want to book a flight 
so that i can travel to my destination 


Scenario: Check that user can book a flight 

Given that i am on cheapflight website 
When i enter my current location and destination 
And i select return type and click on search flight 
Then i should be able to book a flight successfully 

Scenario: Check that flight results are displayed as expected 
Given that i am on cheapflight website 
When i enter my current location and destination 
And i select return type and click on search flight 
Then i should be able to see the expected flights result correctly 

Scenario: Verify that user contact details can be saved for ease of use
Given that i am on cheapflight website 
When i login to cheapflights 
When i enter my current location and destination 
And i select dates and return type 
And click on view deals 
Then i should be able to save my details 