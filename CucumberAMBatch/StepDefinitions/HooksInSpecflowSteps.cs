using System;
using TechTalk.SpecFlow;

///test
namespace CucumberAMBatch.StepDefinitions
{
    [Binding]
    public class HooksInSpecflowSteps
    {
        [BeforeScenario]
        public void setup()
        {
            Console.WriteLine("Launch Browser");
        }

        [AfterScenario]
        public void tearDown()
        {
            Console.WriteLine("Close Browser");
        }

        [Given(@"user is on add customer page")]
        public void GivenUserIsOnAddCustomerPage()
        {
            Console.WriteLine("user is on add customer page");
        }

        [When(@"user fills customer deatils")]
        public void WhenUserFillsCustomerDeatils()
        {
            Console.WriteLine("user fills customer deatils");
        }

        [Then(@"customer is added")]
        public void ThenCustomerIsAdded()
        {
            Console.WriteLine("customer is added");
        }

        [Given(@"user is on edit customer page")]
        public void GivenUserIsOnEditCustomerPage()
        {
            Console.WriteLine("user is on edit customer page");
        }

        [When(@"user edits contact details")]
        public void WhenUserEditsContactDetails()
        {
            Console.WriteLine("user edits contact details");
        }

        [Then(@"contact details updated")]
        public void ThenContactDetailsUpdated()
        {
            Console.WriteLine("contact details updated");
        }

        [Given(@"user is on delete customer page")]
        public void GivenUserIsOnDeleteCustomerPage()
        {
            Console.WriteLine("user is on delete customer page");
        }
          
        [When(@"user delete customer")]
        public void WhenUserDeleteCustomer()
        {
            Console.WriteLine("user delete customer");
        }
        
        [Then(@"customer deleted")]
        public void ThenCustomerDeleted()
        {
            Console.WriteLine("customer deleted");  
        }
    }
}
