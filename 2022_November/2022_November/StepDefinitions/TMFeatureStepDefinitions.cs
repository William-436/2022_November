using System;
using TechTalk.SpecFlow;

namespace _2022_November.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
        // create page object initializations and definitions
        LoginPage loginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        TMPage tmPageObj = new TMPage();

        [Given(@"I logged into Turnup portal successfully")]
        public void GivenILoggedIntoTurnupPortalSuccessfully()
        {
            // open Chrome browser because of using OpenQA.Selenium.Chrome; statement at top of code
            driver = new ChromeDriver();

            loginPageObj.LoginActions(driver);
        }

        [When(@"I navigate to Time and Materials page")]
        public void WhenINavigateToTimeAndMaterialsPage()
        {
            homePageObj.GoToTMPage(driver);
        }

        [When(@"I create a new Time record")]
        public void WhenICreateANewTimeRecord()
        {
            // create a new Time record in the Time and Material module
            tmPageObj.CreateTime(driver);
        }

        [Then(@"The Time record was created successfully")]
        public void ThenTheTimeRecordWasCreatedSuccessfully()
        {
            // check if new time record has been created successfully
            // find and click on the Go to the last page button
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")).Click();
            Thread.Sleep(2000);

            string lastRowActualCode = tmPageObj.GetCode(driver);
            string lastRowActualDescription = tmPageObj.GetDescription(driver);
            string lastRowActualPrice = tmPageObj.GetPrice(driver);
            
            Assert.That(lastRowActualCode == "my time code", "Actual time code and expected time code do not match");
            Assert.That(lastRowActualDescription == "my time description", "Actual time description and expected time description do not match");
            Assert.That(lastRowActualPrice == "$13.00", "Actual time price and expected time price do not match");

            //driver.Quit();
            CloseTestRun();
        }

        [When(@"I update Time record containing code '([^']*)' with '([^']*)'")]
        public void WhenIUpdateTimeRecordContainingCodeWith(string ExistingCode, string NewCode)
        {
            // edit Time record
            tmPageObj.EditTime(driver, ExistingCode, NewCode);
        }

        [Then(@"The Time record code was updated successfully with '([^']*)'")]
        public void ThenTheTimeRecordCodeWasUpdatedSuccessfullyWith(string NewCode)
        {
            // find and click on the Go to the last page button
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")).Click();
            Thread.Sleep(2000);
            string editedCode = tmPageObj.GetEditedCode(driver);

            Assert.That(editedCode == NewCode, "Edit FAILED because actual code and expected code do not match");

            //driver.Quit();
            CloseTestRun();
        }

        [When(@"I delete existing Time record with code of '([^']*)'")]
        public void WhenIDeleteExistingTimeRecordWithCodeOf(string ExistingCode)
        {
            // delete Time record
            tmPageObj.DeleteTime(driver, ExistingCode);
        }

        [Then(@"The Time record with code '([^']*)' was deleted successfully")]
        public void ThenTheTimeRecordWithCodeWasDeletedSuccessfully(string ExistingCode)
        {
            // fails to find the element because deleted record was last record on the last page and the program leaves the user on
            // the last page with no rows of records to find so clicking Go to the first page button, then Go to the last page button
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[1]/span")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")).Click();
            Thread.Sleep(1500);
            string deletedCode = tmPageObj.GetCode(driver);

            Assert.That(deletedCode != ExistingCode, "Delete FAILED because actual code and expected code match");

            //driver.Quit();
            CloseTestRun();
        }

    }
}
