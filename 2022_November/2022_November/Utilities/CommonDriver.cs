//using _2022_November.Pages;
//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace _2022_November.Utilities
{
    public class CommonDriver
    {
        //public static IWebDriver driver;
        public IWebDriver driver;

        //[SetUp]
        [OneTimeSetUp]
        public void LoginSteps()
        {
            Console.WriteLine("**Starting Turnup portal script");

            // open Chrome browser because of using OpenQA.Selenium.Chrome; statement at top of code
            driver = new ChromeDriver();

            // login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);

            // check if user has logged in successfully by capturing text in top right-hand corner of screen
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

            //if (helloHari.Text == "Hello hari!")
            //{
            //Console.WriteLine("Logged in successfully, test passed.");
            //Assert.Pass("Logged in successfully, test passed.");
            //}
            //else
            //{
            //Console.WriteLine("Login failed, test failed.");
            //Assert.Fail("Login failed, test failed.");
            //    driver.Quit();
            //    Environment.Exit(0);
            //}
            Assert.That(helloHari.Text == "Hello hari!", "Login failed, test failed");
        }
        //[TearDown]
        [OneTimeTearDown]
        public void CloseTestRun()
        {
            //Thread.Sleep(3000);
            Console.WriteLine("**Exiting/Ending Turnup portal script");
            driver.Quit();
        }
    }
}
