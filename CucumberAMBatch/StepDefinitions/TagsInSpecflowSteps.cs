using System;
using TechTalk.SpecFlow;

namespace CucumberAMBatch.StepDefinitions
{
    [Binding]
    public class TagsInSpecflowSteps
    {
        [Given(@"This is valid login test")]
        public void GivenThisIsValidLoginTest()
        {
            Console.WriteLine("This is valid login test");
        }
        
        [Given(@"This is logout test")]
        public void GivenThisIsLogoutTest()
        {
            Console.WriteLine("This is logout test");
        }
        
        [Given(@"This is search test")]
        public void GivenThisIsSearchTest()
        {
            Console.WriteLine("This is search test");
        }
        
        [Given(@"This is advanced serach test")]
        public void GivenThisIsAdvancedSerachTest()
        {
            
        }
        
        [Given(@"This is prepaid recharge test")]
        public void GivenThisIsPrepaidRechargeTest()
        {
            
        }
        
        [Given(@"This is post paid recharge test")]
        public void GivenThisIsPostPaidRechargeTest()
        {
            
        }
    }
}
