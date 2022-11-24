using _2022_November.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using _2022_November.Utilities;

namespace _2022_November.Tests
{
    [TestFixture]
    public class TM_Tests : CommonDriver
    {
        [SetUp]
        public void LoginSteps()
        {
            Console.WriteLine("**Starting Turnup portal script");

            // open Chrome browser because of using OpenQA.Selenium.Chrome; statement at top of code
            driver = new ChromeDriver();

            // login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);

            // check if user has logged in successfully by capturing text in top right-hand cornerof screen
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

            if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("Logged in successfully, test passed.");
            }
            else
            {
                Console.WriteLine("Login failed, test failed.");
                driver.Quit();
                Environment.Exit(0);
                //  Console.WriteLine("--program continues to run because I do not know how to stop it");
            }

            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);
        }

        [Test]
        public void CreateTime_Test()
        {
            // TM page object initialization and definition
            TMPage tmPageObj = new TMPage();

            // create a new Time record in the Time and Material module
            tmPageObj.CreateTime(driver);
        }

        [Test]
        public void EditTime_Test()
        {
            // TM page object initialization and definition
            TMPage tmPageObj = new TMPage();

            // edit my new Time record and verify the edited value
            tmPageObj.EditTime(driver);
        }

        [Test]
        public void DeleteTime_Test()
        {
            // TM page object initialization and definition
            TMPage tmPageObj = new TMPage();

            // delete my edited Time record and verify it was deleted by not finding it in the last row
            // because I don't know how to extract the total rec cnt from the lower-right corner
            tmPageObj.DeleteTime(driver);
        }

        [Test]
        public void CreateMaterial_Test()
        {
            // TM page object initialization and definition
            TMPage tmPageObj = new TMPage();

            // create a new Material record in the Time and Material module
            tmPageObj.CreateMaterial(driver);
        }

        [Test]
        public void EditMaterial_Test()
        {
            // TM page object initialization and definition
            TMPage tmPageObj = new TMPage();

            // edit my new Material record and verify the edited value
            tmPageObj.EditMaterial(driver);
        }

        [Test]
        public void DeleteMaterial_Test()
        {
            // TM page object initialization and definition
            TMPage tmPageObj = new TMPage();

            // delete my edited Material record and verify it was deleted by not finding it in the last row
            // because I don't know how to extract the total rec cnt from the lower-right corner
            tmPageObj.DeleteMaterial(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {
            Console.WriteLine("**Exiting/Ending Turnup portal script");
            driver.Quit();
        }
    }
}
