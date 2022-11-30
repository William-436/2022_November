//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;

namespace _2022_November.Pages
{
    public class LoginPage
    {
        public void LoginActions(IWebDriver driver)
        {
            // Log in to the Turnup portal
            Console.WriteLine("Log in to the Turnup portal");

            driver.Manage().Window.Maximize();
            // launch Turnup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            Thread.Sleep(1500);
            //driver.Navigate().GoToUrl("https://google.com.au");

            try
            {
                // find Username textbox and enter valid username
                IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
                usernameTextbox.SendKeys("hari");
            }
            catch (Exception ex)
            {
                Assert.Fail("Turnup portal page did not launch", ex.Message);
                //Console.WriteLine("Turnup portal page did not launch");
            }

            // find Password textbox and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            // find and click Log in button
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();

        }
    }
}
