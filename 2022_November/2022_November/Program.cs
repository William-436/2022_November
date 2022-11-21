
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


// open Chrome browser
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

Console.WriteLine("**Starting Turnup portal script");
// Log in to the Turnup portal
Console.WriteLine("Log in to the Turnup portal");

// launch Turnup portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

// find Username textbox and enter valid username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

// find Password textbox and enter valid password
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

// find and click Log in button
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginButton.Click();

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

// create a new Time record in the Time and Material module
Console.WriteLine("Create a new Time record in the Time and Materials module");

// navigate to Time and Materials page by 1st finding and clicking the Administration link
//IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
//administrationDropdown.Click();
driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
Thread.Sleep(500);

// select Time & Materials from the Administration drop-down list
//IWebElement tandmElement = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
//tandmElement.Click();
driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();

// find and click on Create New button
Thread.Sleep(1500);
//IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
//createNewButton.Click();
driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a")).Click();
Thread.Sleep(500);

// find and expand TypeCode drop-down box
//IWebElement typecodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
//typecodeDropdown.Click();
driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span")).Click();
Thread.Sleep(500);

// find and select Time in TypeCode drop-down list
//IWebElement timeElement = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
//timeElement.Click();
driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]")).Click();

// find and enter code in the Code textbox
//IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
//codeTextbox.SendKeys("my time code");
driver.FindElement(By.Id("Code")).SendKeys("my time code");

// find and enter description in the Description textbox
//IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
//descriptionTextbox.SendKeys("my time description");
driver.FindElement(By.Id("Description")).SendKeys("my time description");

// find and enter price in the Price per unit textbox but 1st click the overlapping tag
//IWebElement overlappingTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
//overlappingTag.Click();
driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();

//IWebElement priceperunitTextbox = driver.FindElement(By.Id("Price"));
//priceperunitTextbox.SendKeys("13");
driver.FindElement(By.Id("Price")).SendKeys("13");

// find and click Save button
//IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
//saveButton.Click();
driver.FindElement(By.Id("SaveButton")).Click();
Thread.Sleep(2000);

// check if new time record has been created successfully
// find and click on the Go to the last page button
//IWebElement lastpageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
//lastpageButton.Click();
driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")).Click();

// replace digit in tr[] with last() to get last row in table
//IWebElement lastrowCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

//if (lastrowCode.Text == "my time code")
if (driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]")).Text == "my time code")
{
    Console.WriteLine("Time record created successfully");
}
else
{
    Console.WriteLine("Time record wasn't created successfully");
    driver.Quit();
    Environment.Exit(0);
    //    Console.WriteLine("--program continues to run because I do not know how to stop it");
}

// edit my new Time record and verify the edited value
Console.WriteLine("Edit the new Time record");

// find edit button in last row
// replace digit in tr[] with last() to get last row in table
//IWebElement lasteditButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
//lasteditButton.Click();
driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]")).Click();

// edit the code in the Code textbox, clearing the value before entering the new value
IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
codeTextbox.Clear();
codeTextbox.SendKeys("my edited time code");

// find and click Save button
//IWebElement saveButton2 = driver.FindElement(By.Id("SaveButton"));
//saveButton2.Click();
driver.FindElement(By.Id("SaveButton")).Click();
Thread.Sleep(2000);

// check if edited time record has been updated successfully
// find and click on the Go to the last page button
//IWebElement lastpageButton2 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
//lastpageButton2.Click();
driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")).Click();

// replace digit in tr[] with last() to get last row in table
//IWebElement lastrowCode2 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

//if (lastrowCode2.Text == "my edited time code")
if (driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]")).Text == "my edited time code")
{
    Console.WriteLine("Time record was edited successfully");
}
else
{
    Console.WriteLine("Time record wasn't edited successfully");
    driver.Quit();
    Environment.Exit(0);
    //    Console.WriteLine("--program continues to run because I do not know how to stop it");
}

// delete my edited Time record and verify it was deleted by not finding it in the last row
// because I don't know how to extract the total rec cnt from the lower-right corner
Console.WriteLine("Delete the new & edited Time record");

// find and click Delete button in last row by replacing digit in tr[] with last()
//IWebElement lastdeleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
//lastdeleteButton.Click();
driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]")).Click();
Thread.Sleep(500);

// click OK button in pop-up confirmation window - item is deleted and user remains on last page
driver.SwitchTo().Alert().Accept();
Thread.Sleep(3000);

if (driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]")).Text == "my edited time code")
{
    Console.WriteLine("Edited Time record wasn't deleted successfully");
    driver.Quit();
    Environment.Exit(0);
    //    Console.WriteLine("--program continues to run because I do not know how to stop it");
}
else
{
    Console.WriteLine("Edited Time record was deleted successfully");
}

// create a new Material record in the Time and Material module
Console.WriteLine("Create a new Material record in the Time and Materials module");

// Find and click on Create New button
//Thread.Sleep(1500);
//IWebElement createNewButton2 = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
//createNewButton2.Click();
//createNewButton.Click();
driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a")).Click();
Thread.Sleep(500);

// expand TypeCode drop-down box
//IWebElement typecode2Dropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
//typecode2Dropdown.Click();
driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span")).Click();
Thread.Sleep(500);

// select Material in drop-down list
//IWebElement materialElement = driver.FindElement(By.XPath("//*[@id=\"TypeCode_option_selected\"]"));
//materialElement.Click();
driver.FindElement(By.XPath("//*[@id=\"TypeCode_option_selected\"]"));

// find and enter code in the Code textbox
//IWebElement code2Textbox = driver.FindElement(By.Id("Code"));
//code2Textbox.SendKeys("my material code");
driver.FindElement(By.Id("Code")).SendKeys("my material code");

// find and enter description in the Description textbox
//IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
//descriptionTextbox.SendKeys("my material description");
driver.FindElement(By.Id("Description")).SendKeys("my material description");

// find and enter price in the Price per unit textbox but 1st click the overlapping tag
//IWebElement overlappingTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
//overlappingTag.Click();
driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();

//IWebElement priceperunitTextbox = driver.FindElement(By.Id("Price"));
//priceperunitTextbox.SendKeys("1333");
driver.FindElement(By.Id("Price")).SendKeys("1333");

// find and click Save button
//IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
//saveButton.Click();
driver.FindElement(By.Id("SaveButton")).Click();
Thread.Sleep(2000);

// check if new material record has been created successfully by 1st click on last page button
//IWebElement lastpageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
//lastpageButton.Click();
driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")).Click();

// replace digit in [] with last() to get last row in table
//IWebElement lastrowCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

//if (lastrowCode.Text == "my material code")
if (driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]")).Text == "my material code")
{
    Console.WriteLine("Material record created successfully");
}
else
{
    Console.WriteLine("Material record wasn't created successfully");
    driver.Quit();
    Environment.Exit(0);
    //    Console.WriteLine("--program continues to run because I do not know how to stop it");
}

// edit my Material record and verify the edited value
Console.WriteLine("Edit the new Material record");

// find edit button in last row
// replace digit in tr[] with last() to get last row in table
driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]")).Click();

// edit the code in the Code textbox, clearing the value before entering the new value
IWebElement codeTextbox2 = driver.FindElement(By.Id("Code"));
codeTextbox2.Clear();
codeTextbox2.SendKeys("my edited mtl code");

// find and click Save button
driver.FindElement(By.Id("SaveButton")).Click();
Thread.Sleep(2000);

// check if edited material record has been updated successfully
// find and click on the Go to the last page button
driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")).Click();

// replace digit in tr[] with last() to get last row in table
if (driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]")).Text == "my edited mtl code")
{
    Console.WriteLine("Material record was edited successfully");
}
else
{
    Console.WriteLine("Material record wasn't edited successfully");
    driver.Quit();
    Environment.Exit(0);
    //    Console.WriteLine("--program continues to run because I do not know how to stop it");
}

// delete my edited Material record and verify it was deleted by not finding it in the last row
// because I don't know how to extract the total rec cnt from the lower-right corner
Console.WriteLine("Delete the new & edited Material record");

// find and click Delete button in last row by replacing digit in tr[] with last()
driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]")).Click();
Thread.Sleep(500);

// click OK button in pop-up confirmation window - item is deleted and user remains on last page
driver.SwitchTo().Alert().Accept();
Thread.Sleep(3000);

if (driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]")).Text == "my edited mtl code")
{
    Console.WriteLine("Edited Material record wasn't deleted successfully");
    driver.Quit();
    Environment.Exit(0);
//    Console.WriteLine("--program continues to run because I do not know how to stop it");
}
else
{
    Console.WriteLine("Edited Material record was deleted successfully");
}

Console.WriteLine("**Exiting/Ending Turnup portal script");
