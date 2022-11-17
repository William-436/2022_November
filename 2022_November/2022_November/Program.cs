
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



// open Chrome browser
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

// launch Turnup portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

// identify Username textbox and enter valid username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

// identify Password textbox and enter valid password
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

// click Log in button
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginButton.Click();

// check if user has logged in successfully
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

if (helloHari.Text == "Hello hari!")
{
    Console.WriteLine("Logged in successfully, test passed.");
}
else
{
    Console.WriteLine("Login failed, test failed.");

}