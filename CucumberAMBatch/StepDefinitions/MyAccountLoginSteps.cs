using CucumberAMBatch.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace CucumberAMBatch.StepDefinitions
{
    //testtest
    [Binding]
    public class MyAccountLoginSteps
    {
        public IWebDriver driver;

        [BeforeScenario("only")]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }

        [AfterScenario("only")]
        public void tearDown()
        {
            driver.Quit();
        }

        [Given(@"open browser")]
        public void GivenOpenBrowser()
        {
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Window.Maximize();
        }
        
        [When(@"Enter the url ""(.*)""")]
        public void WhenEnterTheUrl(string url)
        {
            driver.Url = url;
        }
        
        [When(@"Click on My Account Menu")]
        public void WhenClickOnMyAccountMenu()
        {
            driver.FindElement(By.XPath("//a[contains(text(),'My Account')]")).Click();
            Thread.Sleep(2000);
        }

        /*[When(@"Enter registered username and password")]
        public void WhenEnterRegisteredUsernameAndPassword()
        {
            driver.FindElement(By.Id("username")).SendKeys("Championautomator@gmail.com");
            driver.FindElement(By.Id("password")).SendKeys("@Championautomator1720");
        }*/

        /*[When(@"Enter registered username ""(.*)"" and password ""(.*)""")]
        public void WhenEnterRegisteredUsernameAndPassword(string user, string pwd)
        {
            driver.FindElement(By.Id("username")).SendKeys(user);
            driver.FindElement(By.Id("password")).SendKeys(pwd);
        }*/

        /* [When(@"Enter registered ""(.*)"" and ""(.*)""")]
         public void WhenEnterRegisteredAnd(string user, string pwd)
         {
             driver.FindElement(By.Id("username")).SendKeys(user);
             driver.FindElement(By.Id("password")).SendKeys(pwd);
         }*/

        /* [When(@"Enter registered (.*) and (.*)")]
         public void WhenEnterRegistered(string user, string pwd)
         {
             driver.FindElement(By.Id("username")).SendKeys(user);
             driver.FindElement(By.Id("password")).SendKeys(pwd);
         }*/

        /* [When(@"Enter registered username and password")]
         public void WhenEnterRegisteredUsernameAndPassword(Table credentials)
         {
             var dictionary = TableExtensions.ToDictionary(credentials);
             var test = dictionary["Username"];

             driver.FindElement(By.Id("username")).SendKeys(dictionary["Username"]);
             driver.FindElement(By.Id("password")).SendKeys(dictionary["Password"]);

         }*/

       /* [When(@"Enter registered username and password")]
        public void WhenEnterRegisteredUsernameAndPassword(Table table)
        {
            var dataTable = TableExtensions.ToDataTable(table);
            foreach(DataRow row in dataTable.Rows)
            {
                driver.FindElement(By.Id("username")).SendKeys(row.ItemArray[0].ToString());
                driver.FindElement(By.Id("password")).SendKeys(row.ItemArray[1].ToString());
                driver.FindElement(By.Name("login")).Click();
                //driver.FindElement(By.Id("username")).Clear();
                //driver.FindElement(By.Id("password")).Clear();
            }
            
        }*//// <summary>
        /// ////////////////////////
        /// </summary>
        /// <param name="table"></param>

        [When(@"Enter credentials")]
        public void WhenEnterCredentials(Table table)
        {
            var dataTable = TableExtensions.ToDataTable(table);
            foreach (DataRow row in dataTable.Rows)
            {
                driver.FindElement(By.Id("username")).SendKeys(row.ItemArray[0].ToString());
                driver.FindElement(By.Id("password")).SendKeys(row.ItemArray[1].ToString());
                //driver.FindElement(By.Name("login")).Click();
               // driver.FindElement(By.Id("username")).Clear();
                //driver.FindElement(By.Id("password")).Clear();
            }
        }

        [When(@"Click on login button")]
        public void WhenClickOnLoginButton()
        {
            driver.FindElement(By.Name("login")).Click();
            Thread.Sleep(2000);
        }
        
        [Then(@"User must successfully login to the web page")]
        public void ThenUserMustSuccessfullyLoginToTheWebPage()
        {
            String text = driver.FindElement(By.XPath("//*[@id='page-36']//strong")).Text;
            Thread.Sleep(2000);
            Assert.True(text.Contains("Championautomator"));
        }

        [Then(@"Verify Login")]
        public void ThenVerifyLogin()
        {
            //strong[contains(text(),'ERROR')]
            String text = driver.FindElement(By.XPath("//*[@id='page-36']//strong")).Text;
            if (text.Contains("ERROR"))
            {
                Assert.True(text.Contains("ERROR"));
                Console.WriteLine("Message: " + text);
            }
            else
            {
                Assert.True(text.Contains("Championautomator"));
                Console.WriteLine("Message: " + text);
            }

        }

    }
}
