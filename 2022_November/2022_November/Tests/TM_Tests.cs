
using _2022_November.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

Console.WriteLine("**Starting Turnup portal script");

// open Chrome browser
IWebDriver driver = new ChromeDriver();

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
//    Console.WriteLine("--program continues to run because I do not know how to stop it");
}

// Home page object initialization and definition
HomePage homePageObj = new HomePage();
homePageObj.GoToTMPage(driver);

// TM page object initialization and definition
TMPage tmPageObj = new TMPage();

// create a new Time record in the Time and Material module
tmPageObj.CreateTime(driver);

// edit my new Time record and verify the edited value
tmPageObj.EditTime(driver);

// delete my edited Time record and verify it was deleted by not finding it in the last row
// because I don't know how to extract the total rec cnt from the lower-right corner
tmPageObj.DeleteTime(driver);

// create a new Material record in the Time and Material module
tmPageObj.CreateMaterial(driver);

// edit my new Material record and verify the edited value
tmPageObj.EditMaterial(driver);

// delete my edited Material record and verify it was deleted by not finding it in the last row
// because I don't know how to extract the total rec cnt from the lower-right corner
tmPageObj.DeleteMaterial(driver);

Console.WriteLine("**Exiting/Ending Turnup portal script");
