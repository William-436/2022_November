//using _2022_November.Utilities;
//using OpenQA.Selenium;

namespace _2022_November.Pages
{
    public class HomePage
    {
        public void GoToTMPage(IWebDriver driver)
        {
            // navigate to Time and Materials page by 1st finding and clicking the Administration link
            //IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            //administrationDropdown.Click();
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
            //Thread.Sleep(500);
            Wait.WaitForElementToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 2);

            // select Time & Materials from the Administration drop-down list
            //IWebElement tandmElement = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            //tandmElement.Click();
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();
            // wait up to 3 seconds for TM page to load
            Wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 3);
        }
        public void GoToEmployeePage(IWebDriver driver)
        {
            // navigate to Employee page by 1st finding and clicking the Administration link
            //IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            //administrationDropdown.Click();
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
            //Thread.Sleep(500);
            Wait.WaitForElementToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 2);

            // select Employee from the Administration drop-down list
            //IWebElement employeeElement = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            //employeeElement.Click();
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a")).Click();
            // wait up to 3 seconds for Employee page to load - wait for Create button to become clickable
            Wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id=\"container\"]/p/a", 3);
        }
    }
}
